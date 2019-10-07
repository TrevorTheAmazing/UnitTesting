using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.Game;

namespace LemonadeStand.ClassFiles.Game.Day
{
    class Day
    {
        //memb vars
        public Weather weather;
        public List<Customer> customers;
        public double timeRemaining;
        private int customerCount = 100;

        //constructor
        public Day(Random randomIn)
        {
            //set the weather for the day
            weather = new Weather(randomIn);

            //set play time remaining for the day
            //timeRemaining = 100.0;

            if (weather.happinessIndex > 80)
            {
                customerCount += (customerCount / 2);
            }
            else if (weather.happinessIndex > 70)
            {
                customerCount += (customerCount / 3);
            }
            else if (weather.happinessIndex > 60)
            {
                customerCount += (customerCount / 4);
            }

            customers = new List<Customer>();

            //add 100 customers to the list each day
            customers = BuildDailyCustomerList( customers, customerCount, randomIn);
            //day complete.
        }

        //memb meths
        public List<Customer> BuildDailyCustomerList( List<Customer> customersIn, int customerCountIn, Random randomIn)
        {
            //create a new customer and name it            
            for (int i = 0; i < customerCountIn; i++)
            {
                Customer tempCustomer = new Customer(randomIn);

                tempCustomer.name += i;
                customersIn.Add(tempCustomer);                
            }
            
            return customersIn;
        }
    }
}
