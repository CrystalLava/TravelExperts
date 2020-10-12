using System;
using System.Data;
using System.Linq;
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
            //Load Packages from Database
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //Click this to Add a Package
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            AddEditPackage frmAddpackage = new AddEditPackage(managePackageListing: this);
            frmAddpackage.ShowDialog();
        }

        //Click this to edit a package
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

        //Populate Grid after each edit/update/add/etc
         public void PopulateGrid()
        {
            var packages = _db.Packages.AsNoTracking().ToList();
            dgvPackages.DataSource = packages;
            dgvPackages.Columns["PackageId"].Visible = false;

            dgvPackages.EndEdit();
           
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

        //Delete Package
        private void btnDeletePackage_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Delete Package?","Delete Action", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

