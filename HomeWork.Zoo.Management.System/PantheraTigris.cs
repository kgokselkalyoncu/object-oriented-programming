using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork.Zoo.Management.System
{
    public class PantheraTigris : Felidae
    {
        public override double getDosage()
        {
            return 125;
        }

        public override int getFeedSchedule()
        {
            return 16;
        }
    }
}