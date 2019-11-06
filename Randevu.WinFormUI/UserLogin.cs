using Randevu.BLL;
using Randevu.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randevu.WinFormUI
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        UserController userControl;

        private void llblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegister userRegister = new UserRegister();
            userRegister.Show();
            Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userControl = new UserController();
            List<User> users = userControl.GetAll();

            foreach (User user in users)
            {
                if (user.Email == txtEMail.Text & user.Password == txtPassword.Text)
                {
                    Homepage homepage = new Homepage();
                    homepage.userRole = Convert.ToInt32(user.UserRole);
                    Homepage.userID = Convert.ToInt32(user.UserId);
                    homepage.Show();
                    Hide();
                    return;
                }
            }
            MessageBox.Show("Girilen email veya şifre hatalı.");

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVisible.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }
    }
}
