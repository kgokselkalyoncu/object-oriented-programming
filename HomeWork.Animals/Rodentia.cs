using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork.Animals
{
    public class Rodentia : Animal
    {
        public override double getDosage()
        {
            return 125;
        }

        public override int getFeedSchedule()
        {
            return 5;
        }
    }
}