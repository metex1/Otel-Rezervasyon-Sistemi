using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Domain
{
    public class Manager
    {
        private string id , name , surname , phoneNumber , position , password , keyword , status;
        private int accessLevel;

        // Creating Manager
        public Manager(string idInput , string nameInput , string surnameInput , string phoneNumberInput , string positionInput , string passwordInput , string keywordInput , string statusInput , int accessLevelInput)
        {
            this.id = idInput;
            this.name = nameInput;
            this.surname = surnameInput;
            this.phoneNumber = phoneNumberInput;
            this.position = positionInput;
            this.password = passwordInput;
            this.keyword = keywordInput;
            this.status = statusInput;
            this.accessLevel = accessLevelInput;
        }

        // Editing & Showing Manager
        public Manager(string idInput, string nameInput, string surnameInput, string phoneNumberInput, string positionInput, string passwordInput, string keywordInput, int accessLevelInput)
        {
            this.id = idInput;
            this.name = nameInput;
            this.surname = surnameInput;
            this.phoneNumber = phoneNumberInput;
            this.position = positionInput;
            this.password = passwordInput;
            this.keyword = keywordInput;
            this.accessLevel = accessLevelInput;
        }

        // Deleting Manager
        public Manager(string idInput)
        {
            this.id = idInput;
        }

        // Resetting Manager's Password
        public Manager(string idInput, string keywordInput, string passwordInput)
        {
            this.id = idInput;
            this.keyword = keywordInput;
            this.password = passwordInput;
        }

        // Signing In - Out Manager
        public Manager(string idInput , string statusInput)
        {
            this.id = idInput;
            this.status = statusInput;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
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

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Keyword
        {
            get { return keyword; }
            set { keyword = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int AccessLevel
        {
            get { return accessLevel; }
            set { accessLevel = value; }
        }
    }
}
