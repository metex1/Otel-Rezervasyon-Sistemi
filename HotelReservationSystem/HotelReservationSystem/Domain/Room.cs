using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelReservationSystem.Domain
{
    public class Room
    {
        private int roomID;
        private string roomName , roomType , roomStatus;
        private double price;

        // Showing Room
        public Room(int roomIdInput, string roomNameInput, string roomTypeInput, double priceInput, string roomStatusInput)
        {
            this.roomID = roomIdInput;
            this.roomName = roomNameInput;
            this.roomType = roomTypeInput;
            this.price = priceInput;
            this.roomStatus = roomStatusInput;
        }

        // Showing Spesific Room
        public Room(int roomIdInput, string roomNameInput , string roomStatusInput)
        {
            this.roomID = roomIdInput;
            this.roomName = roomNameInput;
            this.roomStatus = roomStatusInput;
        }

        // Creating Room
        public Room(string roomNameInput , string roomTypeInput , double priceInput , string roomStatusInput)
        {
            this.roomName = roomNameInput;
            this.roomType = roomTypeInput;
            this.price = priceInput;
            this.roomStatus = roomStatusInput;
        }

        // Updating Room
        public Room(int roomIdInput , string roomNameInput, string roomTypeInput, double priceInput)
        {
            this.roomID = roomIdInput;
            this.roomName = roomNameInput;
            this.roomType = roomTypeInput;
            this.price = priceInput;
        }

        // Deleting Room
        public Room(int roomIdInput)
        {
            this.roomID = roomIdInput;
        }

        // Entry & Exit to Room
        public Room(int roomIdInput , string roomStatusInput)
        {
            this.roomID = roomIdInput;
            this.roomStatus = roomStatusInput;
        }

        public int RoomID
        {
            get { return roomID; }
        }

        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }

        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }

        public string RoomStatus
        {
            get { return roomStatus; }
            set { roomStatus = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return roomID.ToString();
        }
    }
}
