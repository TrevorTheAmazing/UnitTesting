using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand.ClassFiles.Items
{
    public class Cup : Item
    {
        //memb vars FOR Cup
        public double itemPrice;

        public Cup()
        {
            this.name = "Cup";
            this.quantity = 1;
            
            this.itemPrice = 0.10;
        }

        //memb meth FOR CUP
    }
}
