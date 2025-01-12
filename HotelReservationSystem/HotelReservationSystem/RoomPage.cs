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
    public partial class RoomPage : Form
    {
        public RoomPage()
        {
            InitializeComponent();
        }

        // For reading all rooms.
        void getRooms()
        {
            roomsList.Items.Clear();
            foreach (Room roomInput in (new roomService()).showRoom())
            {
                string[] roomInformations = { roomInput.RoomID.ToString(), roomInput.RoomName, roomInput.RoomType, roomInput.Price.ToString(), roomInput.RoomStatus };
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

        // For access to current user's access level.
        void accessLevel(string statusInput)
        {
            foreach (Manager managerInput in (new managerService()).managerInformations(statusInput))
            {
                string[] managerInformations = { managerInput.ID, managerInput.Name, managerInput.Surname, managerInput.PhoneNumber, managerInput.Position, managerInput.Password, managerInput.Keyword, managerInput.Status, managerInput.AccessLevel.ToString() };
                if (Convert.ToInt32(managerInformations[8]) == 2)
                {
                    createRoom.Enabled = true;
                    editRoom.Enabled = true;
                    deleteRoom.Enabled = true;
                    makeAnEntrance.Enabled = true;
                    makeAnExit.Enabled = true;
                    roomsList.Visible = true;
                }
                else
                {
                    createRoom.Enabled = false;
                    editRoom.Enabled = false;
                    deleteRoom.Enabled = false;
                    makeAnEntrance.Enabled = true;
                    makeAnExit.Enabled = true;
                    roomsList.Visible = true;
                }
            }
        }

        // For signing out.
        void signOut()
        {
            (new managerService()).signOut();
        }

        // When view appears.
        private void RoomPage_Load(object sender, EventArgs e)
        {
            // RoomsList
            roomsList.Columns.Add("Oda ID", 351);
            roomsList.Columns.Add("Oda Adı", 351);
            roomsList.Columns.Add("Oda Tipi", 351);
            roomsList.Columns.Add("Fiyat", 351);
            roomsList.Columns.Add("Oda Durumu", 351);
            try
            {
                getRooms();
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

        // When createRoom button clicked.
        private void createRoom_Click(object sender, EventArgs e)
        {
            if (roomNameText.Text != "" && roomTypeText.Text != "" && priceText.Text != "")
            {
                if (roomTypeText.Text == "Normal" || roomTypeText.Text == "Aile" || roomTypeText.Text == "Suit")
                {
                    if (priceText.Text.All(char.IsDigit) == true && priceText.Text.All(char.IsLetter) == false)
                    {
                        try
                        {
                            (new roomService()).createRoom(roomNameText.Text, roomTypeText.Text, Convert.ToDouble(priceText.Text));
                            MessageBox.Show("Oda başarıyla oluşturuldu.");
                        }
                        catch
                        {
                            MessageBox.Show("Oda oluşturulurken bir hatayla karşılaşıldı!");
                        }
                        try
                        {
                            getRooms();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Bağlantı Başarısız");
                            throw;
                        }
                        roomNameText.Text = "";
                        roomTypeText.Text = "";
                        priceText.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Hatalı oda fiyatı bilgisi saptandı!");
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı oda tipi bilgisi saptandı!");
                }
            }
            else
            {
                MessageBox.Show("Eksik veya hatalı veri girişi saptandı!");
            }
        }

        // When editRoom button clicked.
        private void editRoom_Click(object sender, EventArgs e)
        {
            if (roomIDText.Text != "" && editRoomNameText.Text != "" && editRoomTypeText.Text != "" && editPriceText.Text != "")
            {
                if (roomIDText.Text.All(char.IsDigit) == true && roomIDText.Text.All(char.IsLetter) == false)
                {
                    if (editRoomTypeText.Text == "Normal" || editRoomTypeText.Text == "Aile" || editRoomTypeText.Text == "Suit")
                    {
                        if (editPriceText.Text.All(char.IsDigit) == true && editPriceText.Text.All(char.IsLetter) == false)
                        {
                            try
                            {
                                (new roomService()).editRoom(Convert.ToInt32(roomIDText.Text), editRoomNameText.Text, editRoomTypeText.Text, Convert.ToDouble(editPriceText.Text));
                                MessageBox.Show("Oda başarıyla güncellendi.");
                            }
                            catch
                            {
                                MessageBox.Show("Oda güncellenirken bir hatayla karşılaşıldı!");
                            }
                            try
                            {
                                getRooms();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Bağlantı Başarısız");
                                throw;
                            }
                            roomIDText.Text = "";
                            editRoomNameText.Text = "";
                            editRoomTypeText.Text = "";
                            editPriceText.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Hatalı oda fiyatı bilgisi saptandı!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hatalı oda tipi bilgisi saptandı!");
                    }
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

        // When deleteRoom button clicked.
        private void deleteRoom_Click(object sender, EventArgs e)
        {
            if (deletedRoomIDText.Text != "")
            {
                if (deletedRoomIDText.Text.All(char.IsDigit) == true && deletedRoomIDText.Text.All(char.IsLetter) == false)
                {
                    try
                    {
                        (new roomService()).deleteRoom(Convert.ToInt32(deletedRoomIDText.Text));
                        MessageBox.Show("Oda başarıyla silindi.");
                    }
                    catch
                    {
                        MessageBox.Show("Oda silinirken bir hatayla karşılaşıldı!");
                    }
                    try
                    {
                        getRooms();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bağlantı Başarısız");
                        throw;
                    }
                    deletedRoomIDText.Text = "";
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

        // When makeAnEntrance button clicked.
        private void makeAnEntrance_Click(object sender, EventArgs e)
        {
            if (entryExitRoomIDText.Text != "")
            {
                if (entryExitRoomIDText.Text.All(char.IsDigit) == true && entryExitRoomIDText.Text.All(char.IsLetter) == false)
                {
                    try
                    {
                        (new roomService()).makeAnEntrance(Convert.ToInt32(entryExitRoomIDText.Text));
                        MessageBox.Show("Odaya giriş başarıyla gerçekleşti.");
                    }
                    catch
                    {
                        MessageBox.Show("Odaya giriş esnasında bir hatayla karşılaşıldı!");
                    }
                    try
                    {
                        getRooms();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bağlantı Başarısız");
                        throw;
                    }
                    entryExitRoomIDText.Text = "";
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

        // When makeAnExit button clicked.
        private void makeAnExit_Click(object sender, EventArgs e)
        {
            if (entryExitRoomIDText.Text != "")
            {
                if (entryExitRoomIDText.Text.All(char.IsDigit) == true && entryExitRoomIDText.Text.All(char.IsLetter) == false)
                {
                    try
                    {
                        (new roomService()).makeAnExit(Convert.ToInt32(entryExitRoomIDText.Text));
                        MessageBox.Show("Odadan çıkış başarıyla gerçekleşti.");
                    }
                    catch
                    {
                        MessageBox.Show("Odadan çıkış esnasında bir hatayla karşılaşıldı!");
                    }
                    try
                    {
                        getRooms();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bağlantı Başarısız");
                        throw;
                    }
                    entryExitRoomIDText.Text = "";
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
    }
}
