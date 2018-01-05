using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarSharing.Helper;
using CarSharing.Model;

namespace CarSharing.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }
    

        private void btbLogin_Click(object sender, EventArgs e)
        {
            

            if (!String.IsNullOrEmpty(txtUsername.Text) || !String.IsNullOrEmpty(txtPassword.Text))
            {
                using (CarSharingDBEntitiesNew context = new CarSharingDBEntitiesNew())
                {
                    User user = context.User.FirstOrDefault(u => u.Username == txtUsername.Text);
                    if (user == null)
                    {
                        MessageBox.Show("User existiert nicht!");
                        return;
                    }
                    var isValid = HashHelper.VerifyHash(txtPassword.Text, "SHA512", user.Password);
                    if (isValid)
                    {
                        MessageBox.Show("Login erfolgreich!");
                        this.Hide();
                        MainForm formMainForm = new MainForm();
                        formMainForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Passwort stimmt nicht!");
                    }
                }
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


