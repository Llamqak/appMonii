namespace iguMonii
{
    partial class useCaseManageCategories
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
            this.lblNameCategories = new System.Windows.Forms.Label();
            this.lblDescriptionCategories = new System.Windows.Forms.Label();
            this.txtNameCategories = new System.Windows.Forms.TextBox();
            this.txtDescriptionCategories = new System.Windows.Forms.TextBox();
            this.btnAddCategories = new System.Windows.Forms.Button();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.btnUpdateCategories = new System.Windows.Forms.Button();
            this.btnDeleteCategories = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameCategories
            // 
            this.lblNameCategories.AutoSize = true;
            this.lblNameCategories.Location = new System.Drawing.Point(33, 35);
            this.lblNameCategories.Name = "lblNameCategories";
            this.lblNameCategories.Size = new System.Drawing.Size(35, 13);
            this.lblNameCategories.TabIndex = 0;
            this.lblNameCategories.Text = "Name";
            // 
            // lblDescriptionCategories
            // 
            this.lblDescriptionCategories.AutoSize = true;
            this.lblDescriptionCategories.Location = new System.Drawing.Point(248, 35);
            this.lblDescriptionCategories.Name = "lblDescriptionCategories";
            this.lblDescriptionCategories.Size = new System.Drawing.Size(60, 13);
            this.lblDescriptionCategories.TabIndex = 1;
            this.lblDescriptionCategories.Text = "Description";
            // 
            // txtNameCategories
            // 
            this.txtNameCategories.Location = new System.Drawing.Point(95, 32);
            this.txtNameCategories.Name = "txtNameCategories";
            this.txtNameCategories.Size = new System.Drawing.Size(140, 20);
            this.txtNameCategories.TabIndex = 2;
            // 
            // txtDescriptionCategories
            // 
            this.txtDescriptionCategories.Location = new System.Drawing.Point(311, 32);
            this.txtDescriptionCategories.Name = "txtDescriptionCategories";
            this.txtDescriptionCategories.Size = new System.Drawing.Size(162, 20);
            this.txtDescriptionCategories.TabIndex = 3;
            // 
            // btnAddCategories
            // 
            this.btnAddCategories.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddCategories.Location = new System.Drawing.Point(479, 30);
            this.btnAddCategories.Name = "btnAddCategories";
            this.btnAddCategories.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategories.TabIndex = 4;
            this.btnAddCategories.Text = "Add";
            this.btnAddCategories.UseVisualStyleBackColor = false;
            this.btnAddCategories.Click += new System.EventHandler(this.btnAddCategories_Click);
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(36, 79);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(518, 206);
            this.dgvCategories.TabIndex = 5;
            // 
            // btnUpdateCategories
            // 
            this.btnUpdateCategories.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdateCategories.Location = new System.Drawing.Point(127, 306);
            this.btnUpdateCategories.Name = "btnUpdateCategories";
            this.btnUpdateCategories.Size = new System.Drawing.Size(150, 23);
            this.btnUpdateCategories.TabIndex = 6;
            this.btnUpdateCategories.Text = "Update";
            this.btnUpdateCategories.UseVisualStyleBackColor = false;
            this.btnUpdateCategories.Click += new System.EventHandler(this.btnUpdateCategories_Click);
            // 
            // btnDeleteCategories
            // 
            this.btnDeleteCategories.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteCategories.Location = new System.Drawing.Point(298, 306);
            this.btnDeleteCategories.Name = "btnDeleteCategories";
            this.btnDeleteCategories.Size = new System.Drawing.Size(150, 23);
            this.btnDeleteCategories.TabIndex = 7;
            this.btnDeleteCategories.Text = "Delete";
            this.btnDeleteCategories.UseVisualStyleBackColor = false;
            this.btnDeleteCategories.Click += new System.EventHandler(this.btnDeleteCategories_Click);
            // 
            // useCaseManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 365);
            this.Controls.Add(this.btnDeleteCategories);
            this.Controls.Add(this.btnUpdateCategories);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.btnAddCategories);
            this.Controls.Add(this.txtDescriptionCategories);
            this.Controls.Add(this.txtNameCategories);
            this.Controls.Add(this.lblDescriptionCategories);
            this.Controls.Add(this.lblNameCategories);
            this.Name = "useCaseManageCategories";
            this.Text = "useCaseManageCategories";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameCategories;
        private System.Windows.Forms.Label lblDescriptionCategories;
        private System.Windows.Forms.TextBox txtNameCategories;
        private System.Windows.Forms.TextBox txtDescriptionCategories;
        private System.Windows.Forms.Button btnAddCategories;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Button btnUpdateCategories;
        private System.Windows.Forms.Button btnDeleteCategories;
    }
}