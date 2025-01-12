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
    class roomDAO
    {
        // Data Access Object for showing rooms.
        public System.Collections.ArrayList showRoom()
        {
            ArrayList roomList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Room", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                roomList.Add(new Room(Convert.ToInt32(data[0]), data[1].ToString(), data[2].ToString(), Convert.ToDouble(data[3]), data[4].ToString()));
            }
            return roomList;
        }

        // Data Access Object for showing reserved room's price.
        public System.Collections.ArrayList priceForBill(int roomIDInput)
        {
            ArrayList roomList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Room WHERE roomID=" + roomIDInput + "", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                roomList.Add(new Room(Convert.ToInt32(data[0]), data[1].ToString(), data[2].ToString(), Convert.ToDouble(data[3]), data[4].ToString()));
            }
            return roomList;
        }

        // Data Access Object for creating rooms.
        public void createRoom(Room roomInput)
        {
            (new MySqlCommand("insert into Room (roomName,roomType,price,roomStatus) values ('" + roomInput.RoomName + "','" + roomInput.RoomType + "'," + roomInput.Price + ",'" + roomInput.RoomStatus + "')" , (new databaseConnection()).connection())).ExecuteNonQuery();
        }

        // Data Access Object for editing rooms.
        public void editRoom(Room roomInput)
        {
            (new MySqlCommand("UPDATE Room SET roomName='" + roomInput.RoomName + "', roomType='" + roomInput.RoomType + "', price=" + roomInput.Price + " WHERE roomID=" + roomInput.RoomID + "" , (new databaseConnection()).connection())).ExecuteNonQuery();
        }

        // Data Access Object for deleting rooms.
        public void deleteRoom(Room roomInput)
        {
            (new MySqlCommand("DELETE FROM Room WHERE roomID=" + roomInput.RoomID + ""  , (new databaseConnection()).connection())).ExecuteNonQuery();
        }

        // Data Access Object for making entrance to rooms.
        public void makeAnEntrance(Room roomInput)
        {
            (new MySqlCommand("UPDATE Room SET roomStatus='" + roomInput.RoomStatus + "' WHERE roomID=" + roomInput.RoomID + "", (new databaseConnection()).connection())).ExecuteNonQuery();
        }

        // Data Access Object for making exit to rooms.
        public void makeAnExit(Room roomInput) 
        {
            (new MySqlCommand("UPDATE Room SET roomStatus='" + roomInput.RoomStatus + "' WHERE roomID=" + roomInput.RoomID + "", (new databaseConnection()).connection())).ExecuteNonQuery();
        }  
    }
}
