using HotelReservationSystem.Domain;
using HotelReservationSystem.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class ReservationPage : Form
    {
        public ReservationPage()
        {
            InitializeComponent();
        }

        // For reading all reservations.
        void getReservations()
        {
            reservationsList.Items.Clear();
            foreach (Reservation reservationInput in (new reservationService()).showReservation())
            {
                string[] reservationInformations = { reservationInput.ReservationID.ToString(), reservationInput.ManagerID, reservationInput.CustomerID, reservationInput.RoomID.ToString(), reservationInput.ReservationStarts.ToString(), reservationInput.ReservationEnds.ToString() };
                ListViewItem save = new ListViewItem(reservationInformations);
                reservationsList.Items.Add(save);
            }
        }

        // For reading spesific reservations.
        void getReservationSpecifically(string customerIDInput)
        {
            reservationsList.Items.Clear();
            foreach (Reservation reservationInput in (new reservationService()).showReservationSpecifically(customerIDInput))
            {
                string[] reservationInformations = { reservationInput.ReservationID.ToString(), reservationInput.ManagerID, reservationInput.CustomerID, reservationInput.RoomID.ToString(), reservationInput.ReservationStarts.ToString(), reservationInput.ReservationEnds.ToString() };
                ListViewItem save = new ListViewItem(reservationInformations);
                reservationsList.Items.Add(save);
            }
        }

        // For reading spesific rooms.
        void getRoomSpecifically(string roomTypeInput)
        {
            roomsList.Items.Clear();
            foreach (Room roomInput in (new reservationService()).showRoomSpecifically(roomTypeInput))
            {
                string[] roomInformations = { roomInput.RoomID.ToString(), roomInput.RoomName, roomInput.RoomStatus };
                ListViewItem save = new ListViewItem(roomInformations);
                roomsList.Items.Add(save);
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

        // For access to who did the reservation.
        void transactionBy()
        {
            foreach (Manager managerInput in (new managerService()).managerInformations("in"))
            {
                string[] managerInformations = { managerInput.ID, managerInput.Name, managerInput.Surname, managerInput.PhoneNumber, managerInput.Position, managerInput.Password, managerInput.Keyword, managerInput.Status, managerInput.AccessLevel.ToString() };
                if (managerInformations[7] == "in")
                {
                    transactionByLabel.Text = managerInformations[0];
                }
            }
        }

        // For access to price of the reserved room.
        void reservedRoomPrice(int roomIDInput)
        {
            foreach (Room roomInput in (new roomService()).priceForBill(roomIDInput))
            {
                string[] roomInformations = { roomInput.RoomID.ToString(), roomInput.RoomName, roomInput.RoomType, roomInput.Price.ToString(), roomInput.RoomStatus };
                reservedRoomPriceLabel.Text = roomInformations[3];
            }
        }

        // For signing out.
        void signOut()
        {
            (new managerService()).signOut();
        }

        // When view appears.
        private void ReservationPage_Load(object sender, EventArgs e)
        {
            // ReservationsList
            reservationsList.Columns.Add("Rezervasyon ID", 247);
            reservationsList.Columns.Add("Yönetici ID", 247);
            reservationsList.Columns.Add("Müşteri ID", 247);
            reservationsList.Columns.Add("Oda ID", 247);
            reservationsList.Columns.Add("Başlangıç ​​Tarihi", 247);
            reservationsList.Columns.Add("Bitiş Tarihi", 247);
            try
            {
                getReservations();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Başarısız");
                throw;
            }
            // RoomsList
            roomsList.Columns.Add("Oda ID", 88);
            roomsList.Columns.Add("Oda Adı", 88);
            roomsList.Columns.Add("Durum", 88);
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
            // Transaction By Label
            try
            {
                transactionBy();
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

        // When newReservation button clicked.
        private void newReservation_Click(object sender, EventArgs e)
        {
            if (idText.Text != "" && roomIDText.Text != "")
            {
                if (idText.Text.Length == 11 && idText.Text.All(char.IsDigit) == true && idText.Text.All(char.IsLetter) == false)
                {
                    if (roomIDText.Text.All(char.IsDigit) == true && roomIDText.Text.All(char.IsLetter) == false)
                    {
                        try
                        {
                            reservedRoomPrice(Convert.ToInt32(roomIDText.Text));
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Bağlantı Başarısız");
                            throw;
                        }
                        try
                        {
                            (new reservationService()).createReservation(idText.Text, transactionByLabel.Text , Convert.ToInt32(roomIDText.Text), startDatePicker.Value.Year + "-" + startDatePicker.Value.Month + "-" + startDatePicker.Value.Day, endDatePicker.Value.Year + "-" + endDatePicker.Value.Month + "-" + endDatePicker.Value.Day);
                            (new billService()).createBill(idText.Text , transactionByLabel.Text , Convert.ToInt32(roomIDText.Text) , Convert.ToDouble(reservedRoomPriceLabel.Text) , DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);
                            MessageBox.Show("Rezervasyon başarıyla oluşturuldu.");
                        }
                        catch
                        {
                            MessageBox.Show("Rezervasyon oluşturulurken bir hatayla karşılaşıldı!");
                        }
                        try
                        {
                            getReservations();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Bağlantı Başarısız");
                            throw;
                        }
                        idText.Text = "";
                        roomIDText.Text = "";
                        startDatePicker.Text = DateTime.Now.ToString();
                        endDatePicker.Text = DateTime.Now.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı oda id bilgisi saptandı!");
                    }
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

        // When editReservation button clicked.
        private void editReservation_Click(object sender, EventArgs e)
        {
            if (reservationIDText.Text != "")
            {
                if (reservationIDText.Text.All(char.IsDigit) == true && reservationIDText.Text.All(char.IsLetter) == false)
                {
                    try
                    {
                        (new reservationService()).editReservation(Convert.ToInt32(reservationIDText.Text), editStartDatePicker.Value.Year + "-" + editStartDatePicker.Value.Month + "-" + editStartDatePicker.Value.Day, editEndDatePicker.Value.Year + "-" + editEndDatePicker.Value.Month + "-" + editEndDatePicker.Value.Day);
                        MessageBox.Show("Rezervasyon başarıyla güncellendi.");
                    }
                    catch
                    {
                        MessageBox.Show("Rezervasyon güncellenirken bir hatayla karşılaşıldı!");
                    }
                    try
                    {
                        getReservations();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bağlantı Başarısız");
                        throw;
                    }
                    reservationIDText.Text = "";
                    editStartDatePicker.Text = DateTime.Now.ToString();
                    editEndDatePicker.Text = DateTime.Now.ToString();
                }
                else
                {
                    MessageBox.Show("Hatalı rezervasyon id bilgisi saptandı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı veri girişi saptandı!");
            }
        }

        // When deleteReservation button clicked.
        private void deleteReservation_Click(object sender, EventArgs e)
        {
            if (deleteReservationIDText.Text != "")
            {
                if (deleteReservationIDText.Text.All(char.IsDigit) == true && deleteReservationIDText.Text.All(char.IsLetter) == false)
                {
                    try
                    {
                        (new reservationService()).deleteReservation(Convert.ToInt32(deleteReservationIDText.Text));
                        MessageBox.Show("Rezervasyon başarıyla silindi.");
                    }
                    catch
                    {
                        MessageBox.Show("Rezervasyon silinirken bir hatayla karşılaşıldı!");
                    }
                    try
                    {
                        getReservations();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bağlantı Başarısız");
                        throw;
                    }
                    deleteReservationIDText.Text = "";
                }
                else
                {
                    MessageBox.Show("Hatalı rezervasyon id bilgisi saptandı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı veri girişi saptandı!");
            }
        }

        // When getReservationSpesific button clicked.
        private void getReservationSpesific_Click(object sender, EventArgs e)
        {
            if (getCustomerIDText.Text != "")
            {
                if (getCustomerIDText.Text.All(char.IsDigit) == true && getCustomerIDText.Text.All(char.IsLetter) == false)
                {
                    try
                    {
                        getReservationSpecifically(getCustomerIDText.Text);
                        MessageBox.Show("Rezervasyon başarıyla bulundu.");
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

        // When getRooms button clicked.
        private void getRooms_Click(object sender, EventArgs e)
        {
            if (roomTypeText.Text == "Normal" || roomTypeText.Text == "Aile" || roomTypeText.Text == "Suit")
            {
                try
                {
                    getRoomSpecifically(roomTypeText.Text);
                    MessageBox.Show("Odalar başarıyla bulundu.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Bağlantı Başarısız");
                    throw;
                }
                roomTypeText.Text = "";
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı veri girişi saptandı!");
            }
        } 
    }
}
