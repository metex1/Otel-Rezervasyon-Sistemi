using HotelReservationSystem.DataAccessLayer;
using HotelReservationSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Service
{
    class customerService
    {
        // Service for showing all customers.
        public System.Collections.ArrayList showCustomer()
        {
            return (new customerDAO()).showCustomer();
        }

        // Service for showing spesific customer.
        public System.Collections.ArrayList showCustomerSpecifically(string customerIDInput)
        {
            return (new customerDAO()).showCustomerSpecifically(customerIDInput);
        }

        // Service for creating customers.
        public void createCustomer(string idInput , string nameInput , string surnameInput , string phoneNumberInput)
        {
            (new customerDAO()).createCustomer(new Customer(idInput,nameInput,surnameInput,phoneNumberInput));
        }

        // Service for editing customers.
        public void editCustomer(string idInput, string nameInput, string surnameInput, string phoneNumberInput)
        {
            (new customerDAO()).editCustomer(new Customer(idInput,nameInput,surnameInput,phoneNumberInput));
        }

        // Service for deleting customers.
        public void deleteCustomer(string idInput)
        {
            (new customerDAO()).deleteCustomer(new Customer(idInput));
        }
    }
}
