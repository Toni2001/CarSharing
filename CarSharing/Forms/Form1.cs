using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarSharing.Forms;
using CarSharing.Helper;
using CarSharing.Model;

namespace CarSharing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsername.Text) && !String.IsNullOrEmpty(txtPassword.Text) && !String.IsNullOrEmpty(txtRePassword.Text))
            {
                if (txtPassword.Text != txtRePassword.Text)
                {
                    MessageBox.Show("Die Passwörter stimmen nicht überein!");
                    return;
                } 

                using (CarSharingDBEntitiesNew context = new CarSharingDBEntitiesNew())
                {
                    User User1 = new User()
                    {
                        Username = txtUsername.Text,
                        Password = HashHelper.ComputeHash(txtPassword.Text, "SHA512", null)
                    };
                    context.User.Add(User1);
                    context.SaveChanges();
                    MessageBox.Show("Deine Daten wurden erfolgreich gespeichert!");

                }
            }
            else
            {
                MessageBox.Show("Bitte fülle alle Felder aus!");
            }
        }
        
        private void lblLoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //LoginForm formLogin = new LoginForm();
            //formLogin.Show();

            this.Hide();
            LoginForm formLogin = new LoginForm();
            formLogin.Closed += (s, args) => this.Close();
            formLogin.Show();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
 
        }
    }
}
