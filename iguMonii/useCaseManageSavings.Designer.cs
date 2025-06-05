namespace iguMonii
{
    partial class useCaseManageSavings
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFrecuency = new System.Windows.Forms.Label();
            this.txtSavingName = new System.Windows.Forms.TextBox();
            this.txtSavingCap = new System.Windows.Forms.TextBox();
            this.txtSavingPeriodicFee = new System.Windows.Forms.TextBox();
            this.txtSavingFrecuency = new System.Windows.Forms.TextBox();
            this.dgvSaving = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriodicFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecuency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSaving = new System.Windows.Forms.Button();
            this.tnEditSaving = new System.Windows.Forms.Button();
            this.dtpSavingTimeLimit = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaving)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::iguMonii.Properties.Resources.Captura_de_pantalla_2025_05_31_150738;
            this.panel1.Controls.Add(this.dtpSavingTimeLimit);
            this.panel1.Controls.Add(this.tnEditSaving);
            this.panel1.Controls.Add(this.btnAddSaving);
            this.panel1.Controls.Add(this.dgvSaving);
            this.panel1.Controls.Add(this.txtSavingFrecuency);
            this.panel1.Controls.Add(this.txtSavingPeriodicFee);
            this.panel1.Controls.Add(this.txtSavingCap);
            this.panel1.Controls.Add(this.txtSavingName);
            this.panel1.Controls.Add(this.lblFrecuency);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCap);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 342);
            this.panel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblName.Location = new System.Drawing.Point(58, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCap.Location = new System.Drawing.Point(159, 69);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(28, 13);
            this.lblCap.TabIndex = 1;
            this.lblCap.Text = "CAP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(231, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Periodic Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(333, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time Limit ";
            // 
            // lblFrecuency
            // 
            this.lblFrecuency.AutoSize = true;
            this.lblFrecuency.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFrecuency.Location = new System.Drawing.Point(444, 69);
            this.lblFrecuency.Name = "lblFrecuency";
            this.lblFrecuency.Size = new System.Drawing.Size(57, 13);
            this.lblFrecuency.TabIndex = 4;
            this.lblFrecuency.Text = "Frecuency";
            // 
            // txtSavingName
            // 
            this.txtSavingName.Location = new System.Drawing.Point(25, 85);
            this.txtSavingName.Name = "txtSavingName";
            this.txtSavingName.Size = new System.Drawing.Size(100, 20);
            this.txtSavingName.TabIndex = 5;
            // 
            // txtSavingCap
            // 
            this.txtSavingCap.Location = new System.Drawing.Point(131, 85);
            this.txtSavingCap.Name = "txtSavingCap";
            this.txtSavingCap.Size = new System.Drawing.Size(85, 20);
            this.txtSavingCap.TabIndex = 6;
            // 
            // txtSavingPeriodicFee
            // 
            this.txtSavingPeriodicFee.Location = new System.Drawing.Point(222, 85);
            this.txtSavingPeriodicFee.Name = "txtSavingPeriodicFee";
            this.txtSavingPeriodicFee.Size = new System.Drawing.Size(87, 20);
            this.txtSavingPeriodicFee.TabIndex = 7;
            // 
            // txtSavingFrecuency
            // 
            this.txtSavingFrecuency.Location = new System.Drawing.Point(428, 85);
            this.txtSavingFrecuency.Name = "txtSavingFrecuency";
            this.txtSavingFrecuency.Size = new System.Drawing.Size(100, 20);
            this.txtSavingFrecuency.TabIndex = 9;
            // 
            // dgvSaving
            // 
            this.dgvSaving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaving.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colCap,
            this.colPeriodicFee,
            this.colTimeLimit,
            this.colFrecuency});
            this.dgvSaving.Location = new System.Drawing.Point(11, 170);
            this.dgvSaving.Name = "dgvSaving";
            this.dgvSaving.Size = new System.Drawing.Size(538, 150);
            this.dgvSaving.TabIndex = 10;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colCap
            // 
            this.colCap.HeaderText = "CAP";
            this.colCap.Name = "colCap";
            // 
            // colPeriodicFee
            // 
            this.colPeriodicFee.HeaderText = "Periodic Fee";
            this.colPeriodicFee.Name = "colPeriodicFee";
            // 
            // colTimeLimit
            // 
            this.colTimeLimit.HeaderText = "Time Limit";
            this.colTimeLimit.Name = "colTimeLimit";
            // 
            // colFrecuency
            // 
            this.colFrecuency.HeaderText = "Frecuency";
            this.colFrecuency.Name = "colFrecuency";
            // 
            // btnAddSaving
            // 
            this.btnAddSaving.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddSaving.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSaving.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddSaving.Location = new System.Drawing.Point(83, 124);
            this.btnAddSaving.Name = "btnAddSaving";
            this.btnAddSaving.Size = new System.Drawing.Size(104, 23);
            this.btnAddSaving.TabIndex = 11;
            this.btnAddSaving.Text = "+ Add Saving";
            this.btnAddSaving.UseVisualStyleBackColor = false;
            this.btnAddSaving.Click += new System.EventHandler(this.btnAddSaving_Click);
            // 
            // tnEditSaving
            // 
            this.tnEditSaving.BackColor = System.Drawing.SystemColors.Highlight;
            this.tnEditSaving.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tnEditSaving.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tnEditSaving.Location = new System.Drawing.Point(234, 124);
            this.tnEditSaving.Name = "tnEditSaving";
            this.tnEditSaving.Size = new System.Drawing.Size(104, 23);
            this.tnEditSaving.TabIndex = 12;
            this.tnEditSaving.Text = "Edit Saving";
            this.tnEditSaving.UseVisualStyleBackColor = false;
            this.tnEditSaving.Click += new System.EventHandler(this.tnEditSaving_Click);
            // 
            // dtpSavingTimeLimit
            // 
            this.dtpSavingTimeLimit.Location = new System.Drawing.Point(327, 85);
            this.dtpSavingTimeLimit.Name = "dtpSavingTimeLimit";
            this.dtpSavingTimeLimit.Size = new System.Drawing.Size(81, 20);
            this.dtpSavingTimeLimit.TabIndex = 13;
            // 
            // useCaseManageSavings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 342);
            this.Controls.Add(this.panel1);
            this.Name = "useCaseManageSavings";
            this.Text = "useCaseManageSavings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaving)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvSaving;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodicFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecuency;
        private System.Windows.Forms.TextBox txtSavingFrecuency;
        private System.Windows.Forms.TextBox txtSavingPeriodicFee;
        private System.Windows.Forms.TextBox txtSavingCap;
        private System.Windows.Forms.TextBox txtSavingName;
        private System.Windows.Forms.Label lblFrecuency;
        private System.Windows.Forms.Button tnEditSaving;
        private System.Windows.Forms.Button btnAddSaving;
        private System.Windows.Forms.DateTimePicker dtpSavingTimeLimit;
    }
}