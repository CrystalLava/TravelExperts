namespace TravelExperts
{
    partial class ManagePackageListing
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
            this.components = new System.ComponentModel.Container();
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.lblManagePackages = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPackages
            // 
            this.dgvPackages.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Location = new System.Drawing.Point(24, 68);
            this.dgvPackages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.Size = new System.Drawing.Size(645, 230);
            this.dgvPackages.TabIndex = 0;
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataMember = "Packages";
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddPackage.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPackage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddPackage.Location = new System.Drawing.Point(24, 330);
            this.btnAddPackage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(163, 41);
            this.btnAddPackage.TabIndex = 1;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = false;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditPackage.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPackage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditPackage.Location = new System.Drawing.Point(246, 330);
            this.btnEditPackage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(176, 41);
            this.btnEditPackage.TabIndex = 2;
            this.btnEditPackage.Text = "Edit  Package";
            this.btnEditPackage.UseVisualStyleBackColor = false;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDeletePackage.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePackage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeletePackage.Location = new System.Drawing.Point(488, 330);
            this.btnDeletePackage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(181, 41);
            this.btnDeletePackage.TabIndex = 2;
            this.btnDeletePackage.Text = "Delete  Package";
            this.btnDeletePackage.UseVisualStyleBackColor = false;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            // 
            // lblManagePackages
            // 
            this.lblManagePackages.AutoSize = true;
            this.lblManagePackages.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePackages.Location = new System.Drawing.Point(230, 9);
            this.lblManagePackages.Name = "lblManagePackages";
            this.lblManagePackages.Size = new System.Drawing.Size(230, 37);
            this.lblManagePackages.TabIndex = 3;
            this.lblManagePackages.Text = "Manage Packages";
            // 
            // ManagePackageListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(695, 384);
            this.Controls.Add(this.lblManagePackages);
            this.Controls.Add(this.btnDeletePackage);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.dgvPackages);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManagePackageListing";
            this.Text = "Manage Packages";
            this.Load += new System.EventHandler(this.ManagePackageListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       // private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource packagesBindingSource;
       //private TravelExpertsDataSetTableAdapters.PackagesTableAdapter packagesTableAdapter;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnEditPackage;
        public System.Windows.Forms.DataGridView dgvPackages;
        private System.Windows.Forms.Button btnDeletePackage;
        private System.Windows.Forms.Label lblManagePackages;
    }
}