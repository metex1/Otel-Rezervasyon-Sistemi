using HotelReservationSystem.Domain;
using HotelReservationSystem.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class ManagerPage : Form
    {
        public ManagerPage()
        {
            InitializeComponent();
        }

        // For reading all managers.
        void getManagers()
        {
            managersList.Items.Clear();
            foreach (Manager managerInput in (new managerService()).showManagers())
            {
                string[] managerInformations = { managerInput.ID, managerInput.Name, managerInput.Surname, managerInput.PhoneNumber, managerInput.Position, managerInput.Password, managerInput.Keyword, managerInput.AccessLevel.ToString() };
                ListViewItem save = new ListViewItem(managerInformations);
                managersList.Items.Add(save);
            }
        }

        // For reading spesific manager.
        void getManagerSpecifically(string managerIDInput)
        {
            managersList.Items.Clear();
            foreach (Manager managerInput in (new managerService()).showManagerSpecifically(managerIDInput))
            {
                string[] managerInformations = { managerInput.ID, managerInput.Name, managerInput.Surname, managerInput.PhoneNumber, managerInput.Position, managerInput.Password, managerInput.Keyword, managerInput.AccessLevel.ToString() };
                ListViewItem save = new ListViewItem(managerInformations);
                managersList.Items.Add(save);
            }
        }

        // For access to current user's name and surname.
        void current(string statusInput)
        {
            foreach (Manager managerInput in (new managerService()).managerInformations(statusInput))
            {
                string[] managerInformations = { managerInput.ID, managerInput.Name, managerInput.Surname, managerInput.PhoneNumber, managerInput.Position, managerInput.Password, managerInput.Keyword, managerInput.Status, managerInput.AccessLevel.ToString() };
                if (managerInformations[7] == "in")
                {
                    signedAsLabel.Text = managerInformations[1] + " " + managerInformations[2] + " olarak giriş yapıldı.";
                }
            }
        }

        // For access to current user's access level.
        void accessLevel(string statusInput)
        {
            foreach (Manager managerInput in (new managerService()).managerInformations(statusInput))
            {
                string[] managerInformations = { managerInput.ID, managerInput.Name, managerInput.Surname, managerInput.PhoneNumber, managerInput.Position, managerInput.Password, managerInput.Keyword, managerInput.Status, managerInput.AccessLevel.ToString() };
                if (Convert.ToInt32(managerInformations[8]) == 2)
                {
                    createManager.Enabled = true;
                    editManager.Enabled = true;
                    deleteManager.Enabled = true;
                    getManagerSpesific.Enabled = true;
                    managersList.Visible = true;
                }
                else
                {
                    createManager.Enabled = false;
                    editManager.Enabled = false;
                    deleteManager.Enabled = false;
                    getManagerSpesific.Enabled = false;
                    managersList.Visible = false;
                }
            }
        }

        // For signing out.
        void signOut()
        {
            (new managerService()).signOut();
        }

        // When view appears.
        private void ManagerPage_Load(object sender, EventArgs e)
        {
            // Manager's List
            managersList.Columns.Add("Yönetici ID", 219);
            managersList.Columns.Add("Ad", 219);
            managersList.Columns.Add("Soyad", 219);
            managersList.Columns.Add("Tel No", 219);
            managersList.Columns.Add("Pozisyon", 219);
            managersList.Columns.Add("Şifre", 219);
            managersList.Columns.Add("Anahtar Kelime", 219);
            managersList.Columns.Add("Erişim Düzeyi", 219);
            try
            {
                getManagers();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
            // Date Label
            dateLabel.Text = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            // Current User Label
            try
            {
                current("in");
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
            // Access Level
            try
            {
                accessLevel("in");
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        // When reservationManagement button clicked.
        private void reservationManagement_Click(object sender, EventArgs e)
        {
            ReservationPage reservationPage = new ReservationPage();
            this.Hide();
            reservationPage.Show();
        }

        // When roomManagement button clicked.
        private void roomManagement_Click(object sender, EventArgs e)
        {
            RoomPage roomPage = new RoomPage();
            this.Hide();
            roomPage.Show();
        }

        // When customerManagement button clicked.
        private void customerManagement_Click(object sender, EventArgs e)
        {
            CustomerPage customerPage = new CustomerPage();
            this.Hide();
            customerPage.Show();
        }

        // When billManagement button clicked.
        private void billManagement_Click(object sender, EventArgs e)
        {
            BillPage billPage = new BillPage();
            this.Hide();
            billPage.Show();
        }

        // When signOutButton button clicked.
        private void signOutButton_Click(object sender, EventArgs e)
        {
            try
            {
                signOut();
                LoginPage loginPage = new LoginPage();
                this.Hide();
                loginPage.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        // When createManager button clicked.
        private void createManager_Click(object sender, EventArgs e)
        {
            if (idText.Text != "" && nameText.Text != "" && surnameText.Text != "" && phoneNumberText.Text != "" && positionText.Text != "" && passwordText.Text != "" && keywordText.Text != "" && accessLevelText.Text != "")
            {
                if (nameText.Text.All(char.IsLetter) == true)
                {
                    if (surnameText.Text.All(char.IsLetter) == true)
                    {
                        if (idText.Text.All(char.IsDigit) == true && idText.Text.Length == 11)
                        {
                            if (phoneNumberText.Text.All(char.IsDigit) == true && phoneNumberText.Text.Length == 11)
                            {
                                if (passwordText.Text.Length >= 5)
                                {
                                    if (accessLevelText.Text != "1" || accessLevelText.Text != "2")
                                    {
                                        try
                                        {
                                            (new managerService()).createManager(idText.Text, nameText.Text, surnameText.Text, phoneNumberText.Text, positionText.Text, passwordText.Text, keywordText.Text, Convert.ToInt32(accessLevelText.Text));
                                            MessageBox.Show("Yönetici başarıyla oluşturuldu.");
                                        }
                                        catch (Exception)
                                        {
                                            MessageBox.Show("Yönetici oluşturulurken bir hatayla karşılaşıldı!");
                                        }
                                        try
                                        {
                                            getManagers();
                                        }
                                        catch (Exception)
                                        {
                                            MessageBox.Show("Bağlantı Başarısız");
                                            throw;
                                        }
                                        idText.Text = "";
                                        nameText.Text = "";
                                        surnameText.Text = "";
                                        phoneNumberText.Text = "";
                                        positionText.Text = "";
                                        passwordText.Text = "";
                                        keywordText.Text = "";
                                        accessLevelText.Text = "";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Erişim düzeyi 1 veya 2 olabilir!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Şifre en az 5 karakterden oluşmalıdır!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Hatalı telefon numarası bilgisi saptandı!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hatalı kimlik bilgisi saptandı!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hatalı soyisim bilgisi saptandı!");
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı isim bilgisi saptandı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik veri girişi saptandı!");
            }
        }

        // When editManager button clicked.
        private void editManager_Click(object sender, EventArgs e)
        {
            if (managerIDText.Text != "" && editNameText.Text != "" && editSurnameText.Text != "" && editPhoneNumberText.Text != "" && editPositionText.Text != "" && editPasswordText.Text != "" && editKeywordText.Text != "" && editAccessLevelText.Text != "")
            {
                if (managerIDText.Text.Length == 11 && managerIDText.Text.All(char.IsDigit) == true)
                {
                    if (editNameText.Text.All(char.IsLetter) == true)
                    {
                        if (editSurnameText.Text.All(char.IsLetter) == true)
                        {
                            if (editPhoneNumberText.Text.Length == 11 && editPhoneNumberText.Text.All(char.IsDigit) == true)
                            {
                                if (editPositionText.Text == "Müdür" || editPositionText.Text == "Resepsiyonist")
                                {
                                    if (editPasswordText.Text.Length >= 5)
                                    {
                                        if (editAccessLevelText.Text == "1" || editAccessLevelText.Text == "2")
                                        {
                                            try
                                            {
                                                (new managerService()).editManager(managerIDText.Text, editNameText.Text, editSurnameText.Text, editPhoneNumberText.Text, editPositionText.Text, editPasswordText.Text, editKeywordText.Text, Convert.ToInt32(editAccessLevelText.Text));
                                                MessageBox.Show("Yönetici başarıyla güncellendi.");
                                            }
                                            catch
                                            {
                                                MessageBox.Show("Yönetici güncellenirken bir hatayla karşılaşıldı!");
                                            }
                                            try
                                            {
                                                getManagers();
                                            }
                                            catch (Exception)
                                            {
                                                MessageBox.Show("Bağlantı Başarısız");
                                                throw;
                                            }
                                            try
                                            {
                                                current("in");
                                            }
                                            catch (Exception)
                                            {
                                                MessageBox.Show("Bağlantı Başarısız");
                                                throw;
                                            }
                                            managerIDText.Text = "";
                                            editNameText.Text = "";
                                            editSurnameText.Text = "";
                                            editPhoneNumberText.Text = "";
                                            editPositionText.Text = "";
                                            editPasswordText.Text = "";
                                            editKeywordText.Text = "";
                                            editAccessLevelText.Text = "";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Erişim düzeyi 1 veya 2 değerini alabilir.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Şifre en az 5 karakterden oluşmalıdır!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Pozisyon bilgisi sadece müdür veya resepsiyonist olabilir!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Hatalı telefon numarası bilgisi saptandı!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hatalı soyisim bilgisi saptandı!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hatalı isim bilgisi saptandı!");
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı kimlik bilgisi saptandı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik veri girişi saptandı!");
            }
        }

        // When deleteManager button clicked.
        private void deleteManager_Click(object sender, EventArgs e)
        {
            if (deleteManagerIDText.Text != "")
            {
                if (deleteManagerIDText.Text.Length == 11 && deleteManagerIDText.Text.All(char.IsDigit) == true)
                {
                    try
                    {
                        (new managerService()).deleteManager(deleteManagerIDText.Text);
                        MessageBox.Show("Yönetici başarıyla silindi.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Yönetici silinirken bir hatayla karşılaşıldı!");
                    }
                    try
                    {
                        getManagers();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bağlantı Başarısız");
                        throw;
                    }
                    deleteManagerIDText.Text = "";
                }
                else
                {
                    MessageBox.Show("Hatalı kimlik bilgisi saptandı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik veri girişi saptandı!");
            }
        }

        // When getManagerSpesific button clicked.
        private void getManagerSpesific_Click(object sender, EventArgs e)
        {
            if (getManagerIDText.Text.Length == 11)
            {
                if (getManagerIDText.Text.All(char.IsDigit) == true)
                {
                    try
                    {
                        getManagerSpecifically(getManagerIDText.Text);
                        MessageBox.Show("Yönetici başarıyla bulundu.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bağlantı Başarısız");
                        throw;
                    }
                    getManagerIDText.Text = "";
                }
                else
                {
                    MessageBox.Show("Hatalı yönetici id bilgisi saptandı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı kimlik bilgisi saptandı!");
            }
        }
    }
}
