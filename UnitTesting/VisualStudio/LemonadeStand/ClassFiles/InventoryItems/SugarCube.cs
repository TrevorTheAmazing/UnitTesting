using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand.ClassFiles.Items
{
    public class SugarCube : Item
    {
        //memb vars FOR SugarCube    
        public double itemPrice;

        //constructor FOR SugarCube
        public SugarCube()
        {
            this.name = "SugarCube";
            this.quantity = 1;

            this.itemPrice = 1.50;
        }

        //memb meth FOR SugarCube
    }
}
