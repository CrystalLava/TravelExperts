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

                txtBasicPrice.Text = package.PkgBasePrice.ToString();

                if (package.PkgAgencyCommission.HasValue)
                    txtAgencyCommision.Text = package.PkgAgencyCommission.Value.ToString();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            try
            {
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

                    MessageBox.Show("Package is added successfully!");

                }
                else
                {
                    //edit package

                    MessageBox.Show("Package is editted successfully!");
                    _db.SaveChanges();
                }


                _managePackageListing.FillPackageData();
  _managePackageListing.dgvPakages.Update();
                _managePackageListing.dgvPakages.Refresh();
              

                AddEditPackage.ActiveForm.Close();

            }
            catch (Exception ex)
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBasicPrice_Leave(object sender, EventArgs e)
        {
            //Double value;
            //if (Double.TryParse(txtBasicPrice.Text, out value))
            //    txtBasicPrice.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            //else
            //    txtBasicPrice.Text = String.Empty;
        }
    }
}
