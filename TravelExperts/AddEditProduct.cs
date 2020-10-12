using System;
using System.Linq;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class AddEditProduct : Form
    {
        private readonly TravelExpertsEntities _db;
        private readonly ManageProductListing _manageProductListing;
        private readonly bool isEditMode;
     
        //Using same window form for Add Edit. Titles will be different depending on if it was add or edit
        public AddEditProduct(ManageProductListing manageProductListing = null)
        {
            InitializeComponent();            
            lblTitle.Text = "Add New Product";
            this.Text = "Add New Product";            
            isEditMode = false;
            _manageProductListing = manageProductListing;
            _db = new TravelExpertsEntities();
        }
        public AddEditProduct(Product productToEdit, ManageProductListing manageProductListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Products";
            this.Text = "Edit Products";
            _manageProductListing = manageProductListing;

            //Validation
            if (productToEdit == null)
            {
                MessageBox.Show("Please ensure you selected a valid Product to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new TravelExpertsEntities();
                PopulateFields(productToEdit);
            }

        }

        private void PopulateFields(Product productToEdit)
        {
            lblProductId.Text = productToEdit.ProductId.ToString();
            txtProduct.Text = productToEdit.ProdName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string product = txtProduct.Text;

                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(product))
                {
                    isValid = false;
                    errorMessage += "Error: Please Enter a Product Name";
                }

                if (isValid)
                {
                    //Declare an object of the product to be added
                    var productlisting = new Product();

                    if (isEditMode)
                    {
                        //If in edit mode, then get the ID and retrieve the record from the database and place
                        //the result in the record object
                        var id = int.Parse(lblProductId.Text);
                        productlisting = _db.Products.FirstOrDefault(p => p.ProductId == id);

                    }
                    //Populate record object with values from the form 
                    productlisting.ProdName = product;

                    //If not in edit mode, then add the record object to the database
                    if (!isEditMode)
                        _db.Products.Add(productlisting);

                    //Save Changes made to the entity
                    _db.SaveChanges();
                    _manageProductListing.PopulateGrid();

                    MessageBox.Show($"Product Name: {product} has been updated");

                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Cancel button closes this window
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
