using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork.Zoo.Management.System
{
    public class Felidae : Animal
    {
        public override double getDosage()
        {
            return 75;
        }

        public override int getFeedSchedule()
        {
            return 2;
        }
    }
}