
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
    public partial class ManageProductListing : Form        
    {
        
        private readonly TravelExpertsEntities _db;
        public ManageProductListing()
        {
            InitializeComponent();
            _db = new TravelExpertsEntities();
        }

        private void ManageProductListing_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        //Function to PopulateGrid. Can be called anytime we need a grid refresh   
        public void PopulateGrid()
        { 

            //Select Product as ProdName from Product Table
            var products = _db.Products.Select(p => new 
                {
                    Product = p.ProdName, 
                    p.ProductId
                })
                .ToList();

            gvProductList.DataSource = products;
            gvProductList.Columns["ProductId"].Visible = false;           
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
             var addEditProduct = new AddEditProduct(this);
                
            addEditProduct.MdiParent = this.MdiParent;
            addEditProduct.Show();

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {

            try
            {
                //select row          
                var id = Convert.ToString(gvProductList.CurrentRow.Cells[0].Value);

                //query database for record                
                var product = _db.Products.FirstOrDefault(p => p.ProdName== id);

                //launch AddEditProduct window with Data
                var addEditProduct = new AddEditProduct(product, this);
                addEditProduct.MdiParent = this.MdiParent;
                addEditProduct.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                //select row
                var id = Convert.ToString(gvProductList.CurrentRow.Cells[0].Value);

                //query database for record
                var product = _db.Products.FirstOrDefault(p => p.ProdName == id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Product?",
                        "Delete", MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //delete Product from table
                    _db.Products.Remove(product);
                    _db.SaveChanges();
                }
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            //gvProductList.Refresh();
        }

        private void lblAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void gvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
