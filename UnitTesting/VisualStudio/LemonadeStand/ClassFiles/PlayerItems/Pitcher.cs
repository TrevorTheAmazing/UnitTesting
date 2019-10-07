using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.ClassFiles.PlayerItems
{
    public class Pitcher
    {
        //memb vars for PITCHER
        public int maxCapacity;
        public int cupsLeftInPitcher;

        //constructor for PITCHER
        public Pitcher()
        {
            this.maxCapacity = 20;
            this.cupsLeftInPitcher = 0;
        }

        //memb methods 
        public void FillPitcher()
        {
            cupsLeftInPitcher = maxCapacity;
        }

        public bool DispenseBeverage()
        {
            if (cupsLeftInPitcher>0)
            {
                cupsLeftInPitcher--;
                return true;
            }
            else
            {
                return false;
                
            }
        }

    }
}
