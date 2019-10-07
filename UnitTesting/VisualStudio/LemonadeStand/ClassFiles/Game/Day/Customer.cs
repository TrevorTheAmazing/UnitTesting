using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.PlayerItems;

namespace LemonadeStand.ClassFiles.Game.Day
{
    class Customer
    {        
        //memb vars
        //private List<string> names = new List<string>();
        public string name;
        public bool willPurchase;
        public int internalResistance;
        public double maxPurchasePrice;
        public Recipe customerPreferences;
        //Random random = new Random();

        //constructor
        public Customer(Random randomIn)
        {
            
            this.name = "Customer";
            this.willPurchase = ((randomIn.Next(0, 101)) >= 30);
            this.maxPurchasePrice = ((randomIn.NextDouble() * (8.0 - 1.0)) + 1.0);
            this.internalResistance = randomIn.Next(0, 40);

            this.customerPreferences = new Recipe();
            customerPreferences.amountOfLemons = randomIn.Next(0, 4);
            customerPreferences.amountOfSugarCubes = randomIn.Next(0, 4);
            customerPreferences.amountOfIceCubes = randomIn.Next(0, 4);
            customerPreferences.pricePerCup = 0.0;
        }

        

        //memb meths
    }
}
