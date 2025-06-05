using appMonii.pkgDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

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

            cmbCategoryExpenses.DisplayMember = "opGetName"; 
            cmbCategoryExpenses.ValueMember = "opGetOUID";   
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

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (cmbCategoryExpenses.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una categoría");
                return;
            }

            var selectedCategory = cmbCategoryExpenses.SelectedItem as clsCategory<String>;
            string ouid = Guid.NewGuid().ToString();

            bool success = controller.opRegisterSpent(
                ouid,
                txtNameExpenses.Text,
                txtDescriptionExpenses.Text,
                float.Parse(txtAmountExpenses.Text),
                dtpDateExpenses.Value,
                selectedCategory
            );

            if (success)
            {
                MessageBox.Show("Gasto registrado exitosamente");
                UpdateExpensesGrid();
                CheckCategoryLimit(selectedCategory);
                ClearForm();
            }
        }

        private void UpdateExpensesGrid()
        {
            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = controller.MyExpenses
                .OrderByDescending(e => e.Date)
                .Select(e => new {
                    e.Date,
                    Category = e.Category[0].opGetName(),
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
                .Where(e => e.Category[0].opGetOUID() == category.opGetOUID())
                .Sum(e => e.Amount);

            if (categoryLimits.TryGetValue(categoryName, out float limit) && totalSpent > limit)
            {
                MessageBox.Show($"¡Alerta! Has excedido el límite de {categoryName} por ${totalSpent - limit}");
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
            StringBuilder summary = new StringBuilder("Resumen por categoría:\n\n");

            foreach (var category in categories)
            {
                string name = category.opGetName();
                float spent = controller.MyExpenses
                    .Where(e => e.Category[0].opGetOUID() == category.opGetOUID())
                    .Sum(e => e.Amount);

                float limit = categoryLimits.ContainsKey(name) ? categoryLimits[name] : 0;

                summary.AppendLine($"{name}:");
                summary.AppendLine($"  Gastado: ${spent:N0}");
                summary.AppendLine($"  Límite:  ${limit:N0}");
                summary.AppendLine($"  Estado:  {(spent > limit ? "EXCEDIDO" : "Dentro de límite")}");
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
    }
}
