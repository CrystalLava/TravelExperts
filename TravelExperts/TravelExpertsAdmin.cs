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
    public partial class TravelExpertsAdmin : Form
    {/// <summary>
    /// I have made this change
    /// </summary>
        public TravelExpertsAdmin()
        {
            InitializeComponent();
        }

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addProduct = new AddEditProduct
            {
                MdiParent = this
            };
            addProduct.Show();
        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productlist = new ManageProductListing
            {
                MdiParent = this
            };
            productlist.Show();
        }

        private void addSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addSupplier = new AddEditSupplier
            {
                MdiParent = this
            };
            addSupplier.Show();
        }

        private void manageSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var supplierlist = new ManageSupplierListing
            {
                MdiParent = this
            };
            supplierlist.Show();
        }
        private void TravelExpertsAdmin_Load(object sender, EventArgs e)
        {

        }

        private void managePackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmManagePackageListing=new ManagePackageListing
            {
                MdiParent= this
            };
            frmManagePackageListing.Show();
        }

        private void addPackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addPackage = new AddEditPackage
            {
                MdiParent = this
            };
            addPackage.Show();
        }
    }
}
