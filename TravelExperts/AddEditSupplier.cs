using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class AddEditSupplier : Form
    {
        private readonly TravelExpertsEntities _db;
        private readonly ManageSupplierListing _manageSupplierListing;
        private readonly bool isEditMode;

        public AddEditSupplier(ManageSupplierListing manageSupplierListing = null)
        {
            InitializeComponent();
            lblSupTitle.Text = "Add New Supplier";
            this.Text = "Add New Supplier";
            isEditMode = false;
            _manageSupplierListing = manageSupplierListing;
            _db = new TravelExpertsEntities();
        }
        public AddEditSupplier(Supplier supplierToEdit, ManageSupplierListing manageSupplierListing = null)
        {
            InitializeComponent();
            lblSupTitle.Text = "Edit Suppliers";
            this.Text = "Edit Suppliers";
            _manageSupplierListing = manageSupplierListing;

            if (supplierToEdit == null)
            {
                MessageBox.Show("Please ensure you selected a valid Supplier to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new TravelExpertsEntities();
                PopulateFields(supplierToEdit);
            }

        }

        private void PopulateFields(Supplier supplierToEdit)
        {
            lblSupplierId.Text = supplierToEdit.SupplierId.ToString();
            txtSupplier.Text = supplierToEdit.SupName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string supplier = txtSupplier.Text;

                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(supplier))
                {
                    isValid = false;
                    errorMessage += "Error: Please Enter a Supplier Name";
                }

                if (isValid)
                {
                    //Declare an object of the supplier to be added
                    var supplierlisting = new Supplier();

                    if (isEditMode)
                    {
                        //If in edit mode, then get the ID and retrieve the record from the database and place
                        //the result in the record object
                        var id = int.Parse(lblSupplierId.Text);
                        supplierlisting = _db.Suppliers.FirstOrDefault(s => s.SupplierId == id);

                    }
                    //Populate record object with values from the form 
                    supplierlisting.SupName = supplier;

                    //If not in edit mode, then add the record object to the database
                    if (!isEditMode)
                        _db.Suppliers.Add(supplierlisting);

                    //Save Changes made to the entity
                    _db.SaveChanges();
                    _manageSupplierListing.PopulateGrid();

                    MessageBox.Show($"Supplier Name :{supplier} has been added");

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
