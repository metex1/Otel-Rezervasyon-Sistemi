using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelReservationSystem.Domain;
using MySql;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelReservationSystem.DataAccessLayer
{
    class reservationDAO
    {
        // Data Access Object for showing all reservations.
        public System.Collections.ArrayList showReservation()
        {
            ArrayList reservationList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Reservation", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                reservationList.Add(new Reservation(Convert.ToInt32(data[0]), data[1].ToString(), data[2].ToString(), Convert.ToInt32(data[3]), data[4].ToString(), data[5].ToString()));
            }
            return reservationList;
        }

        // Data Access Object for showing spesific reservations.
        public System.Collections.ArrayList showReservationSpecifically(string customerIDInput)
        {
            ArrayList reservationList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select * from Reservation WHERE customerID='" + customerIDInput + "'", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                reservationList.Add(new Reservation(Convert.ToInt32(data[0]), data[1].ToString(), data[2].ToString(), Convert.ToInt32(data[3]), data[4].ToString(), data[5].ToString()));
            } 
            return reservationList;
        }

        // Data Access Object for showing spesific rooms.
        public System.Collections.ArrayList showRoomSpecifically(string roomTypeInput)
        {
            ArrayList roomList = new ArrayList();
            MySqlDataReader data = (new MySqlCommand("select roomID,roomName,roomStatus from Room WHERE roomType='" + roomTypeInput + "'", (new databaseConnection()).connection())).ExecuteReader();
            while (data.Read())
            {
                roomList.Add(new Room(Convert.ToInt32(data[0]), data[1].ToString(), data[2].ToString()));
            }
            return roomList;
        }

        // Data Access Object for creating reservation.
        public void createReservation(Reservation reservationInput)
        {
            (new MySqlCommand("insert into Reservation (customerID,managerID,roomID,reservationStarts,reservationEnds) values ('" + reservationInput.CustomerID + "','" + reservationInput.ManagerID + "'," + reservationInput.RoomID + ",'" + reservationInput.ReservationStarts + "','" + reservationInput.ReservationEnds + "')", (new databaseConnection()).connection())).ExecuteNonQuery();
        }

        // Data Access Object for editing reservation.
        public void editReservation(Reservation reservationInput)
        {
            (new MySqlCommand("UPDATE Reservation SET reservationStarts='" + reservationInput.ReservationStarts + "', reservationEnds='" + reservationInput.ReservationEnds + "' WHERE reservationID = " + reservationInput.ReservationID + "" , (new databaseConnection()).connection())).ExecuteNonQuery();
        }

        // Data Access Object for deleting reservation.
        public void deleteReservation(Reservation reservationInput)
        {
            (new MySqlCommand("DELETE FROM Reservation WHERE reservationID=" + reservationInput.ReservationID + "" , (new databaseConnection()).connection())).ExecuteNonQuery();
        }
    }
}
