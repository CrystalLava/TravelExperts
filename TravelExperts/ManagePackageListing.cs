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
        private readonly TravelExpertsEntities _db;
        public ManagePackageListing()
        {
            InitializeComponent();
            _db = new TravelExpertsEntities();
        }

        private void ManagePackageListing_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            AddEditPackage frmAddpackage = new AddEditPackage(managePackageListing: this);
            frmAddpackage.ShowDialog();
        }

        private void btnEditPackage_Click(object sender, EventArgs e)
        {

            try
            {
                var packageId = (int)dgvPackages.CurrentRow.Cells[0].Value;

                var package = _db.Packages.Where(p => p.PackageId == packageId).FirstOrDefault();

                AddEditPackage frmAddpackage = new AddEditPackage(package, this);
                frmAddpackage.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void PopulateGrid()
        {
            var packages = _db.Packages.ToList();

            dgvPackages.DataSource = packages;
            dgvPackages.Columns["PackageId"].Visible = false;
            
            dgvPackages.Update();
            dgvPackages.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvPackages.DataSource = null;
            dgvPackages.Update();
            dgvPackages.Refresh();

            PopulateGrid();
        }

        private void btnDeletePackage_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You're about to delete the package, sure?","Delete Action", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var packageId = (int)dgvPackages.CurrentRow.Cells[0].Value;

                    var package = _db.Packages.Where(p => p.PackageId == packageId).FirstOrDefault();

                    _db.Packages.Remove(package);

                    _db.SaveChanges();
                    MessageBox.Show("Package Deleted!");

                   PopulateGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        } 
    }
}
