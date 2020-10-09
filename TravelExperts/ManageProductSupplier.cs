using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class ManageProductSupplier : Form
    {
        private readonly TravelExpertsEntities _db;
        public ManageProductSupplier()
        {
            InitializeComponent();
            _db = new TravelExpertsEntities();
        }

        private void ManageProductSupplier_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        //Function to PopulateGrid. Can be called anytime we need a grid refresh   
        public void PopulateGrid()
        {
            //Select ProductSupplier as ProdName from Product Table
            var productsupplier = _db.Products.Select(p => new
            {
                ProductSupplier = p.ProdName,
                p.ProductId,
                p.SupplierId
            })
                .ToList();

            gvProdSupplierList.DataSource = productsupplier;
            gvProdSupplierList.Columns["ProductId"].Visible = false;
        }

        private void btnAddProdSupplier_Click(object sender, EventArgs e)
        {
            var addEditProductSupplier = new AddEditProductSupplier(this);

            addEditProductSupplier.MdiParent = this.MdiParent;
            addEditProductSupplier.Show();
        }

        private void btnEditProdSupplier_Click(object sender, EventArgs e)
        {

            try
            {
                //select row          
                var id = Convert.ToString(gvProdSupplierList.CurrentRow.Cells[0].Value);

                //query database for record                
                var productsupplier = _db.Products.FirstOrDefault(p => p.ProdName == id);

                //launch AddEditProduct window with Data
                var addEditProductSupplier = new AddEditProductSupplier(productsupplier, this);
                addEditProductSupplier.MdiParent = this.MdiParent;
                addEditProductSupplier.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDeleteProdSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                //select row
                var id = Convert.ToString(gvProdSupplierList.CurrentRow.Cells[0].Value);

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
    }
}