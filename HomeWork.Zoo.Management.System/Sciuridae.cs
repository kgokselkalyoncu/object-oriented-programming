using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork.Zoo.Management.System
{
    public class Sciuridae : Rodentia
    {
        public override double getDosage()
        {
            return 175;
        }

        public override int getFeedSchedule()
        {
            return 14;
        }
    }
}