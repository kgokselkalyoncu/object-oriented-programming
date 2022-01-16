using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Flight.Management.System.Flight
{
    public class Flight
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
            
        public virtual Airport.Airport DepartureAirport { get; set; }

        public virtual Airport.Airport ArrivalAirport { get; set; }

        private DateTime departureDate;

        public DateTime DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }

        private DateTime arrivalDate;

        public DateTime ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }

    }
}
