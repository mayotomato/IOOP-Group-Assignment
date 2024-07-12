using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void CustomerRadio_CheckedChanged(object sender, EventArgs e)
        {
            UserLabel.Text = "Email";
            NewUserLinkLabel.Text = "New user? Register account";

        }

        private void ReceptionistRadio_CheckedChanged(object sender, EventArgs e)
        {
            UserLabel.Text = "Username";
            NewUserLinkLabel.Text = "";
        }

        private void ManagerRadio_CheckedChanged(object sender, EventArgs e)
        {
            UserLabel.Text = "Username";
            NewUserLinkLabel.Text = "";
        }

        private void HousekeepingRadio_CheckedChanged(object sender, EventArgs e)
        {
            UserLabel.Text = "Username";
            NewUserLinkLabel.Text = "";
        }

        private void NewUserLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private bool passwordVisibility = false;
        private void PasswordVisibilityButton_Click(object sender, EventArgs e)
        {
            passwordVisibility = !passwordVisibility;

            if (passwordVisibility) 
            {
                PasswordBox.UseSystemPasswordChar = false;
                PasswordVisibilityButton.Image = Properties.Resources.Eye_Show;
            }
            else
            {
                PasswordBox.UseSystemPasswordChar = true;
                PasswordVisibilityButton.Image = Properties.Resources.Eye_Hide;
            }
        }

    }
}
