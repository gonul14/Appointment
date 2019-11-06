using Randevu.BLL;
using Randevu.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Randevu.WinFormUI
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }
        UserController userControl;
        private void UserRegister_Load(object sender, EventArgs e)
        {
            txtTC.MaxLength = 11;
            txtFirstName.MaxLength = 50;
            txtLastName.MaxLength = 50;
            txtEMail.MaxLength = 50;
            txtPassword.MaxLength = 16;
            txtRePassword.MaxLength = 16;
            txtPhoneNumber.MaxLength = 11;
            dtpBirthDate.MaxDate = DateTime.Today;
            txtPassword.PasswordChar = '*';
            txtRePassword.PasswordChar = '*';
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string identityNo = txtTC.Text;
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEMail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string rePassword = txtRePassword.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            string gender = rbMan.Checked ? "Erkek" : "Kadın";
            DateTime birthDate = dtpBirthDate.Value;
            
            

            if (identityNo.Length == 11 & firstName.Length > 0 & lastName.Length > 0 & email.Length > 0 & password.Length > 0)
            {
                userControl = new UserController();
                List<User> users = userControl.GetAll();
                foreach (User user in users)
                {
                    if (identityNo == user.IdentityNo)
                    {
                        MessageBox.Show("Bu TC'ye ait hesap bulunmaktadır.");
                        return;
                    }
                    else if (email == user.Email)
                    {
                        MessageBox.Show("Bu mail adresine ait hesap bulunmaktadır.");
                        return;
                    }
                }

                Regex regexPass = new Regex("^[a-zA-Z0-9]+$");
                Regex regexMail = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");

                if (regexMail.IsMatch(email))
                {
                    if (password.Length >= 8 & password.Length <= 16)
                    {
                        if (regexPass.IsMatch(password) & regexPass.IsMatch(rePassword))
                        {
                            if (password == rePassword)
                            {
                                userControl = new UserController();
                                User user = new User();
                                user.IdentityNo = identityNo;
                                user.LastName = lastName;
                                user.FirstName = firstName;
                                user.Email = email;
                                user.Password = password;
                                user.PhoneNumber = phone;
                                user.BirthDate = birthDate;
                                user.Gender = gender;

                                user.DepartmentId = null;

                                user.UserRole = User.UserType.Patient;
                                user.IsValid = true;
                                userControl.Add(user);

                                MessageBox.Show("Kayıt işlemi gerçekleşti.");

                                UserLogin login = new UserLogin();
                                login.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Bu şifreler eşleşmiyor. Tekrar deneyin.");
                                txtRePassword.Text = string.Empty;
                            }
                        }

                        else
                        {
                            MessageBox.Show("Şifre özel karakterler içeremez.");
                            txtRePassword.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifre 8-16 karakter olmalıdır.");
                        txtPassword.Text = string.Empty;
                        txtRePassword.Text = string.Empty;
                    }

                }
                else
                {
                    MessageBox.Show("Doğru bir mail giriniz.");
                }
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurun.");
                textColor();
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        if (control.Text == string.Empty)
                        {
                            if (control.Name != "txtPhoneNumber")
                            {
                                control.BackColor = Color.FromArgb(247,244,208);
                            }
                        }
                    }
                }
            }



        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void TxtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textColor()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.BackColor = Color.White;
                }
            }
        }
    }
}
