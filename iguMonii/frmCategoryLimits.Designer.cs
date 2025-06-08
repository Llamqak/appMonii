namespace iguMonii
{
    partial class frmCategoryLimits
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
            this.dgvLimitsCategoryLimits = new System.Windows.Forms.DataGridView();
            this.btnSaveCategoryLimits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLimitsCategoryLimits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLimitsCategoryLimits
            // 
            this.dgvLimitsCategoryLimits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLimitsCategoryLimits.Location = new System.Drawing.Point(38, 27);
            this.dgvLimitsCategoryLimits.Name = "dgvLimitsCategoryLimits";
            this.dgvLimitsCategoryLimits.Size = new System.Drawing.Size(260, 150);
            this.dgvLimitsCategoryLimits.TabIndex = 0;
            // 
            // btnSaveCategoryLimits
            // 
            this.btnSaveCategoryLimits.Location = new System.Drawing.Point(88, 198);
            this.btnSaveCategoryLimits.Name = "btnSaveCategoryLimits";
            this.btnSaveCategoryLimits.Size = new System.Drawing.Size(173, 23);
            this.btnSaveCategoryLimits.TabIndex = 1;
            this.btnSaveCategoryLimits.Text = "Save";
            this.btnSaveCategoryLimits.UseVisualStyleBackColor = true;
            this.btnSaveCategoryLimits.Click += new System.EventHandler(this.btnSaveCategoryLimits_Click);
            // 
            // frmCategoryLimits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 268);
            this.Controls.Add(this.btnSaveCategoryLimits);
            this.Controls.Add(this.dgvLimitsCategoryLimits);
            this.Name = "frmCategoryLimits";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLimitsCategoryLimits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLimitsCategoryLimits;
        private System.Windows.Forms.Button btnSaveCategoryLimits;
    }
}