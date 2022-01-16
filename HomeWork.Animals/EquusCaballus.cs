using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Animals
{
    public class EquusCaballus : Equidae
    {
        public override double getDosage()
        {
            return 25;
        }

        public override int getFeedSchedule()
        {
            return 6;
        }
    }
}
