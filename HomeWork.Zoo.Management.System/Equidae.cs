using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork.Zoo.Management.System
{
    public class Equidae : Animal
    {
        public override double getDosage()
        {
            return 50;
        }

        public override int getFeedSchedule()
        {
            return 4;
        }
    }
}