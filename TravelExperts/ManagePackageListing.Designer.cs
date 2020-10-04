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
            this.dgvPakages = new System.Windows.Forms.DataGridView();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpertsDataSet = new TravelExperts.TravelExpertsDataSet();
            this.packagesTableAdapter = new TravelExperts.TravelExpertsDataSetTableAdapters.PackagesTableAdapter();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPakages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPakages
            // 
            this.dgvPakages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPakages.Location = new System.Drawing.Point(21, 12);
            this.dgvPakages.Name = "dgvPakages";
            this.dgvPakages.Size = new System.Drawing.Size(727, 188);
            this.dgvPakages.TabIndex = 0;
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataMember = "Packages";
            this.packagesBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // travelExpertsDataSet
            // 
            this.travelExpertsDataSet.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packagesTableAdapter
            // 
            this.packagesTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(88, 281);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(125, 23);
            this.btnAddPackage.TabIndex = 1;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.Location = new System.Drawing.Point(266, 281);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(155, 23);
            this.btnEditPackage.TabIndex = 2;
            this.btnEditPackage.Text = "Edit Selected Package";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.Location = new System.Drawing.Point(442, 281);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(155, 23);
            this.btnDeletePackage.TabIndex = 2;
            this.btnDeletePackage.Text = "Delete Selected Package";
            this.btnDeletePackage.UseVisualStyleBackColor = true;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            // 
            // ManagePackageListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletePackage);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.dgvPakages);
            this.Name = "ManagePackageListing";
            this.Text = "ManagePackageListing";
            this.Load += new System.EventHandler(this.ManagePackageListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPakages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private TravelExpertsDataSetTableAdapters.PackagesTableAdapter packagesTableAdapter;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnEditPackage;
        public System.Windows.Forms.DataGridView dgvPakages;
        private System.Windows.Forms.Button btnDeletePackage;
    }
}