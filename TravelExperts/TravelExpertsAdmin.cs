﻿using System;
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
    {
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
    }
}
