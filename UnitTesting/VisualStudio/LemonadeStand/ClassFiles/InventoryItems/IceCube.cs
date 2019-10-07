using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand.ClassFiles.Items
{
    public class IceCube : Item
    {
        //memb vars FOR IceCube   
        public double itemPrice;

        //constructor FOR ICECUBE
        public IceCube()
        {
            this.name = "IceCube";
            this.quantity = 1;

            this.itemPrice = 0.25;
        }

        //memb meth FOR ICECUBE
    }
}
