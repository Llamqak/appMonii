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
    public partial class useCaseEditIncome : Form
    {
        public string IncomeID { get; set; }

        public string IncomeName => txtEditIncomeName.Text.Trim();
        public string IncomeDescription => txtEditDescIncome.Text.Trim();
        public float IncomeAmount => float.TryParse(txtEditAmountIncome.Text, out float amount) ? amount : 0;
        public DateTime IncomeDate => dtpEditIncome.Value;
        public useCaseEditIncome(string id)
        {
            InitializeComponent();
            IncomeID = id;
        }
   


        private void btnSaveEditIncome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEditIncomeName.Text) || string.IsNullOrWhiteSpace(txtEditAmountIncome.Text))
            {
                MessageBox.Show("Por favor llena todos los campos.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
