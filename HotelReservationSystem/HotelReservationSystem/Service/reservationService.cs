using HotelReservationSystem.DataAccessLayer;
using HotelReservationSystem.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Service
{
    class reservationService
    {
        // Service for showing all reservations.
        public System.Collections.ArrayList showReservation()
        {
            return (new reservationDAO()).showReservation();
        }

        // Service for showing spesific reservations.
        public System.Collections.ArrayList showReservationSpecifically(string customerIDInput)
        {
            return (new reservationDAO()).showReservationSpecifically(customerIDInput);
        }

        // Service for showing spesific rooms.
        public System.Collections.ArrayList showRoomSpecifically(string roomTypeInput)
        {
            return (new reservationDAO()).showRoomSpecifically(roomTypeInput);
        }

        // Service for creating reservation.
        public void createReservation(string customerIDInput, string managerIDInput , int roomIDInput, string startDateInput, string endDateInput)
        {
            (new reservationDAO()).createReservation(new Reservation(customerIDInput,managerIDInput,roomIDInput,startDateInput,endDateInput));
        }

        // Service for editing reservation
        public void editReservation(int reservationIDInput, string startDateInput, string endDateInput)
        {
            (new reservationDAO()).editReservation(new Reservation(reservationIDInput,startDateInput,endDateInput));
        }

        // Service for deleting reservation
        public void deleteReservation(int reservationIDInput)
        {
            (new reservationDAO()).deleteReservation(new Reservation(reservationIDInput));
        }
    }
}
