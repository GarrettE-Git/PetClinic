using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPetClinic
{
    public partial class frmPetClinic : Form
    {
        //Declare variables and values
        double dblWellnessExam = 39.99;
        double dblVaccinations = 59.99;
        double dblMicrochipping = 44.99;
        double dblParasiteTreatment = 29.99;
        double dblTickFlea = 24.99;
        double dblXRay = 79.99;
        double dblNailTrimming = 14.99;
        double dblBathing = 29.99;
        double dblHaircut = 34.99;

        double dblResult = 0;

        public frmPetClinic()
        {
            InitializeComponent();
        }

        private void CbxWellnessExam_CheckedChanged(object sender, EventArgs e)
        {
            /*If the checkbox is checked, shows the price in the corresponding label 
             * and adds to the total. If unchecked, it
               removes the price and subtracts from total*/

            if (cbxWellnessExam.Checked)
            {
                lblWellnessExam.Text = dblWellnessExam.ToString();
                dblResult += dblWellnessExam;
            }
            else
            {
                lblWellnessExam.Text = string.Empty;
                dblResult -= dblWellnessExam;
            }

            lblResult.Text = dblResult.ToString("c");
        }

        private void CbxVaccinations_CheckedChanged(object sender, EventArgs e)
        {
        
            if (cbxVaccinations.Checked)
            {
                lblVaccinations.Text = dblVaccinations.ToString();
                dblResult += dblVaccinations;
            }
            else
            {
                lblVaccinations.Text = string.Empty;
                dblResult -= dblVaccinations;
            }

            lblResult.Text = dblResult.ToString("c");
        }

        private void CbxMicrochipping_CheckedChanged(object sender, EventArgs e)
        {
        
            if (cbxMicrochipping.Checked)
            {
                lblMicrochipping.Text = dblMicrochipping.ToString();
                dblResult += dblMicrochipping;
            }
            else
            {
                lblMicrochipping.Text = string.Empty;
                dblResult -= dblMicrochipping;
            }

            lblResult.Text = dblResult.ToString("c");
        }

        private void CbxParasiteTreatment_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxParasiteTreatment.Checked)
            {
                lblParasiteTreatment.Text = dblParasiteTreatment.ToString();
                dblResult += dblParasiteTreatment;
            }
            else
            {
                lblParasiteTreatment.Text = string.Empty;
                dblResult -= dblParasiteTreatment;
            }

            lblResult.Text = dblResult.ToString("c");
        }

        private void CbxTickFlea_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxTickFlea.Checked)
            {
                lblTickFlea.Text = dblTickFlea.ToString();
                dblResult += dblTickFlea;
            }
            else
            {
                lblTickFlea.Text = string.Empty;
                dblResult -= dblTickFlea;
            }

            lblResult.Text = dblResult.ToString("c");
        }

        private void CbxXRay_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxXRay.Checked)
            {
                lblXRay.Text = dblXRay.ToString();
                dblResult += dblXRay;
            }
            else
            {
                lblXRay.Text = string.Empty;
                dblResult -= dblXRay;
            }

            lblResult.Text = dblResult.ToString("c");
        }

        private void CbxNailTrimming_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxNailTrimming.Checked)
            {
                lblNailTrimming.Text = dblNailTrimming.ToString();
                dblResult += dblNailTrimming;
            }
            else
            {
                lblNailTrimming.Text = string.Empty;
                dblResult -= dblNailTrimming;
            }

            lblResult.Text = dblResult.ToString("c");
        }

        private void CbxBathing_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxBathing.Checked)
            {
                lblBathing.Text = dblBathing.ToString();
                dblResult += dblBathing;
            }
            else
            {
                lblBathing.Text = string.Empty;
                dblResult -= dblBathing;
            }

            lblResult.Text = dblResult.ToString("c");
        }

        private void CbxHaircut_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxHaircut.Checked)
            {
                lblHaircut.Text = dblHaircut.ToString();
                dblResult += dblHaircut;
            }
            else
            {
                lblHaircut.Text = string.Empty;
                dblResult -= dblHaircut;
            }

            lblResult.Text = dblResult.ToString("c");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //Clears everything and unchecks all boxes

            lblWellnessExam.Text = string.Empty;
            lblVaccinations.Text = string.Empty;
            lblMicrochipping.Text = string.Empty;
            lblParasiteTreatment.Text = string.Empty;
            lblTickFlea.Text = string.Empty;
            lblXRay.Text = string.Empty;
            lblBathing.Text = string.Empty;
            lblNailTrimming.Text = string.Empty;
            lblHaircut.Text = string.Empty;
            lblResult.Text = string.Empty;

            cbxWellnessExam.Checked = false;
            cbxVaccinations.Checked = false;
            cbxMicrochipping.Checked = false;
            cbxParasiteTreatment.Checked = false;
            cbxTickFlea.Checked = false;
            cbxXRay.Checked = false;
            cbxNailTrimming.Checked = false;
            cbxHaircut.Checked = false;
            cbxBathing.Checked = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Exits the application

            Application.Exit();
        }

    }
}
