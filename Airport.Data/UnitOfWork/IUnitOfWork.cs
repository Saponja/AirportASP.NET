using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IRepositoryAirplane Airplane { get; set; }
        public IRepositoryPassanger Passanger { get; set; }
        public IRepositoryReservation Reservation { get; set; }
        public IRepositoryFlight Flight { get; set; }

        public IRepositorySeat Seat { get; set; }

        void Commit();
    }
}
