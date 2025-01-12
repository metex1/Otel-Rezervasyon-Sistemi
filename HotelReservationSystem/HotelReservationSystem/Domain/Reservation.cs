using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelReservationSystem.Domain
{
    public class Reservation
    {
        private int reservationID , roomID;
        private string customerID , managerID , reservationStarts, reservationEnds;

        // Showing Reservation
        public Reservation(int reservationIDInput , string customerIDInput , string managerIDInput , int roomIDInput , string reservationStartsInput , string reservationEndsInput)
        {
            this.reservationID = reservationIDInput;
            this.customerID = customerIDInput;
            this.managerID = managerIDInput;
            this.roomID = roomIDInput;
            this.reservationStarts = reservationStartsInput;
            this.reservationEnds = reservationEndsInput;
        }

        // Creating Reservation
        public Reservation(string customerIDInput , string managerIDInput , int roomIDInput , string reservationStartsInput , string reservationEndsInput)
        {
            this.customerID = customerIDInput;
            this.managerID = managerIDInput;
            this.roomID = roomIDInput;
            this.reservationStarts = reservationStartsInput;
            this.reservationEnds = reservationEndsInput;
        }

        // Editing Reservation
        public Reservation(int reservationIDInput , string reservationStartsInput , string reservationEndsInput)
        {
            this.reservationID = reservationIDInput;
            this.reservationStarts = reservationStartsInput;
            this.reservationEnds = reservationEndsInput;

        }

        // Deleting Reservation
        public Reservation(int reservationIDInput)
        {
            this.reservationID = reservationIDInput;
        }

        public int ReservationID
        {
            get { return reservationID; }
        }

        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string ManagerID
        {
            get { return managerID; }
            set { managerID = value; }
        }

        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public string ReservationStarts
        {
            get { return reservationStarts; }
            set { reservationStarts = value; }
        }

        public string ReservationEnds
        {
            get { return reservationEnds; }
            set { reservationEnds = value; }
        }
    }
}
