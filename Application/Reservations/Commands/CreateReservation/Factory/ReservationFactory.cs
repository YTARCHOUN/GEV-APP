using System;
using VehicleMaintenance.Domain.Customers;
using VehicleMaintenance.Domain.Reservations;
using VehicleMaintenance.Domain.Vehicles;
using VehicleMaintenance.Domain.Workshops;

namespace VehicleMaintenance.Application.Reservations.Commands.CreateReservation.Factory
{
    public class ReservationFactory : IReservationFactory
    {
        public Reservation Create(DateTime datetime, Customer customer, Vehicle vehicle, Workshop workshop)
        {
            var reservation = new Reservation();

            reservation.DateTime = datetime;

            reservation.Customer = customer;

            reservation.Vehicle = vehicle;

            reservation.Workshop = workshop;

            reservation.Status = Reservation.CREATED;

            return reservation;
        }
    }
}
