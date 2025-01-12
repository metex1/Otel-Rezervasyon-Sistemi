using HotelReservationSystem.DataAccessLayer;
using HotelReservationSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Service
{
    public class billService
    {
        // Service for showing all bills.
        public System.Collections.ArrayList showBill()
        {
            return (new billDAO()).showBill();
        }

        // Service for showing bills by customer.
        public System.Collections.ArrayList showBillByCustomer(string customerIDInput)
        {
            return (new billDAO()).showBillByCustomer(customerIDInput);
        }

        // Service for showing bills by manager.
        public System.Collections.ArrayList showBillByManager(string managerIDInput)
        {
            return (new billDAO()).showBillByManager(managerIDInput);
        }

        // Service for showing bills by room.
        public System.Collections.ArrayList showBillByRoom(int roomIDInput)
        {
            return (new billDAO()).showBillByRoom(roomIDInput);
        }

        // Service for showing bills by price.
        public System.Collections.ArrayList showBillByPrice(double priceInput)
        {
            return (new billDAO()).showBillByPrice(priceInput);
        }

        // Service for showing bills by date.
        public System.Collections.ArrayList showBillByDate(string dateInput)
        {
            return (new billDAO()).showBillByDate(dateInput);
        }

        // Service for showing bills by bill id.
        public System.Collections.ArrayList showBillByBillID(int billIDInput)
        {
            return (new billDAO()).showBillByBillID(billIDInput);
        }

        // Service for creating bills.
        public void createBill(string customerIDInput, string managerIDInput, int roomIDInput, double priceInput, string billDateInput)
        {
            (new billDAO()).createBill(new Bill(customerIDInput,managerIDInput,roomIDInput,priceInput,billDateInput));
        } 
    }
}
