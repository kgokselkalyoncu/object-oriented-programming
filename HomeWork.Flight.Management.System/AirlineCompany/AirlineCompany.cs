using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Flight.Management.System.AirlineCompany
{
    public class AirlineCompany
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public ICollection<Pilot.Pilot> Pilots;


        public ICollection<Aircraft.Aircraft> Aircrafts;

        public ICollection<Flight.Flight> Flights;

    }
}
