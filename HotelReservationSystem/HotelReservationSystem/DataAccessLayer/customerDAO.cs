using HotelReservationSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using System.Collections;

namespace HotelReservationSystem.DataAccessLayer
{
    public class customerDAO
    {
        // Data Access Object for showing all customers.
        public System.Collections.ArrayList showCustomer()
        {
            ArrayList customerList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Customer", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                customerList.Add(new Customer(data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString()));
            }
            return customerList;
        }

        // Data Access Object for showing spesific customer.
        public System.Collections.ArrayList showCustomerSpecifically(string customerIDInput)
        {
            ArrayList customerList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Customer WHERE customerID='" + customerIDInput + "'", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                customerList.Add(new Customer(data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString()));
            }
            return customerList;
        }

        // Data Access Object for creating customers.
        public void createCustomer(Customer customerInput)
        {
            (new MySqlCommand("insert into Customer (customerID,name,surname,phoneNumber) values ('" + customerInput.ID + "','" + customerInput.Name + "','" + customerInput.Surname + "','" + customerInput.PhoneNumber + "')", (new databaseConnection()).connection())).ExecuteNonQuery();
        }

        // Data Access Object for editing customers.
        public void editCustomer(Customer customerInput)
        {
            (new MySqlCommand("UPDATE Customer SET name='" + customerInput.Name + "', surname='" + customerInput.Surname + "', phoneNumber='" + customerInput.PhoneNumber + "' WHERE customerID='" + customerInput.ID + "'" , (new databaseConnection()).connection())).ExecuteNonQuery();
        }

        // Data Access Object for deleting customers.
        public void deleteCustomer(Customer customerInput)
        {
            (new MySqlCommand("DELETE FROM Customer WHERE customerID=" + customerInput.ID + "", (new databaseConnection()).connection())).ExecuteNonQuery();
        }
    }
}
