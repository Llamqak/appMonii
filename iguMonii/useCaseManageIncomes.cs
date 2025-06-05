using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appMonii.pkgDomain;
using Microsoft.VisualBasic;

namespace iguMonii
{
    public partial class useCaseManageIncomes : Form
    {
        private ClsController attFacade = ClsController.opGetInstance();
        public useCaseManageIncomes()
        {
            InitializeComponent();

        }
        #region Add Income
        private static int incomeCounter = 1;
        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            string OUID = incomeCounter.ToString();
            incomeCounter++;
            string name = txtNameIncome.Text;
            string description = txtDescIncome.Text;
            float amount = float.Parse(txtAmountIncome.Text);
            DateTime date = dtpIncome.Value;

            if (!attFacade.opRegisterIncome(OUID, name, description, amount, date))
            {
                MessageBox.Show("Income successfully registered");
                dgvIncome.Rows.Add(OUID,name, description, amount, date);
            }
            else
            {
                MessageBox.Show("There is already an income with that ID");
            }
        }
        #endregion
        #region Edit Income
        private void btnEditIncome_Click(object sender, EventArgs e)
        {

            if (dgvIncome.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select the ID cell of the income to edit.");
                return;
            }

            int selectedColumnIndex = dgvIncome.SelectedCells[0].ColumnIndex;
            int rowIndex = dgvIncome.SelectedCells[0].RowIndex;

            if (selectedColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID to edit the income.");
                return;
            }

            string selectedID = dgvIncome.Rows[rowIndex].Cells["colID"].Value?.ToString();
            MessageBox.Show("ID seleccionado: " + selectedID);

            if (string.IsNullOrWhiteSpace(selectedID))
            {
                MessageBox.Show("Invalid ID selected.");
                return;
            }
            useCaseEditIncome editIncome = new useCaseEditIncome(selectedID);
            if (editIncome.ShowDialog() == DialogResult.OK) {

                if (!attFacade.opUpdateIncome(editIncome.IncomeID, editIncome.IncomeName, editIncome.IncomeDescription,
                    editIncome.IncomeDate, editIncome.IncomeAmount)) {
                    dgvIncome.Rows.Clear();
                    dgvIncome.Rows.Add(editIncome.IncomeID,editIncome.IncomeName,editIncome.IncomeDescription,editIncome.IncomeAmount,editIncome.IncomeDate);
                    MessageBox.Show("Successful iincome edition");
                    
                }
                else
                {
                    MessageBox.Show("Income not found to edit");
                }
            
            }

        }
        #endregion
    }
}

