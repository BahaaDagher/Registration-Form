using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string nameText = NameBox.Text;
            string emailText = EmailBox.Text;
            bool nameBool = false; 
            bool emailBool = false; 
            bool genderBool = false; 
            bool hoppyBool = false;
            if (nameText.Length >= 15) nameBool = true; 
            if (emailText.Contains("@")) emailBool = true;
            if (MaleRad.Checked ||  FemaleRad.Checked) genderBool = true;
            if (FootballCheck.Checked || TennisCheck.Checked || SwimmingCheck.Checked) hoppyBool = true;   

            if (!nameBool || !emailBool || !genderBool || !hoppyBool)
            {
                ValidReg.Visible = false;

                if (nameBool) NameError.Visible = false; 
                else NameError.Visible = true;

                if (emailBool) EmailError.Visible = false;
                else EmailError.Visible = true;

                if (genderBool) GenderError.Visible = false;
                else GenderError.Visible = true;


                if (hoppyBool) HoppyError.Visible = false;
                else HoppyError.Visible = true;


            }
            else
            {
                NameError.Visible = false;
                EmailError.Visible = false;
                GenderError.Visible = false;
                HoppyError.Visible = false;

                ValidReg.Visible = true;
            }
        }
    }
}
