using appMonii.pkgDomain;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace iguMonii
{
    public partial class useCaseManageCategories : Form
    {
        private readonly ClsController _controller = ClsController.opGetInstance();
        private clsCategory<string> _currentCategory;


        public useCaseManageCategories()
        {
            InitializeComponent();
            ConfigureDataGrid();
            LoadCategories();
            dgvCategories.SelectionChanged += dgvCategories_SelectionChanged;
        }

        private void ConfigureDataGrid()
        {
            dgvCategories.Columns.Clear();
            dgvCategories.AutoGenerateColumns = false;

            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "Nombre",
                DataPropertyName = "Name"  
            });

            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescription",
                HeaderText = "Descripción",
                DataPropertyName = "Description"
            });
        }


        private void LoadCategories()
        {
            // Desvincular temporalmente el evento
            dgvCategories.SelectionChanged -= dgvCategories_SelectionChanged;

            try
            {
                dgvCategories.DataSource = null;
                var categories = _controller.opGetAllCategories();

                dgvCategories.DataSource = new BindingList<clsCategory<string>>(categories);

                ClearInputs();
                _currentCategory = null;

                if (dgvCategories.Rows.Count > 0)
                {
                    dgvCategories.Rows[0].Selected = true;
                    _currentCategory = dgvCategories.Rows[0].DataBoundItem as clsCategory<string>;
                    UpdateInputsFromCurrentCategory();
                }
            }
            finally
            {
                dgvCategories.SelectionChanged += dgvCategories_SelectionChanged;
            }
        }

        private void btnAddCategories_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameCategories.Text))
            {
                MessageBox.Show("El nombre de la categoría no puede estar vacío.");
                return;
            }

            string ouid = Guid.NewGuid().ToString();
            bool success = _controller.opRegisterCategory(
                ouid,
                txtNameCategories.Text,
                txtDescriptionCategories.Text,
                txtNameCategories.Text 
            );

            if (success)
            {
                MessageBox.Show("Categoría agregada exitosamente.");
                ClearInputs();
                LoadCategories();
            }
            else
            {
                MessageBox.Show("Error al agregar la categoría.");
            }
        }

        private void btnUpdateCategories_Click(object sender, EventArgs e)
        {
            if (_currentCategory == null)
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            bool success = _controller.opUpdateCategory(
                _currentCategory.opGetOUID(),
                txtNameCategories.Text,
                txtDescriptionCategories.Text,
                txtNameCategories.Text
            );

            if (success)
            {
                MessageBox.Show("Categoría actualizada.");
                ClearInputs();
                LoadCategories();
            }
            else
            {
                MessageBox.Show("Error al actualizar.");
            }
        }

        private void btnDeleteCategories_Click(object sender, EventArgs e)
        {
            if (_currentCategory == null)
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            if (MessageBox.Show("¿Eliminar la categoría?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool success = _controller.opDeleteCategory(_currentCategory.opGetOUID());
                if (success)
                {
                    MessageBox.Show("Categoría eliminada.");
                    ClearInputs();
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Error al eliminar.");
                }
            }
        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0 || dgvCategories.SelectedRows[0].Index < 0)
            {
                ClearInputs();
                _currentCategory = null;
                return;
            }

            var selectedRow = dgvCategories.SelectedRows[0];
            _currentCategory = selectedRow.DataBoundItem as clsCategory<string>;
            UpdateInputsFromCurrentCategory();
        }

        private void UpdateInputsFromCurrentCategory()
        {
            if (_currentCategory != null)
            {
                txtNameCategories.Text = _currentCategory.opGetName();
                txtDescriptionCategories.Text = _currentCategory.opGetDescription();
            }
            else
            {
                ClearInputs();
            }
        }



        private void ClearInputs()
        {
            txtNameCategories.Clear();
            txtDescriptionCategories.Clear();
        }
    }
}
