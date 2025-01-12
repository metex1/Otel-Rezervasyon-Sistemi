using HotelReservationSystem.DataAccessLayer;
using HotelReservationSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Service
{
    class roomService
    {
        // Service for showing rooms.
        public System.Collections.ArrayList showRoom()
        {
            return (new roomDAO()).showRoom();
        }

        // Service for showing reserved room's price.
        public System.Collections.ArrayList priceForBill(int roomIDInput)
        {
            return (new roomDAO()).priceForBill(roomIDInput);
        }

        // Service for creating rooms.
        public void createRoom(string roomNameInput , string roomTypeInput , double priceInput)
        {
            (new roomDAO()).createRoom(new Room(roomNameInput,roomTypeInput,priceInput, "Boş"));
        }

        // Service for editing rooms.
        public void editRoom(int roomIdInput , string roomNameInput , string roomTypeInput , double priceInput)
        {
            (new roomDAO()).editRoom(new Room(roomIdInput,roomNameInput,roomTypeInput,priceInput));
        }

        // Service for deleting rooms.
        public void deleteRoom(int roomIdInput)
        {
            (new roomDAO()).deleteRoom(new Room(roomIdInput));
        }

        // Service for making entrance to rooms.
        public void makeAnEntrance(int roomIdInput)
        {
            (new roomDAO()).makeAnEntrance(new Room(roomIdInput,"Dolu"));
        }

        // Service for making exit to rooms.
        public void makeAnExit(int roomIdInput)
        {
            (new roomDAO()).makeAnExit(new Room(roomIdInput,"Boş"));
        }  
    }
}
