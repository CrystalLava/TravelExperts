namespace TravelExperts
{
    partial class ManageSupplierListing
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
            this.gvSupplierList = new System.Windows.Forms.DataGridView();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.lblAddSupplier = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplierList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSupplierList
            // 
            this.gvSupplierList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gvSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSupplierList.Location = new System.Drawing.Point(27, 89);
            this.gvSupplierList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvSupplierList.Name = "gvSupplierList";
            this.gvSupplierList.Size = new System.Drawing.Size(169, 251);
            this.gvSupplierList.TabIndex = 1;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddSupplier.Location = new System.Drawing.Point(228, 90);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(87, 30);
            this.btnAddSupplier.TabIndex = 3;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditSupplier.Location = new System.Drawing.Point(228, 197);
            this.btnEditSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(87, 30);
            this.btnEditSupplier.TabIndex = 4;
            this.btnEditSupplier.Text = "Edit ";
            this.btnEditSupplier.UseVisualStyleBackColor = false;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDeleteSupplier.Location = new System.Drawing.Point(227, 311);
            this.btnDeleteSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(87, 30);
            this.btnDeleteSupplier.TabIndex = 5;
            this.btnDeleteSupplier.Text = "Delete ";
            this.btnDeleteSupplier.UseVisualStyleBackColor = false;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // lblAddSupplier
            // 
            this.lblAddSupplier.AutoSize = true;
            this.lblAddSupplier.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSupplier.Location = new System.Drawing.Point(61, 30);
            this.lblAddSupplier.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddSupplier.Name = "lblAddSupplier";
            this.lblAddSupplier.Size = new System.Drawing.Size(207, 32);
            this.lblAddSupplier.TabIndex = 6;
            this.lblAddSupplier.Text = "Manage Suppliers";
            // 
            // ManageSupplierListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(353, 366);
            this.Controls.Add(this.lblAddSupplier);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.gvSupplierList);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageSupplierListing";
            this.Text = "Manage Suppliers";
            this.Load += new System.EventHandler(this.ManageSupplierListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplierList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSupplierList;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Label lblAddSupplier;
    }
}