using appMonii.pkgDomain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace iguMonii
{
    public partial class useCaseManageExpenses : Form
    {
        private readonly ClsController controller = ClsController.opGetInstance();
        private Dictionary<string, float> categoryLimits = new Dictionary<string, float>();
        private List<clsCategory<string>> categories = new List<clsCategory<string>>();

        public useCaseManageExpenses()
        {
            InitializeComponent();
            this.Load += frmExpenses_Load; 
            LoadCategories();
            InitializeCategoryLimits();
        }

        private void frmExpenses_Load(object sender, EventArgs e)
        {
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Date",
                HeaderText = "Date",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Category",
                HeaderText = "Category"
            });

            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "AmountExpenses", 
                HeaderText = "Amount",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C0" }
            });

            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name", 
                HeaderText = "Name"
            });

            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Description", 
                HeaderText = "Description"
            });

            UpdateExpensesGrid();
            UpdateCategorySummary();
        }

        private void LoadCategories()
        {
            categories = controller.opGetAllCategories(); 

            cmbCategoryExpenses.DataSource = null; // reset
            cmbCategoryExpenses.DisplayMember = "Name";
            cmbCategoryExpenses.ValueMember = "OUID";
            cmbCategoryExpenses.DataSource = categories;
        }

        private void InitializeCategoryLimits()
        {
            categoryLimits = new Dictionary<string, float>
        {
            {"Comida", 500000},
            {"Transporte", 300000},
            {"Vivienda", 1000000},
            {"Entretenimiento", 200000},
            {"Salud", 400000},
            {"Otros", 300000}
        };
        }

        private void UpdateExpensesGrid()
        {

            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = controller.MyExpenses
                .OrderByDescending(e => e.Date)
                .Select(e => new {
                    e.Date,
                    Category = e.Category?.opGetName() ?? "(Sin categoría)",
                    Name = e.opGetName(),
                    Description = e.opGetDescription(),
                    AmountExpenses = e.Amount
                })
                .ToList();
        }


        private void CheckCategoryLimit(clsCategory<String> category)
        {
            string categoryName = category.opGetName();
            float totalSpent = controller.MyExpenses
                .Where(e => e.Category.opGetOUID() == category.opGetOUID())
                .Sum(e => e.Amount);

            if (categoryLimits.TryGetValue(categoryName, out float limit) && totalSpent > limit)
            {
                MessageBox.Show($"¡Alert! \r\nYou have exceeded the limit of {categoryName} by${totalSpent - limit}");
            }

            if (totalSpent > limit * 0.9)
            {
                dgvExpenses.Rows.Cast<DataGridViewRow>()
                    .Where(r => r.Cells["Category"].Value.ToString() == categoryName)
                    .ToList()
                    .ForEach(r => r.DefaultCellStyle.BackColor = Color.LightPink);
            }
        }

        private void ClearForm()
        {
            txtNameExpenses.Clear();
            txtDescriptionExpenses.Clear();
            txtAmountExpenses.Clear();
            cmbCategoryExpenses.SelectedIndex = -1;
        }

        private void UpdateCategorySummary()
        {
            // Cargar categorías de nuevo si algo cambió
            categories = controller.opGetAllCategories();

            StringBuilder summary = new StringBuilder("---:\n\n");

            foreach (var category in categories)
            {
                string name = category.opGetName();
                float spent = controller.MyExpenses
                    .Where(e => e.Category != null && e.Category.opGetOUID() == category.opGetOUID())
                    .Sum(e => e.Amount);

                float limit = categoryLimits.ContainsKey(name) ? categoryLimits[name] : 0;

                summary.AppendLine($"{name}:");
                summary.AppendLine($"  Spented: ${spent:N0}");
                summary.AppendLine($"  Limit:  ${limit:N0}");
                summary.AppendLine($"  State:  {(spent > limit ? "EXEDED" : "Within the limit")}");
                summary.AppendLine();
            }

            txtCategorySummaryExpenses.Text = summary.ToString();
        }

        private void btnEditLimitsExpenses_Click(object sender, EventArgs e)
        {
            using (var form = new frmCategoryLimits(categoryLimits))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    categoryLimits = form.UpdatedLimits;
                    UpdateCategorySummary();
                }
            }
        }

        private void btnLogExpenses_Click(object sender, EventArgs e)
        {
            if (cmbCategoryExpenses.SelectedItem == null)
            {
                MessageBox.Show("Select one category");
                return;
            }

            var selectedCategory = cmbCategoryExpenses.SelectedItem as clsCategory<string>;
            if (selectedCategory == null)
            {
                MessageBox.Show("Invalid category selection");
                return;
            }

            string ouid = Guid.NewGuid().ToString();

            bool success = controller.opRegisterSpent(
                ouid,
                txtNameExpenses.Text,
                txtDescriptionExpenses.Text,
                float.Parse(txtAmountExpenses.Text),
                dtpDateExpenses.Value,
                selectedCategory // ¡Usamos la categoría exacta!
            );

            if (success)
            {
                MessageBox.Show("Spent registered correctly");

                // Refrescar la lista para que todo quede sincronizado
                UpdateExpensesGrid();
                UpdateCategorySummary();
                CheckCategoryLimit(selectedCategory);
                ClearForm();
            }
        }
    }
}
