using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Domain
{
    public class Customer
    {
        private string id , name , surname , phoneNumber;

        // Creating & Editing & Showing Customer
        public Customer(string idInput , string nameInput , string surnameInput , string phoneNumberInput)
        {
            this.id = idInput;
            this.name = nameInput;
            this.surname = surnameInput;
            this.phoneNumber = phoneNumberInput;
        }

        // Deleting Customer
        public Customer(string idInput)
        {
            this.id = idInput;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public override string ToString()
        {
            return ID;
        }
    }
}
