using HotelReservationSystem.Domain;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.DataAccessLayer
{
    class managerDAO
    {

        // Data Access Object for showing all managers.
        public System.Collections.ArrayList showManagers()
        {
            ArrayList managerList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Manager", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                managerList.Add(new Manager(data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(), data[5].ToString(), data[6].ToString(), data[7].ToString(), Convert.ToInt32(data[8])));
            }
            return managerList;
        }

        // Data Access Object for showing spesific manager.
        public System.Collections.ArrayList showManagerSpecifically(string managerIDInput)
        {
            ArrayList managerList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Manager WHERE managerID='" + managerIDInput + "'", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                managerList.Add(new Manager(data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(), data[5].ToString(), data[6].ToString(), data[7].ToString(), Convert.ToInt32(data[8])));
            }
            return managerList;
        }

        // Data Access Object for login as manager.
        public System.Collections.ArrayList loginAsManager(Manager managerInput)
        {
            ArrayList managerList = new ArrayList();
            (new MySqlCommand("UPDATE Manager SET status='" + managerInput.Status + "' WHERE managerID='" + managerInput.ID + "'", (new databaseConnection()).connection())).ExecuteNonQuery();
            MySqlDataReader data = (new MySqlCommand("select * from Manager WHERE managerID='" + managerInput.ID + "'", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                managerList.Add(new Manager(data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(), data[5].ToString(), data[6].ToString(), data[7].ToString(), Convert.ToInt32(data[8])));
            }
            return managerList;
        }

        // Data Access Object for resetting password.
        public System.Collections.ArrayList resetPassword(Manager managerInput)
        {
            ArrayList managerList = new ArrayList();
            (new MySqlCommand("UPDATE Manager SET password='" + managerInput.Password + "'", (new databaseConnection()).connection())).ExecuteNonQuery();
            MySqlDataReader data = (new MySqlCommand("select * from Manager WHERE managerID='" + managerInput.ID + "'", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                managerList.Add(new Manager(data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(), data[5].ToString(), data[6].ToString(), data[7].ToString(), Convert.ToInt32(data[8])));
            }
            return managerList;
        }

        // Data Access Object for showing the current user.
        public System.Collections.ArrayList managerInformations(string statusInput)
        {
            ArrayList managerList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Manager WHERE status='" + statusInput + "'" , (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                managerList.Add(new Manager(data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(), data[5].ToString(), data[6].ToString(), data[7].ToString(), Convert.ToInt32(data[8])));
            }
            return managerList;
        }

        // Data Access Object for signing out.
        public System.Collections.ArrayList signOut()
        {
            ArrayList managerList = new ArrayList();
            (new MySqlCommand("UPDATE Manager SET status='out'", (new databaseConnection()).connection())).ExecuteNonQuery();
            MySqlDataReader data = (new MySqlCommand("select * from Manager", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                managerList.Add(new Manager(data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(), data[5].ToString(), data[6].ToString(), data[7].ToString(), Convert.ToInt32(data[8])));
            }
            return managerList;
        }

        // Data Access Object for creating manager.
        public void createManager(Manager managerInput)
        {
            (new MySqlCommand("insert into Manager (managerID,name,surname,phoneNumber,position,password,keyword,status,accessLevel) values ('" + managerInput.ID + "','" + managerInput.Name + "','" + managerInput.Surname + "','" + managerInput.PhoneNumber + "','" + managerInput.Position + "','" + managerInput.Password + "','" + managerInput.Keyword + "','" + managerInput.Status + "'," + managerInput.AccessLevel + ")" , (new databaseConnection()).connection())).ExecuteNonQuery();
        }

        // Data Access Object for editing manager.
        public void editManager(Manager managerInput)
        {
            (new MySqlCommand("UPDATE Manager SET name='" + managerInput.Name + "', surname='" + managerInput.Surname + "', phoneNumber='" + managerInput.PhoneNumber + "', position='" + managerInput.Position + "', password='" + managerInput.Password + "', keyword='" + managerInput.Keyword + "', accessLevel=" + managerInput.AccessLevel + " WHERE managerID='" + managerInput.ID + "'", (new databaseConnection()).connection())).ExecuteNonQuery();
        }

        // Data Access Object for deleting manager.
        public void deleteManager(Manager managerInput)
        {
            (new MySqlCommand("DELETE FROM Manager WHERE managerID='" + managerInput.ID + "'" , (new databaseConnection()).connection())).ExecuteNonQuery();
        }
    }
}
