using HotelReservationSystem.DataAccessLayer;
using HotelReservationSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Service
{
    class managerService
    {
        // Service for showing all managers.
        public System.Collections.ArrayList showManagers()
        {
            return (new managerDAO()).showManagers();
        }

        // Service for showing spesific manager.
        public System.Collections.ArrayList showManagerSpecifically(string managerIDInput)
        {
            return (new managerDAO()).showManagerSpecifically(managerIDInput);
        }

        // Service for signing as manager.
        public System.Collections.ArrayList loginAsManager(string managerIDInput)
        {
           return (new managerDAO()).loginAsManager(new Manager(managerIDInput,"in"));
        }

        // Service for reseting password.
        public System.Collections.ArrayList resetPassword(string resetIDInput, string newPasswordInput)
        {
            return (new managerDAO()).resetPassword(new Manager(resetIDInput,"null",newPasswordInput));
        }

        // Service for showing current user.
        public System.Collections.ArrayList managerInformations(string statusInput)
        {
            return (new managerDAO()).managerInformations(statusInput);
        }

        // Service for signing out.
        public System.Collections.ArrayList signOut()
        {
            return (new managerDAO()).signOut();
        }

        // Service for creating managers.
        public void createManager(string idInput, string nameInput, string surnameInput, string phoneNumberInput, string positionInput, string passwordInput, string keywordInput, int accessLevelInput)
        {
            (new managerDAO()).createManager(new Manager(idInput,nameInput,surnameInput,phoneNumberInput,positionInput,passwordInput,keywordInput,"out",accessLevelInput));
        }

        // Service for editing managers.
        public void editManager(string idInput, string nameInput, string surnameInput, string phoneNumberInput, string positionInput, string passwordInput, string keywordInput, int accessLevelInput)
        {
            (new managerDAO()).editManager(new Manager(idInput, nameInput, surnameInput, phoneNumberInput, positionInput, passwordInput, keywordInput, accessLevelInput));
        }

        // Service for deleting managers.
        public void deleteManager(string idInput)
        {
            (new managerDAO()).deleteManager(new Manager(idInput));
        } 
    }
}
