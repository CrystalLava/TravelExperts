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
    public partial class AddEditPackage : Form
    {
        private readonly Package packageTemp;
        private readonly ManagePackageListing _managePackageListing;
        private readonly TravelExpertsEntities _db;
        public AddEditPackage(Package package = null, ManagePackageListing managePackageListing = null)
        {
            InitializeComponent();
            _db = new TravelExpertsEntities();

            _managePackageListing = managePackageListing;

            packageTemp = package;
            if (package != null)
            {
                txtPackageName.Text = package.PkgName;
                txtDescription.Text = package.PkgDesc;

                if (package.PkgStartDate.HasValue)
                    dtpStartDate.Value = package.PkgStartDate.Value;

                if (package.PkgEndDate.HasValue)
                    dtpEndDate.Value = package.PkgEndDate.Value;

                txtBasicPrice.Text = package.PkgBasePrice.ToString("C");

                if (package.PkgAgencyCommission.HasValue)
                    txtAgencyCommision.Text = package.PkgAgencyCommission.Value.ToString("C");
            }
        }

         private void btnSaveChanges_Click(object sender, EventArgs e)
         {

             try
             {
                 if (string.IsNullOrWhiteSpace(txtPackageName.Text))
                 {
                     MessageBox.Show("Package name can't be empty!");

                     return;
                 }
                 if (string.IsNullOrWhiteSpace(txtDescription.Text))
                 {
                     MessageBox.Show("How would you describe the package?");

                     return;
                 }


                if (dtpStartDate.Value > dtpEndDate.Value)
                {
                    MessageBox.Show("Package End Date must be later than Package Start Date!");

                    return;
                }

                if (string.IsNullOrWhiteSpace(txtBasicPrice.Text))
                 {
                     MessageBox.Show("Base Price cannot be empty?");

                     return;
                 }

                 if (string.IsNullOrWhiteSpace(txtAgencyCommision.Text))
                 {
                     MessageBox.Show("Agency Commission cannot be empty!");

                     return;
                 }

                decimal d = 0;
                 if (!decimal.TryParse(txtBasicPrice.Text, out d))
                 {
                     //Error

                     MessageBox.Show("Error: Wrong format for Base Price!");

                     return;
                 }



                 if (!decimal.TryParse(txtAgencyCommision.Text, out d))
                 {
                     //Error

                     MessageBox.Show("Error: Wrong format for Agency Commission!");

                     return;
                 }

                 var basicPrice = decimal.Parse(txtBasicPrice.Text);
                 var agencyCommision = decimal.Parse(txtAgencyCommision.Text);

                 if (agencyCommision > basicPrice)
                 {
                     MessageBox.Show("Agency Commission can't be greater than Base Price!");

                     return;
                 }


                 Package newPackage = new Package();
    
                 if (packageTemp != null)
                 {
                     newPackage = _db.Packages.FirstOrDefault(p => p.PackageId == packageTemp.PackageId);
                 }


                 newPackage.PkgName = txtPackageName.Text;
                 newPackage.PkgDesc = txtDescription.Text;
                 newPackage.PkgStartDate = dtpStartDate.Value;
                 newPackage.PkgEndDate = dtpEndDate.Value;
                 newPackage.PkgBasePrice = decimal.Parse(txtBasicPrice.Text);
                 newPackage.PkgAgencyCommission = decimal.Parse(txtAgencyCommision.Text);



                 if (packageTemp == null)
                 {
                     // add package
                     _db.Packages.Add(newPackage);
                     _db.SaveChanges();

                     MessageBox.Show("Package added successfully!");

                 }
                 else
                 {
                     //edit package

                     MessageBox.Show("Package edited successfully!");
                     _db.SaveChanges();
                 }
                 
                 _managePackageListing.PopulateGrid();
                 _managePackageListing.dgvPackages.Update();
                 _managePackageListing.dgvPackages.Refresh();

                 this.Close();

             }
             catch (Exception ex)
             {


                 MessageBox.Show(ex.Message);

                 MessageBox.Show($"Error: {ex.Message}");

             }
         }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
 }


