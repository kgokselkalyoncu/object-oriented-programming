using HomeWork.Flight.Management.System.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Flight.Management.System.Pilot
{
    public class Pilot
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

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        private int experienceLevel;

        public int ExperienceLevel
        {
            get { return experienceLevel; }
            set { experienceLevel = value; }
        }

        private PilotType type;

        public PilotType Type
        {
            get { return type; }
            set { type = value; }
        }

    }
}
