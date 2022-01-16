using HomeWork.Flight.Management.System.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Flight.Management.System.Aircraft
{
    public class Aircraft
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

        private AircraftState state;

        public AircraftState State
        {
            get { return state; }
            set { state = value; }
        }

        private AircraftType aircraftType;

        public AircraftType AircraftType
        {
            get { return aircraftType; }
            set { aircraftType = value; }
        }

        private int pilotCount;

        public int PilotCount
        {
            get { return pilotCount; }
            set { pilotCount = value; }
        }

    }
}
