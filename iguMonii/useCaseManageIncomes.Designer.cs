namespace iguMonii
{
    partial class useCaseManageIncomes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditIncome = new System.Windows.Forms.Button();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.lblTitleA = new System.Windows.Forms.Label();
            this.lblTitleD = new System.Windows.Forms.Label();
            this.lblTitlteN = new System.Windows.Forms.Label();
            this.txtDtpTitle = new System.Windows.Forms.TextBox();
            this.dtpIncome = new System.Windows.Forms.DateTimePicker();
            this.txtDescIncome = new System.Windows.Forms.TextBox();
            this.txtAmountIncome = new System.Windows.Forms.TextBox();
            this.txtNameIncome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::iguMonii.Properties.Resources.Captura_de_pantalla_2025_05_31_130843;
            this.panel1.Controls.Add(this.dgvIncome);
            this.panel1.Controls.Add(this.btnEditIncome);
            this.panel1.Controls.Add(this.btnAddIncome);
            this.panel1.Controls.Add(this.lblTitleA);
            this.panel1.Controls.Add(this.lblTitleD);
            this.panel1.Controls.Add(this.lblTitlteN);
            this.panel1.Controls.Add(this.txtDtpTitle);
            this.panel1.Controls.Add(this.dtpIncome);
            this.panel1.Controls.Add(this.txtDescIncome);
            this.panel1.Controls.Add(this.txtAmountIncome);
            this.panel1.Controls.Add(this.txtNameIncome);
            this.panel1.Location = new System.Drawing.Point(0, -19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 357);
            this.panel1.TabIndex = 12;
            // 
            // dgvIncome
            // 
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colDescription,
            this.colAmount,
            this.colDate});
            this.dgvIncome.Location = new System.Drawing.Point(27, 190);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.Size = new System.Drawing.Size(519, 143);
            this.dgvIncome.TabIndex = 9;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            // 
            // btnEditIncome
            // 
            this.btnEditIncome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditIncome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditIncome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditIncome.Location = new System.Drawing.Point(249, 147);
            this.btnEditIncome.Name = "btnEditIncome";
            this.btnEditIncome.Size = new System.Drawing.Size(87, 23);
            this.btnEditIncome.TabIndex = 11;
            this.btnEditIncome.Text = "Edit Income";
            this.btnEditIncome.UseVisualStyleBackColor = false;
            this.btnEditIncome.Click += new System.EventHandler(this.btnEditIncome_Click);
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddIncome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddIncome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddIncome.Location = new System.Drawing.Point(108, 147);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(102, 23);
            this.btnAddIncome.TabIndex = 10;
            this.btnAddIncome.Text = "+ Add Income";
            this.btnAddIncome.UseVisualStyleBackColor = false;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // lblTitleA
            // 
            this.lblTitleA.AutoSize = true;
            this.lblTitleA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitleA.Location = new System.Drawing.Point(315, 84);
            this.lblTitleA.Name = "lblTitleA";
            this.lblTitleA.Size = new System.Drawing.Size(56, 17);
            this.lblTitleA.TabIndex = 8;
            this.lblTitleA.Text = "Amount";
            // 
            // lblTitleD
            // 
            this.lblTitleD.AutoSize = true;
            this.lblTitleD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitleD.Location = new System.Drawing.Point(162, 86);
            this.lblTitleD.Name = "lblTitleD";
            this.lblTitleD.Size = new System.Drawing.Size(79, 17);
            this.lblTitleD.TabIndex = 7;
            this.lblTitleD.Text = "Description";
            // 
            // lblTitlteN
            // 
            this.lblTitlteN.AutoSize = true;
            this.lblTitlteN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitlteN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitlteN.Location = new System.Drawing.Point(55, 86);
            this.lblTitlteN.Name = "lblTitlteN";
            this.lblTitlteN.Size = new System.Drawing.Size(45, 17);
            this.lblTitlteN.TabIndex = 6;
            this.lblTitlteN.Text = "Name";
            // 
            // txtDtpTitle
            // 
            this.txtDtpTitle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDtpTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDtpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDtpTitle.Location = new System.Drawing.Point(433, 82);
            this.txtDtpTitle.Name = "txtDtpTitle";
            this.txtDtpTitle.Size = new System.Drawing.Size(68, 17);
            this.txtDtpTitle.TabIndex = 5;
            this.txtDtpTitle.Text = "Date:";
            // 
            // dtpIncome
            // 
            this.dtpIncome.Location = new System.Drawing.Point(414, 109);
            this.dtpIncome.Name = "dtpIncome";
            this.dtpIncome.Size = new System.Drawing.Size(87, 20);
            this.dtpIncome.TabIndex = 4;
            // 
            // txtDescIncome
            // 
            this.txtDescIncome.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDescIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescIncome.Location = new System.Drawing.Point(144, 106);
            this.txtDescIncome.Name = "txtDescIncome";
            this.txtDescIncome.Size = new System.Drawing.Size(136, 23);
            this.txtDescIncome.TabIndex = 3;
            // 
            // txtAmountIncome
            // 
            this.txtAmountIncome.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAmountIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAmountIncome.Location = new System.Drawing.Point(307, 104);
            this.txtAmountIncome.Name = "txtAmountIncome";
            this.txtAmountIncome.Size = new System.Drawing.Size(87, 23);
            this.txtAmountIncome.TabIndex = 2;
            // 
            // txtNameIncome
            // 
            this.txtNameIncome.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNameIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNameIncome.Location = new System.Drawing.Point(27, 104);
            this.txtNameIncome.Name = "txtNameIncome";
            this.txtNameIncome.Size = new System.Drawing.Size(101, 23);
            this.txtNameIncome.TabIndex = 1;
            // 
            // useCaseManageIncomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 334);
            this.Controls.Add(this.panel1);
            this.Name = "useCaseManageIncomes";
            this.Text = "useCaseManageIncomes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNameIncome;
        private System.Windows.Forms.TextBox txtAmountIncome;
        private System.Windows.Forms.TextBox txtDescIncome;
        private System.Windows.Forms.DateTimePicker dtpIncome;
        private System.Windows.Forms.TextBox txtDtpTitle;
        private System.Windows.Forms.Label lblTitlteN;
        private System.Windows.Forms.Label lblTitleD;
        private System.Windows.Forms.Label lblTitleA;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.Button btnEditIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.Panel panel1;
    }
}