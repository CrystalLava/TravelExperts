using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class ManageSupplierListing : Form
    {
        private readonly TravelExpertsEntities _db;

        public ManageSupplierListing()
        {
            InitializeComponent();
            _db = new TravelExpertsEntities();
        }

        private void ManageSupplierListing_Load(object sender, EventArgs e)
        {

        }
        //Function to PopulateGrid. Can be called anytime we need a grid refresh 

        public void PopulateGrid()
        {

            //Select Supplier as SuppName from Product Table
            var suppliers = _db.Suppliers.Select(s => new
            {
                Supplier = s.SupName,
                s.SupplierId
            })
                .ToList();

            gvSupplierList.DataSource = suppliers;
            gvSupplierList.Columns["SupplierId"].Visible = false;
        }

        private void lblAddSupplier_Click(object sender, EventArgs e)
        {
            var addEditSupplier = new AddEditSupplier(this);

            addEditSupplier.MdiParent = this.MdiParent;
            addEditSupplier.Show();
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                //select row          
                var id = Convert.ToString(gvSupplierList.CurrentRow.Cells[0].Value);

                //query database for record                
                var supplier = _db.Suppliers.FirstOrDefault(s => s.SupName == id);

                //launch AddEditSupplier window with Data
                var addEditSupplier = new AddEditSupplier(supplier, this);
                addEditSupplier.MdiParent = this.MdiParent;
                addEditSupplier.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {

            try
            {
                //select row
                var id = Convert.ToString(gvSupplierList.CurrentRow.Cells[0].Value);

                //query database for record
                var supplier = _db.Suppliers.FirstOrDefault(s => s.SupName == id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Supplier?",
                        "Delete", MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //delete Supplier from table
                    _db.Suppliers.Remove(supplier);
                    _db.SaveChanges();
                }
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            //gvSupplierList.Refresh();
        }



    private void gvSupplierList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {

        }

        

        
       
    }
}
