using HotelReservationSystem.Domain;
using HotelReservationSystem.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class CustomerPage : Form
    {
        public CustomerPage()
        {
            InitializeComponent();
        }

        // For reading all customers.
        void getCustomers()
        {
            customersList.Items.Clear();
            foreach (Customer customerInput in (new customerService()).showCustomer())
            {
                string[] customerInformations = { customerInput.ID, customerInput.Name, customerInput.Surname, customerInput.PhoneNumber };
                ListViewItem save = new ListViewItem(customerInformations);
                customersList.Items.Add(save);
            }
        }

        // For reading spesific customer.
        void getCustomerSpecifically(string customerIDInput)
        {
            customersList.Items.Clear();
            foreach (Customer customerInput in (new customerService()).showCustomerSpecifically(customerIDInput))
            {
                string[] customerInformations = { customerInput.ID, customerInput.Name, customerInput.Surname, customerInput.PhoneNumber };
                ListViewItem save = new ListViewItem(customerInformations);
                customersList.Items.Add(save);
            }
        }

        // For access to current user informations.
        void current()
        {
            foreach (Manager managerInput in (new managerService()).managerInformations("in"))
            {
                string[] managerInformations = { managerInput.ID, managerInput.Name, managerInput.Surname, managerInput.PhoneNumber, managerInput.Position, managerInput.Password, managerInput.Keyword, managerInput.Status, managerInput.AccessLevel.ToString() };
                if (managerInformations[7] == "in")
                {
                    signedAsLabel.Text = managerInformations[1] + " " + managerInformations[2] + " olarak giriş yapıldı.";
                }
            }
        }

        // For signing out.
        void signOut()
        {
            (new managerService()).signOut();
        }

        // When view appears.
        private void CustomerPage_Load(object sender, EventArgs e)
        {
            // CustomersList
            customersList.Columns.Add("Kimlik No", 439);
            customersList.Columns.Add("Adı", 439);
            customersList.Columns.Add("Soyadı", 439);
            customersList.Columns.Add("Telefon Numarası", 439);
            try
            {
                getCustomers();
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
                current();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
        }

        // When managerManagement button clicked.
        private void managerManagement_Click(object sender, EventArgs e)
        {
            ManagerPage managerPage = new ManagerPage();
            this.Hide();
            managerPage.Show();
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

        // When createCustomer button clicked.
        private void createCustomer_Click(object sender, EventArgs e)
        {
            if (nameText.Text != "" && surnameText.Text != "" && idText.Text != "" && phoneNumberText.Text != "")
            {
                if (idText.Text.Length == 11 && idText.Text.All(char.IsDigit) == true)
                {
                    if (phoneNumberText.Text.Length == 11 && phoneNumberText.Text.All(char.IsDigit) == true)
                    {
                        if (nameText.Text.All(char.IsDigit) == false && nameText.Text.All(char.IsLetter) == true)
                        {
                            if (surnameText.Text.All(char.IsDigit) == false && surnameText.Text.All(char.IsLetter) == true)
                            {
                                try
                                {
                                    (new customerService()).createCustomer(idText.Text, nameText.Text, surnameText.Text, phoneNumberText.Text);
                                    MessageBox.Show("Müşteri başarıyla oluşturuldu.");
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Müşteri oluşturulurken bir hatayla karşılaşıldı!");
                                }
                                try
                                {
                                    getCustomers();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Bağlantı Başarısız");
                                    throw;
                                }
                                nameText.Text = "";
                                surnameText.Text = "";
                                idText.Text = "";
                                phoneNumberText.Text = "";
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
                        MessageBox.Show("Eksik veya hatalı telefon numarası bilgisi saptandı!");
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

        // When editCustomer button clicked.
        private void editCustomer_Click(object sender, EventArgs e)
        {
            if (editNameText.Text != "" && editSurnameText.Text != "" && editCustomerIDText.Text != "" && editPhoneNumberText.Text != "")
            {
                if (editCustomerIDText.Text.Length == 11 && editCustomerIDText.Text.All(char.IsDigit) == true)
                {
                    if (editPhoneNumberText.Text.Length == 11 && editPhoneNumberText.Text.All(char.IsDigit) == true)
                    {
                        if (editNameText.Text.All(char.IsDigit) == false && editNameText.Text.All(char.IsLetter) == true)
                        {
                            if (editSurnameText.Text.All(char.IsDigit) == false && editSurnameText.Text.All(char.IsLetter) == true)
                            {
                                try
                                {
                                    (new customerService()).editCustomer(editCustomerIDText.Text, editNameText.Text, editSurnameText.Text, editPhoneNumberText.Text);
                                    MessageBox.Show("Müşteri başarıyla güncellendi.");
                                }
                                catch
                                {
                                    MessageBox.Show("Müşteri güncellenirken bir hatayla karşılaşıldı!");
                                }
                                try
                                {
                                    getCustomers();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Bağlantı Başarısız");
                                    throw;
                                }
                                editCustomerIDText.Text = "";
                                editNameText.Text = "";
                                editSurnameText.Text = "";
                                editPhoneNumberText.Text = "";
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
                        MessageBox.Show("Eksik veya hatalı telefon numarası bilgisi saptandı!");
                    }
                }
                else
                {
                    MessageBox.Show("Eksik veya hatalı kimlik bilgisi saptandı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı veri girişi saptandı!");
            }
        }

        // When deleteCustomer button clicked.
        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            if (deletedCustomerIDText.Text.Length == 11 && deletedCustomerIDText.Text.All(char.IsDigit) == true)
            {
                try
                {
                    (new customerService()).deleteCustomer(deletedCustomerIDText.Text);
                    MessageBox.Show("Müşteri başarıyla silindi.");
                }
                catch
                {
                    MessageBox.Show("Müşteri silinirken bir hatayla karşılaşıldı!");
                }
                try
                {
                    getCustomers();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bağlantı Başarısız");
                    throw;
                }
                deletedCustomerIDText.Text = "";
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı kimlik bilgisi saptandı!");
            }
        }

        // When getCustomerSpesific button clicked.
        private void getCustomerSpesific_Click(object sender, EventArgs e)
        {
            if (getCustomerIDText.Text.Length == 11)
            {
                if (getCustomerIDText.Text.All(char.IsDigit) == true && getCustomerIDText.Text.All(char.IsLetter) == false)
                {
                    try
                    {
                        getCustomerSpecifically(getCustomerIDText.Text);
                        MessageBox.Show("Müşteri başarıyla bulundu.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bağlantı Başarısız");
                        throw;
                    }
                    getCustomerIDText.Text = "";
                }
                else
                {
                    MessageBox.Show("Hatalı müşteri id bilgisi saptandı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı kimlik bilgisi saptandı!");
            }
        }
    }
}
