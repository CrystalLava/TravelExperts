using System;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class AddEditProductSupplier : Form
    {
        private readonly TravelExpertsEntities _db;
        private readonly ManageProductSupplier _manageProductSupplier;
        private readonly bool isEditMode;

        public AddEditProductSupplier(ManageProductSupplier manageProductSupplier = null)
        {
            InitializeComponent();
            lblTitle.Text = "Add New ProductSupplier";
            this.Text = "Add New ProductSupplier";
            isEditMode = false;
            _manageProductSupplier = manageProductSupplier;
            _db = new TravelExpertsEntities();
        }
        public AddEditProductSupplier(ProductSupplier productSupplierToEdit, ManageProductSupplier manageProductSupplier = null)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Products";
            this.Text = "Edit Products";
            _manageProductSupplier = manageProductSupplier;

            if (productSupplierToEdit == null)
            {
                MessageBox.Show("Please ensure you selected a valid Product Supplier to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new TravelExpertsEntities();
                PopulateFields(productSupplierToEdit);
            }

        }

        private void PopulateFields(ProductSupplier productSupplierToEdit)
        {
            lblProdSupplierId.Text = productSupplierToEdit.ProductSupplierId.ToString();
            txtProductSupplier.Text = productSupplierToEdit.ProdName;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
