using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace iguMonii
{
    public partial class frmCategoryLimits : Form
    {
        public Dictionary<string, float> UpdatedLimits { get; private set; }

        public frmCategoryLimits(Dictionary<string, float> currentLimits)
        {
            InitializeComponent();
            UpdatedLimits = new Dictionary<string, float>(currentLimits);
            LoadLimits();
        }

        private void LoadLimits()
        {
            dgvLimitsCategoryLimits.Columns.Clear(); 

            dgvLimitsCategoryLimits.Columns.Add("CategoryName", "Categoría");
            dgvLimitsCategoryLimits.Columns.Add("LimitAmount", "Límite");

            dgvLimitsCategoryLimits.Rows.Clear();

            foreach (var limit in UpdatedLimits)
            {
                dgvLimitsCategoryLimits.Rows.Add(limit.Key, limit.Value);
            }
        }


        private void btnSaveCategoryLimits_Click(object sender, EventArgs e)
        {
            UpdatedLimits.Clear();
            foreach (DataGridViewRow row in dgvLimitsCategoryLimits.Rows)
            {
                if (row.IsNewRow) continue; 

                string categoryName = row.Cells[0].Value?.ToString();
                if (float.TryParse(row.Cells[1].Value?.ToString(), out float limitAmount) &&
                    !string.IsNullOrEmpty(categoryName))
                {
                    UpdatedLimits[categoryName] = limitAmount;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}