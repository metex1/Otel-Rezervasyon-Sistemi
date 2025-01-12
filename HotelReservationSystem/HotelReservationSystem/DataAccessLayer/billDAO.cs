using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Domain;
using MySql;
using MySql.Data.MySqlClient;

namespace HotelReservationSystem.DataAccessLayer
{
    public class billDAO
    {
        // Data Access Object for showing all rooms.
        public System.Collections.ArrayList showBill()
        {
            ArrayList billList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Bill", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                billList.Add(new Bill(Convert.ToInt32(data[0]), data[1].ToString(), data[2].ToString(), Convert.ToInt32(data[3]), Convert.ToDouble(data[4]), data[5].ToString()));
            }
            return billList;
        }

        // Data Access Object for showing rooms by customer.
        public System.Collections.ArrayList showBillByCustomer(string customerIDInput)
        {
            ArrayList billList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Bill WHERE customerID='" + customerIDInput + "'", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                billList.Add(new Bill(Convert.ToInt32(data[0]), data[1].ToString(), data[2].ToString(), Convert.ToInt32(data[3]), Convert.ToDouble(data[4]), data[5].ToString()));
            }
            return billList;
        }

        // Data Access Object for showing rooms by manager.
        public System.Collections.ArrayList showBillByManager(string managerIDInput)
        {
            ArrayList billList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Bill WHERE managerID='" + managerIDInput + "'", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                billList.Add(new Bill(Convert.ToInt32(data[0]), data[1].ToString(), data[2].ToString(), Convert.ToInt32(data[3]), Convert.ToDouble(data[4]), data[5].ToString()));
            }
            return billList;
        }

        // Data Access Object for showing rooms by room.
        public System.Collections.ArrayList showBillByRoom(int roomIDInput)
        {
            ArrayList billList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Bill WHERE roomID=" + roomIDInput + "", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                billList.Add(new Bill(Convert.ToInt32(data[0]), data[1].ToString(), data[2].ToString(), Convert.ToInt32(data[3]), Convert.ToDouble(data[4]), data[5].ToString()));
            }
            return billList;
        }

        // Data Access Object for showing rooms by price.
        public System.Collections.ArrayList showBillByPrice(double priceInput)
        {
            ArrayList billList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Bill WHERE price=" + priceInput + "", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                billList.Add(new Bill(Convert.ToInt32(data[0]), data[1].ToString(), data[2].ToString(), Convert.ToInt32(data[3]), Convert.ToDouble(data[4]), data[5].ToString()));
            }
            return billList;
        }

        // Data Access Object for showing rooms by date.
        public System.Collections.ArrayList showBillByDate(string dateInput)
        {
            ArrayList billList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Bill WHERE billDate='" + dateInput + "'", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                billList.Add(new Bill(Convert.ToInt32(data[0]), data[1].ToString(), data[2].ToString(), Convert.ToInt32(data[3]), Convert.ToDouble(data[4]), data[5].ToString()));
            }
            return billList;
        }

        // Data Access Object for showing rooms by bill id.
        public System.Collections.ArrayList showBillByBillID(int billIDInput)
        {
            ArrayList billList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Bill WHERE billID=" + billIDInput + "", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                billList.Add(new Bill(Convert.ToInt32(data[0]), data[1].ToString(), data[2].ToString(), Convert.ToInt32(data[3]), Convert.ToDouble(data[4]), data[5].ToString()));
            }
            return billList;
        }

        // Data Access Object for creating bills.
        public void createBill(Bill billInput)
        {
            (new MySqlCommand("insert into Bill (customerID,managerID,roomID,price,billDate) values ('" + billInput.CustomerID + "','" + billInput.ManagerID + "'," + billInput.RoomID + "," + billInput.Price + ",'" + billInput.BillDate + "')", (new databaseConnection()).connection())).ExecuteNonQuery();
        }
    }
}
