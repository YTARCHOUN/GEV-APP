using System;
using VehicleMaintenance.Domain.Customers;
using VehicleMaintenance.Domain.Reservations;
using VehicleMaintenance.Domain.Vehicles;
using VehicleMaintenance.Domain.Workshops;

namespace VehicleMaintenance.Application.Reservations.Commands.CreateReservation.Factory
{
    public interface IReservationFactory
    {
        Reservation Create(DateTime datetime, Customer customer, Vehicle vehicle, Workshop workshop);
    }
}
