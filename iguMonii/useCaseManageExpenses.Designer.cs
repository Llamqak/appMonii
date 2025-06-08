namespace iguMonii
{
    partial class useCaseManageExpenses
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
            this.panelExpenses = new System.Windows.Forms.Panel();
            this.btnEditLimitsExpenses = new System.Windows.Forms.Button();
            this.lblDateExpenses = new System.Windows.Forms.TextBox();
            this.dtpDateExpenses = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescriptionExpenses = new System.Windows.Forms.TextBox();
            this.txtCategorySummaryExpenses = new System.Windows.Forms.TextBox();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.lblCategoryExpenses = new System.Windows.Forms.Label();
            this.cmbCategoryExpenses = new System.Windows.Forms.ComboBox();
            this.btnLogExpenses = new System.Windows.Forms.Button();
            this.lblAmountExpenses = new System.Windows.Forms.Label();
            this.lblNameExpenses = new System.Windows.Forms.Label();
            this.txtNameExpenses = new System.Windows.Forms.TextBox();
            this.txtAmountExpenses = new System.Windows.Forms.TextBox();
            this.panelExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // panelExpenses
            // 
            this.panelExpenses.BackgroundImage = global::iguMonii.Properties.Resources.Captura_de_pantalla_2025_05_31_135721;
            this.panelExpenses.Controls.Add(this.btnEditLimitsExpenses);
            this.panelExpenses.Controls.Add(this.lblDateExpenses);
            this.panelExpenses.Controls.Add(this.dtpDateExpenses);
            this.panelExpenses.Controls.Add(this.label1);
            this.panelExpenses.Controls.Add(this.txtDescriptionExpenses);
            this.panelExpenses.Controls.Add(this.txtCategorySummaryExpenses);
            this.panelExpenses.Controls.Add(this.dgvExpenses);
            this.panelExpenses.Controls.Add(this.lblCategoryExpenses);
            this.panelExpenses.Controls.Add(this.cmbCategoryExpenses);
            this.panelExpenses.Controls.Add(this.btnLogExpenses);
            this.panelExpenses.Controls.Add(this.lblAmountExpenses);
            this.panelExpenses.Controls.Add(this.lblNameExpenses);
            this.panelExpenses.Controls.Add(this.txtNameExpenses);
            this.panelExpenses.Controls.Add(this.txtAmountExpenses);
            this.panelExpenses.Location = new System.Drawing.Point(-16, -8);
            this.panelExpenses.Name = "panelExpenses";
            this.panelExpenses.Size = new System.Drawing.Size(593, 365);
            this.panelExpenses.TabIndex = 0;
            // 
            // btnEditLimitsExpenses
            // 
            this.btnEditLimitsExpenses.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditLimitsExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditLimitsExpenses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditLimitsExpenses.Location = new System.Drawing.Point(387, 122);
            this.btnEditLimitsExpenses.Name = "btnEditLimitsExpenses";
            this.btnEditLimitsExpenses.Size = new System.Drawing.Size(144, 23);
            this.btnEditLimitsExpenses.TabIndex = 38;
            this.btnEditLimitsExpenses.Text = "Edit Limits";
            this.btnEditLimitsExpenses.UseVisualStyleBackColor = false;
            this.btnEditLimitsExpenses.Click += new System.EventHandler(this.btnEditLimitsExpenses_Click);
            // 
            // lblDateExpenses
            // 
            this.lblDateExpenses.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblDateExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDateExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDateExpenses.Location = new System.Drawing.Point(42, 123);
            this.lblDateExpenses.Name = "lblDateExpenses";
            this.lblDateExpenses.Size = new System.Drawing.Size(68, 17);
            this.lblDateExpenses.TabIndex = 37;
            this.lblDateExpenses.Text = "Date:";
            // 
            // dtpDateExpenses
            // 
            this.dtpDateExpenses.Location = new System.Drawing.Point(116, 123);
            this.dtpDateExpenses.Name = "dtpDateExpenses";
            this.dtpDateExpenses.Size = new System.Drawing.Size(101, 20);
            this.dtpDateExpenses.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(288, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Description";
            // 
            // txtDescriptionExpenses
            // 
            this.txtDescriptionExpenses.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDescriptionExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescriptionExpenses.Location = new System.Drawing.Point(282, 83);
            this.txtDescriptionExpenses.Name = "txtDescriptionExpenses";
            this.txtDescriptionExpenses.Size = new System.Drawing.Size(108, 23);
            this.txtDescriptionExpenses.TabIndex = 34;
            // 
            // txtCategorySummaryExpenses
            // 
            this.txtCategorySummaryExpenses.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCategorySummaryExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCategorySummaryExpenses.Location = new System.Drawing.Point(41, 295);
            this.txtCategorySummaryExpenses.Name = "txtCategorySummaryExpenses";
            this.txtCategorySummaryExpenses.Size = new System.Drawing.Size(505, 23);
            this.txtCategorySummaryExpenses.TabIndex = 32;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Location = new System.Drawing.Point(41, 164);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.Size = new System.Drawing.Size(505, 125);
            this.dgvExpenses.TabIndex = 28;
            // 
            // lblCategoryExpenses
            // 
            this.lblCategoryExpenses.AutoSize = true;
            this.lblCategoryExpenses.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategoryExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCategoryExpenses.Location = new System.Drawing.Point(51, 64);
            this.lblCategoryExpenses.Name = "lblCategoryExpenses";
            this.lblCategoryExpenses.Size = new System.Drawing.Size(65, 17);
            this.lblCategoryExpenses.TabIndex = 24;
            this.lblCategoryExpenses.Text = "Category";
            // 
            // cmbCategoryExpenses
            // 
            this.cmbCategoryExpenses.FormattingEnabled = true;
            this.cmbCategoryExpenses.Location = new System.Drawing.Point(41, 85);
            this.cmbCategoryExpenses.Name = "cmbCategoryExpenses";
            this.cmbCategoryExpenses.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoryExpenses.TabIndex = 23;
            // 
            // btnLogExpenses
            // 
            this.btnLogExpenses.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogExpenses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogExpenses.Location = new System.Drawing.Point(237, 122);
            this.btnLogExpenses.Name = "btnLogExpenses";
            this.btnLogExpenses.Size = new System.Drawing.Size(144, 23);
            this.btnLogExpenses.TabIndex = 21;
            this.btnLogExpenses.Text = "Submit";
            this.btnLogExpenses.UseVisualStyleBackColor = false;
            this.btnLogExpenses.Click += new System.EventHandler(this.btnLogExpenses_Click);
            // 
            // lblAmountExpenses
            // 
            this.lblAmountExpenses.AutoSize = true;
            this.lblAmountExpenses.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAmountExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAmountExpenses.Location = new System.Drawing.Point(413, 63);
            this.lblAmountExpenses.Name = "lblAmountExpenses";
            this.lblAmountExpenses.Size = new System.Drawing.Size(56, 17);
            this.lblAmountExpenses.TabIndex = 19;
            this.lblAmountExpenses.Text = "Amount";
            // 
            // lblNameExpenses
            // 
            this.lblNameExpenses.AutoSize = true;
            this.lblNameExpenses.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNameExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNameExpenses.Location = new System.Drawing.Point(174, 63);
            this.lblNameExpenses.Name = "lblNameExpenses";
            this.lblNameExpenses.Size = new System.Drawing.Size(45, 17);
            this.lblNameExpenses.TabIndex = 18;
            this.lblNameExpenses.Text = "Name";
            // 
            // txtNameExpenses
            // 
            this.txtNameExpenses.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNameExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNameExpenses.Location = new System.Drawing.Point(168, 83);
            this.txtNameExpenses.Name = "txtNameExpenses";
            this.txtNameExpenses.Size = new System.Drawing.Size(108, 23);
            this.txtNameExpenses.TabIndex = 14;
            // 
            // txtAmountExpenses
            // 
            this.txtAmountExpenses.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAmountExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAmountExpenses.Location = new System.Drawing.Point(405, 83);
            this.txtAmountExpenses.Name = "txtAmountExpenses";
            this.txtAmountExpenses.Size = new System.Drawing.Size(87, 23);
            this.txtAmountExpenses.TabIndex = 13;
            // 
            // useCaseManageExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 322);
            this.Controls.Add(this.panelExpenses);
            this.Name = "useCaseManageExpenses";
            this.Text = "useCaseManageExpenses";
            this.panelExpenses.ResumeLayout(false);
            this.panelExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelExpenses;
        private System.Windows.Forms.Label lblAmountExpenses;
        private System.Windows.Forms.Label lblNameExpenses;
        private System.Windows.Forms.TextBox txtNameExpenses;
        private System.Windows.Forms.TextBox txtAmountExpenses;
        private System.Windows.Forms.Label lblCategoryExpenses;
        private System.Windows.Forms.ComboBox cmbCategoryExpenses;
        private System.Windows.Forms.Button btnLogExpenses;
        private System.Windows.Forms.TextBox txtCategorySummaryExpenses;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescriptionExpenses;
        private System.Windows.Forms.TextBox lblDateExpenses;
        private System.Windows.Forms.DateTimePicker dtpDateExpenses;
        private System.Windows.Forms.Button btnEditLimitsExpenses;
    }
}