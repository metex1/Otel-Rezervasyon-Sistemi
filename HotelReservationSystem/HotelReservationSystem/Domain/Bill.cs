using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Domain
{
    public class Bill
    {
        private string customerID, managerID, billDate;
        private int billID, roomID; 
        private double price;

        // Showing Bill
        public Bill(int billIDInput , string customerIDInput , string managerIDInput , int roomIDInput , double priceInput , string billDateInput )
        {
            this.billID = billIDInput;
            this.customerID = customerIDInput;
            this.managerID = managerIDInput;
            this.roomID = roomIDInput;
            this.price = priceInput;
            this.billDate = billDateInput;
        }

        // Creating Bill
        public Bill(string customerIDInput, string managerIDInput, int roomIDInput, double priceInput, string billDateInput)
        {
            this.customerID = customerIDInput;
            this.managerID = managerIDInput;
            this.roomID = roomIDInput;
            this.price = priceInput;
            this.billDate = billDateInput;
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

        public string BillDate
        {
            get { return billDate; }
            set { billDate = value; }
        }

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
