using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.ClassFiles.PlayerItems
{
    public class Wallet
    {
        //memb vars
        public bool increase;
        public double amount;
        private double money;
        public double Money
        {
            get => CountMoney();
            set => AdjustMoney(increase, amount);
        }        

        //constructor
        public Wallet()
        {
            this.money = 50.00;
        }

        //memb meths
        //CountMoney() to get a money report
        public double CountMoney()
        {
            return money;
        }

        public double AdjustMoney(bool increase, double amount)
        {
            double tempMoney = CountMoney();
            double tempAmount = amount;

            switch (increase)
            {
                case (false):
                    //decrease money by amount
                    if (tempMoney >= tempAmount)
                    {
                        tempMoney = LessMoney(tempAmount);                        
                        return tempMoney;
                    }
                    else
                    {
                        return tempMoney;
                    }
                case (true):
                    //increase money by amount
                    tempMoney = MoreMoney(tempAmount);
                    break;
                default:                    
                    break;
            }
            return tempMoney;
        }

        private double MoreMoney(double amountIn)
        {
            return (money += amountIn);
        }

        private double LessMoney(double amountIn)
        {
            return (money -= amountIn);
        }
    }
}
