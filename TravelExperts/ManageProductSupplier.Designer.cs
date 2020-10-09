namespace TravelExperts
{
    partial class ManageProductSupplier
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
            this.lblAddProductSupplier = new System.Windows.Forms.Label();
            this.gvProdSupplierList = new System.Windows.Forms.DataGridView();
            this.btnAddProdSupplier = new System.Windows.Forms.Button();
            this.btnEditProdSupplier = new System.Windows.Forms.Button();
            this.btnDeleteProdSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdSupplierList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddProductSupplier
            // 
            this.lblAddProductSupplier.AutoSize = true;
            this.lblAddProductSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProductSupplier.Location = new System.Drawing.Point(12, 28);
            this.lblAddProductSupplier.Name = "lblAddProductSupplier";
            this.lblAddProductSupplier.Size = new System.Drawing.Size(254, 25);
            this.lblAddProductSupplier.TabIndex = 0;
            this.lblAddProductSupplier.Text = "Mange Product Suppliers";
            // 
            // gvProdSupplierList
            // 
            this.gvProdSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProdSupplierList.Location = new System.Drawing.Point(17, 76);
            this.gvProdSupplierList.Name = "gvProdSupplierList";
            this.gvProdSupplierList.Size = new System.Drawing.Size(223, 338);
            this.gvProdSupplierList.TabIndex = 1;
            // 
            // btnAddProdSupplier
            // 
            this.btnAddProdSupplier.Location = new System.Drawing.Point(306, 76);
            this.btnAddProdSupplier.Name = "btnAddProdSupplier";
            this.btnAddProdSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnAddProdSupplier.TabIndex = 2;
            this.btnAddProdSupplier.Text = "Add";
            this.btnAddProdSupplier.UseVisualStyleBackColor = true;
            this.btnAddProdSupplier.Click += new System.EventHandler(this.btnAddProdSupplier_Click);
            // 
            // btnEditProdSupplier
            // 
            this.btnEditProdSupplier.Location = new System.Drawing.Point(306, 233);
            this.btnEditProdSupplier.Name = "btnEditProdSupplier";
            this.btnEditProdSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnEditProdSupplier.TabIndex = 3;
            this.btnEditProdSupplier.Text = "Edit";
            this.btnEditProdSupplier.UseVisualStyleBackColor = true;
            this.btnEditProdSupplier.Click += new System.EventHandler(this.btnEditProdSupplier_Click);
            // 
            // btnDeleteProdSupplier
            // 
            this.btnDeleteProdSupplier.Location = new System.Drawing.Point(306, 390);
            this.btnDeleteProdSupplier.Name = "btnDeleteProdSupplier";
            this.btnDeleteProdSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProdSupplier.TabIndex = 4;
            this.btnDeleteProdSupplier.Text = "Delete";
            this.btnDeleteProdSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteProdSupplier.Click += new System.EventHandler(this.btnDeleteProdSupplier_Click);
            // 
            // ManageProductSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btnDeleteProdSupplier);
            this.Controls.Add(this.btnEditProdSupplier);
            this.Controls.Add(this.btnAddProdSupplier);
            this.Controls.Add(this.gvProdSupplierList);
            this.Controls.Add(this.lblAddProductSupplier);
            this.Name = "ManageProductSupplier";
            this.Text = "Manage Product Supplier";
            this.Load += new System.EventHandler(this.ManageProductSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProdSupplierList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddProductSupplier;
        private System.Windows.Forms.DataGridView gvProdSupplierList;
        private System.Windows.Forms.Button btnAddProdSupplier;
        private System.Windows.Forms.Button btnEditProdSupplier;
        private System.Windows.Forms.Button btnDeleteProdSupplier;
    }
}