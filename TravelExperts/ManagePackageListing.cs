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
    public partial class ManagePackageListing : Form
    {
        public ManagePackageListing()
        {
            InitializeComponent();
        }

        private void ManagePackageListing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages' table. You can move, or remove it, as needed.
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);

        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            AddEditPackage frmAddpackage = new AddEditPackage();
            frmAddpackage.ShowDialog();
            

        }
    }
}
