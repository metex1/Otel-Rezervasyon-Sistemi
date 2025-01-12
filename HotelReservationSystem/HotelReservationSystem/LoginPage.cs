using HotelReservationSystem.Domain;
using HotelReservationSystem.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        // For signing in.
        void login(string managerIDInput)
        {
            foreach (Manager managerInput in (new managerService()).loginAsManager(managerIDInput))
            {
                string[] managerInformations = { managerInput.ID, managerInput.Name, managerInput.Surname, managerInput.PhoneNumber, managerInput.Position, managerInput.Password, managerInput.Keyword, managerInput.Status, managerInput.AccessLevel.ToString() };
                if (managerInformations[5] == passwordText.Text)
                {
                    ManagerPage managerPage = new ManagerPage();
                    this.Hide();
                    managerPage.Show();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz şifre bu kullanıcı ile uyuşmadı!");
                }
            }
        }

        // For resetting password.
        void reset(string resetIDInput, string newPasswordInput)
        {
            foreach (Manager managerInput in (new managerService()).resetPassword(resetIDInput, newPasswordInput))
            {
                string[] managerInformations = { managerInput.ID, managerInput.Name, managerInput.Surname, managerInput.PhoneNumber, managerInput.Position, managerInput.Password, managerInput.Keyword, managerInput.Status, managerInput.AccessLevel.ToString() };
                if (managerInformations[6] == keywordText.Text)
                {
                    MessageBox.Show("Şifre başarıyla sıfırlandı.");
                }
                else
                {
                    MessageBox.Show("Girdiğiniz anahtar kelime bu kullanıcı ile uyuşmadı!");
                }
            }
        }

        // When view appears.
        private void LoginPage_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
        }

        // When loginAsManager button clicked.
        private void loginAsManager_Click(object sender, EventArgs e)
        {
            if (idText.Text != "" && passwordText.Text != "")
            {
                if (idText.Text.Length == 11 && idText.Text.All(char.IsDigit) == true)
                {
                    if (passwordText.Text.Length >= 5)
                    {
                        try
                        {
                            login(idText.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Bağlantı Başarısız");
                            throw;
                        }
                        idText.Text = "";
                        passwordText.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Eksik şifre bilgisi saptandı!");
                    }
                }
                else
                {
                    MessageBox.Show("Eksik veya hatalı kimlik bilgisi saptandı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik veri girişi saptandı!");
            }
        }

        // When resetPassword button clicked.
        private void resetPassword_Click(object sender, EventArgs e)
        {
            if (resetIDText.Text != "" && keywordText.Text != "" && newPasswordText.Text != "")
            {
                if (resetIDText.Text.Length == 11 && resetIDText.Text.All(char.IsDigit) == true)
                {
                    if (newPasswordText.Text.Length >= 5)
                    {
                        try
                        {
                            reset(resetIDText.Text, newPasswordText.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Bağlantı Başarısız");
                            throw;
                        }
                        resetIDText.Text = "";
                        keywordText.Text = "";
                        newPasswordText.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Eksik yeni şifre bilgisi saptandı!");
                    }
                }
                else
                {
                    MessageBox.Show("Eksik veya hatalı kimlik bilgisi saptandı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik veri girişi saptandı!");
            }
        }

        // When loginCheckBox's button clicked.
        private void loginCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (loginCheckBox.Checked)
            {
                passwordText.PasswordChar = '*';
            }
            else
            {
                passwordText.PasswordChar = '\0';
            }
        }

        // When resetCheckBox's button clicked.
        private void resetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (resetCheckBox.Checked)
            {
                keywordText.PasswordChar = '*';
                newPasswordText.PasswordChar = '*';
            }
            else
            {
                keywordText.PasswordChar = '\0';
                newPasswordText.PasswordChar = '\0';
            }
        }
    }
}
