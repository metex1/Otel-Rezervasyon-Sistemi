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
    public partial class BillPage : Form
    {
        public BillPage()
        {
            InitializeComponent();
        }

        // For reading all bills.
        void getBills()
        {
            billsList.Items.Clear();
            foreach (Bill billInput in (new billService()).showBill())
            {
                string[] billInformations = { billInput.BillID.ToString(), billInput.CustomerID, billInput.ManagerID, billInput.RoomID.ToString(), billInput.Price.ToString(), billInput.BillDate };
                ListViewItem save = new ListViewItem(billInformations);
                billsList.Items.Add(save);
            }
        }

        // For reading bills by customer.
        void billByCustomer(string customerIDInput)
        {
            billsList.Items.Clear();
            foreach (Bill billInput in (new billService()).showBillByCustomer(customerIDInput))
            {
                string[] billInformations = { billInput.BillID.ToString(), billInput.CustomerID, billInput.ManagerID, billInput.RoomID.ToString(), billInput.Price.ToString(), billInput.BillDate };
                ListViewItem save = new ListViewItem(billInformations);
                billsList.Items.Add(save);
            }
        }

        // For reading bills by manager.
        void billByManager(string managerIDInput)
        {
            billsList.Items.Clear();
            foreach (Bill billInput in (new billService()).showBillByManager(managerIDInput))
            {
                string[] billInformations = { billInput.BillID.ToString(), billInput.CustomerID, billInput.ManagerID, billInput.RoomID.ToString(), billInput.Price.ToString(), billInput.BillDate };
                ListViewItem save = new ListViewItem(billInformations);
                billsList.Items.Add(save);
            }
        }

        // For reading bills by room.
        void billByRoom(int roomIDInput)
        {
            billsList.Items.Clear();
            foreach (Bill billInput in (new billService()).showBillByRoom(roomIDInput))
            {
                string[] billInformations = { billInput.BillID.ToString(), billInput.CustomerID, billInput.ManagerID, billInput.RoomID.ToString(), billInput.Price.ToString(), billInput.BillDate };
                ListViewItem save = new ListViewItem(billInformations);
                billsList.Items.Add(save);
            }
        }

        // For reading bills by price.
        void billByPrice(double priceInput)
        {
            billsList.Items.Clear();
            foreach (Bill billInput in (new billService()).showBillByPrice(priceInput))
            {
                string[] billInformations = { billInput.BillID.ToString(), billInput.CustomerID, billInput.ManagerID, billInput.RoomID.ToString(), billInput.Price.ToString(), billInput.BillDate };
                ListViewItem save = new ListViewItem(billInformations);
                billsList.Items.Add(save);
            }
        }

        // For reading bills by date.
        void billByDate(string dateInput)
        {
            billsList.Items.Clear();
            foreach (Bill billInput in (new billService()).showBillByDate(dateInput))
            {
                string[] billInformations = { billInput.BillID.ToString(), billInput.CustomerID, billInput.ManagerID, billInput.RoomID.ToString(), billInput.Price.ToString(), billInput.BillDate };
                ListViewItem save = new ListViewItem(billInformations);
                billsList.Items.Add(save);
            }
        }

        // For reading bills by bill id.
        void billByBillID(int billIDInput)
        {
            billsList.Items.Clear();
            foreach (Bill billInput in (new billService()).showBillByBillID(billIDInput))
            {
                string[] billInformations = { billInput.BillID.ToString(), billInput.CustomerID, billInput.ManagerID, billInput.RoomID.ToString(), billInput.Price.ToString(), billInput.BillDate };
                ListViewItem save = new ListViewItem(billInformations);
                billsList.Items.Add(save);
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

        private void BillPage_Load(object sender, EventArgs e)
        {
            // BillsList
            billsList.Columns.Add("Fatura ID", 292);
            billsList.Columns.Add("Müşteri ID", 292);
            billsList.Columns.Add("Yönetici ID", 292);
            billsList.Columns.Add("Oda ID", 292);
            billsList.Columns.Add("Fiyat", 292);
            billsList.Columns.Add("Fatura Tarihi", 292);
            try
            {
                getBills();
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

        // When customerManagement button clicked.
        private void customerManagement_Click(object sender, EventArgs e)
        {
            CustomerPage customerPage = new CustomerPage();
            this.Hide();
            customerPage.Show();
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

        private void getBillByCustomer_Click(object sender, EventArgs e)
        {
            if (getCustomerIDText.Text != "")
            {
                if (getCustomerIDText.Text.Length == 11 && getCustomerIDText.Text.All(char.IsDigit) == true)
                {
                    try
                    {
                        billByCustomer(getCustomerIDText.Text);
                        MessageBox.Show("Fatura başarıyla bulundu.");
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
                MessageBox.Show("Eksik veya hatalı veri girişi saptandı!");
            }
        }

        private void getBillByManager_Click(object sender, EventArgs e)
        {
            if (getManagerIDText.Text != "")
            {
                if (getManagerIDText.Text.Length == 11 && getManagerIDText.Text.All(char.IsDigit) == true)
                {
                    try
                    {
                        billByManager(getManagerIDText.Text);
                        MessageBox.Show("Fatura başarıyla bulundu.");
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
                MessageBox.Show("Eksik veya hatalı veri girişi saptandı!");
            }
        }

        private void getBillByRoom_Click(object sender, EventArgs e)
        {
            if (getRoomIDText.Text != "")
            {
                if (getRoomIDText.Text.All(char.IsDigit) == true)
                {
                    try
                    {
                        billByRoom(Convert.ToInt32(getRoomIDText.Text));
                        MessageBox.Show("Fatura başarıyla bulundu.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bağlantı Başarısız");
                        throw;
                    }
                    getRoomIDText.Text = "";
                }
                else
                {
                    MessageBox.Show("Hatalı oda id bilgisi saptandı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı veri girişi saptandı!");
            }
        }

        private void getBillByPrice_Click(object sender, EventArgs e)
        {
            if (getPriceText.Text != "")
            {
                if (getPriceText.Text.All(char.IsDigit) == true)
                {
                    try
                    {
                        billByPrice(Convert.ToDouble(getPriceText.Text));
                        MessageBox.Show("Fatura başarıyla bulundu.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bağlantı Başarısız");
                        throw;
                    }
                    getPriceText.Text = "";
                }
                else
                {
                    MessageBox.Show("Hatalı fiyat bilgisi saptandı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı veri girişi saptandı!");
            }
        }

        private void getBillByDate_Click(object sender, EventArgs e)
        {
            if (getDateText.Text != "")
            {
                try
                {
                    billByDate(getDateText.Text);
                    MessageBox.Show("Fatura başarıyla bulundu.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Bağlantı Başarısız");
                    throw;
                }
                getDateText.Text = "";
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı veri girişi saptandı!");
            }
        }

        private void getBillByBilID_Click(object sender, EventArgs e)
        {
            if (getBillIDText.Text != "")
            {
                if (getBillIDText.Text.All(char.IsDigit) == true)
                {
                    try
                    {
                        billByBillID(Convert.ToInt32(getBillIDText.Text));
                        MessageBox.Show("Fatura başarıyla bulundu.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bağlantı Başarısız");
                        throw;
                    }
                    getBillIDText.Text = "";
                }
                else
                {
                    MessageBox.Show("Hatalı fatura id bilgisi saptandı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı veri girişi saptandı!");
            }
        }
    }
}
