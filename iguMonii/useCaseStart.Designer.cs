namespace iguMonii
{
    partial class useCaseStart
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnSideLeft = new System.Windows.Forms.Panel();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnSaving = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.pnSideLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSideLeft
            // 
            this.pnSideLeft.BackgroundImage = global::iguMonii.Properties.Resources.Captura_de_pantalla_2025_05_29_232944;
            this.pnSideLeft.Controls.Add(this.btnCategory);
            this.pnSideLeft.Controls.Add(this.btnSaving);
            this.pnSideLeft.Controls.Add(this.btnExpense);
            this.pnSideLeft.Controls.Add(this.btnIncome);
            this.pnSideLeft.Location = new System.Drawing.Point(0, 0);
            this.pnSideLeft.Name = "pnSideLeft";
            this.pnSideLeft.Size = new System.Drawing.Size(163, 356);
            this.pnSideLeft.TabIndex = 0;
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCategory.Location = new System.Drawing.Point(45, 221);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(84, 23);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Categories";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnSaving
            // 
            this.btnSaving.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaving.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaving.Location = new System.Drawing.Point(45, 179);
            this.btnSaving.Name = "btnSaving";
            this.btnSaving.Size = new System.Drawing.Size(84, 23);
            this.btnSaving.TabIndex = 2;
            this.btnSaving.Text = "Saving";
            this.btnSaving.UseVisualStyleBackColor = false;
            this.btnSaving.Click += new System.EventHandler(this.btnSaving_Click);
            // 
            // btnExpense
            // 
            this.btnExpense.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpense.Location = new System.Drawing.Point(45, 137);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(84, 23);
            this.btnExpense.TabIndex = 1;
            this.btnExpense.Text = "Expense";
            this.btnExpense.UseVisualStyleBackColor = false;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncome.Location = new System.Drawing.Point(45, 96);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(84, 23);
            this.btnIncome.TabIndex = 0;
            this.btnIncome.Text = "Income";
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContentPanel.Location = new System.Drawing.Point(161, -33);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(578, 389);
            this.ContentPanel.TabIndex = 1;
            // 
            // useCaseStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 357);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.pnSideLeft);
            this.Name = "useCaseStart";
            this.Text = "Form1";
            this.pnSideLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSideLeft;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnSaving;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Panel ContentPanel;
    }
}

