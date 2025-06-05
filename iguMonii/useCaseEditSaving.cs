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
    public partial class useCaseEditSaving : Form
    {
        public string SavingName { get; set; }
        public float SavingCap => float.TryParse(txtEditSavingCap.Text, out float amount) ? amount : 0;
        public float SavingPeriodicFee => float.TryParse(txtEditSavingPeriodicFee.Text, out float amount) ? amount : 0;
        public DateTime SavingTimeLimit => dtpEditSaving.Value;
        public string SavingFrecuency => txtEditSavingFrecuency.Text.Trim();
        
        public useCaseEditSaving(String Name)
        {
            InitializeComponent();
            SavingName = Name;
        }

        private void btnSaveSaving_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEditSavingCap.Text) || string.IsNullOrWhiteSpace(txtEditSavingFrecuency.Text))
            {
                MessageBox.Show("Por favor llena todos los campos.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
