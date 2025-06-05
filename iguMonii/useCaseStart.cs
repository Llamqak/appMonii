using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iguMonii
{
    public partial class useCaseStart : Form
    {
        public useCaseStart()
        {
            InitializeComponent();
        }
        private void ShowInPanel(Form form)
        {
            ContentPanel.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(form);
            form.Show();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            var form = new useCaseManageIncomes();
            ShowInPanel(form);
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            var form = new useCaseManageExpenses();
            ShowInPanel(form);
        }

        private void btnSaving_Click(object sender, EventArgs e)
        {
            var form = new useCaseManageSavings();
            ShowInPanel(form);
        }
    }
}
