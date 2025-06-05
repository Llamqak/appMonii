using appMonii.pkgDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace iguMonii
{
    public partial class useCaseManageSavings : Form
    {
        private ClsController attFacade = ClsController.opGetInstance();
        public useCaseManageSavings()
        {
            InitializeComponent();
        }
        #region Add Saving
        private static int ouidCounter = 1;
        
        
        private void btnAddSaving_Click(object sender, EventArgs e)
        {
            string OUID = ouidCounter.ToString();
            ouidCounter++;
            string name = txtSavingName.Text;
            string description = "none";
            DateTime date = DateTime.Now;
            float amount = 0;
            float cap = float.Parse(txtSavingCap.Text);
            float periodicFee= float.Parse(txtSavingPeriodicFee.Text);
            DateTime TimeLimit = dtpSavingTimeLimit.Value;
            string frecuency = txtSavingFrecuency.Text;
            if (!attFacade.opRegisterSaving(OUID, name, description, date, amount, cap, TimeLimit, periodicFee, frecuency))
            {
                MessageBox.Show("Saving successfully registered");
               dgvSaving.Rows.Add(name,cap, periodicFee, TimeLimit,frecuency);
            }
            else
            {
                MessageBox.Show("There is already an saving with that ID");
            }

        }
        #endregion

        private void tnEditSaving_Click(object sender, EventArgs e)
        {
            if (dgvSaving.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select the Name cell of the saving to edit.");
                return;
            }

            int selectedColumnIndex = dgvSaving.SelectedCells[0].ColumnIndex;
            int rowIndex = dgvSaving.SelectedCells[0].RowIndex;

            if (selectedColumnIndex != 0)
            {
                MessageBox.Show("Please select the Name to edit the saving.");
                return;
            }

            string selectedName = dgvSaving.Rows[rowIndex].Cells["colName"].Value?.ToString();
            MessageBox.Show("Nombre seleccionado: " + selectedName);
            //MessageBox.Show("ID seleccionado: " + OUID);

            if (string.IsNullOrWhiteSpace(selectedName))
            {
                MessageBox.Show("Invalid Name selected.");
                return;
            }
            useCaseEditSaving editSaving = new useCaseEditSaving(selectedName);

            if (editSaving.ShowDialog() == DialogResult.OK)
            {
               /*
                bool success = attFacade.opUpdateSaving(OUID, editSaving.SavingName, "none", editSaving.SavingCap, editSaving.SavingTimeLimit, 
                    editSaving.SavingPeriodicFee,editSaving.SavingFrecuency, DateTime.Now, 0);
                if (success)
                {
                    
                    DataGridViewRow row = dgvSaving.Rows[rowIndex];
                    row.Cells["colName"].Value = editSaving.SavingName;
                    row.Cells["colCAP"].Value = editSaving.SavingCap;
                    row.Cells["colPeriodicFee"].Value = editSaving.SavingPeriodicFee;
                    row.Cells["colTimeLimit"].Value = editSaving.SavingTimeLimit;
                    row.Cells["colFrecuency"].Value = editSaving.SavingFrecuency;

                    MessageBox.Show("Successful Saving edition");
                }
                else
                {
                    MessageBox.Show("Saving not found to edit");
                }
               */
            }
        }

    }
}

