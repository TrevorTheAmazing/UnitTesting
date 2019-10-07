using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.Game;
using LemonadeStand.ClassFiles.PlayerItems;
using LemonadeStand.ClassFiles.Items;

namespace LemonadeStand.ClassFiles.Game.Store
{
    public class Store
    {
        //memb vars
        Player player;
        public Inventory inventory;

        //constructor
        public Store(Player player)
        {
            this.player = player;
        }

        //memb meths       
        public Player GoToTheStore()
        {
            bool leaveStore = false;
            Console.Clear();
            do
            {
                double tempMoney = player.wallet.CountMoney();
                //do Store things
                Console.WriteLine("You appear at the store.");
                Console.WriteLine("");
                Console.WriteLine("You have $" + tempMoney.ToString() + " money.");
                Console.WriteLine("");

                //INVENTORY REPORT HERE
                player.inventory.InventoryReport();
                

                Lemon tempLemon = new Lemon();
                Console.WriteLine("0 - Buy lemons for $" + tempLemon.itemPrice.ToString() + ".");
                SugarCube tempSugarCube = new SugarCube();
                Console.WriteLine("1 - Buy sugar cubes for $" + tempSugarCube.itemPrice.ToString() + ".");
                IceCube tempIceCube = new IceCube();
                Console.WriteLine("2 - Buy ice cubes for $" + tempIceCube.itemPrice.ToString() + ".");
                Cup tempCup = new Cup();
                Console.WriteLine("3 - Buy cups for $" + tempCup.itemPrice.ToString() + ".");
                Console.WriteLine("");
                Console.WriteLine("9 - Purchase nothing more.  Leave the store.");
                Console.WriteLine("");
                Console.WriteLine("");

                player.RecipeReport();
                Console.WriteLine("What would you like to purchase from the store?");

                //get user's selection
                string tempInputItem = "";
                try
                {
                    tempInputItem = Console.ReadLine();
                }
                catch (Exception)
                {
                    tempInputItem = "9";
                }

                int tempInputQuantity = 0;

                if (!(tempInputItem == "9"))
                {
                    Console.WriteLine("");
                    Console.WriteLine("How many?");

                    //get user's selection
                    try
                    {
                        tempInputQuantity = Int32.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        tempInputQuantity = 0;
                    }
                }
                else
                {
                    leaveStore = true;
                }

                //find the item the player wants to buy in the list
                switch (tempInputItem)
                {
                    //add tempInput
                    case ("0"):
                        SellStuff("lemon", tempInputQuantity);
                        break;
                    case ("1"):
                        SellStuff("sugarCube", tempInputQuantity);
                        break;
                    case ("2"):
                        SellStuff("iceCube", tempInputQuantity);
                        break;
                    case ("3"):
                        SellStuff("cup", tempInputQuantity);
                        break;
                    case ("9"):
                        leaveStore = true;
                        break;
                    default:
                        break;
                }
                
                if (leaveStore)
                {
                    LeaveTheStore();
                }
            } while (!leaveStore);            
            return player;
        }

        private void SellStuff(string itemToSell, int quantity)
        {
            switch (itemToSell)
            {
                case "lemon":
                    Lemon tempLemon = new Lemon();
                    if (player.wallet.Money >= tempLemon.itemPrice)
                    {
                        player.wallet.AdjustMoney(false, (tempLemon.itemPrice * quantity));
                        for (int i = 0; i < quantity; i++)
                        {
                            player.inventory.lemons.Add(tempLemon);
                        }
                        
                        Console.WriteLine("You bought " + quantity + " 'lemon.'");
                    }
                    break;
                case "sugarCube":
                    SugarCube tempSugarCube = new SugarCube();
                    if (player.wallet.Money >= tempSugarCube.itemPrice)
                    {
                        player.wallet.AdjustMoney(false, (tempSugarCube.itemPrice * quantity));
                        for (int i = 0; i < quantity; i++)
                        {
                            player.inventory.sugarCubes.Add(tempSugarCube);
                        }
                        Console.WriteLine("You bought " + quantity + " 'sugar cube.'");
                    }
                    break;
                case "iceCube":
                    IceCube tempIceCube = new IceCube();
                    if (player.wallet.Money >= tempIceCube.itemPrice)
                    {
                        player.wallet.AdjustMoney(false, (tempIceCube.itemPrice * quantity));
                        for (int i = 0; i < quantity; i++)
                        {
                            player.inventory.iceCubes.Add(tempIceCube);
                        }
                        Console.WriteLine("You bought " + quantity + " 'ice cube.'");
                    }
                    break;
                case "cup":
                    Cup tempCup = new Cup();
                    if (player.wallet.Money >= tempCup.itemPrice)
                    {
                        player.wallet.AdjustMoney(false, (tempCup.itemPrice * quantity));
                        for (int i = 0; i < quantity; i++)
                        {
                            player.inventory.cups.Add(tempCup);
                        }
                        Console.WriteLine("You bought " + quantity + " 'cup.'");
                    }
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }//end SellStuff

        private void LeaveTheStore()
        {
            Console.WriteLine("");
            Console.WriteLine("");

            if (Validation.GetUserInput("Would you like to set or change your recipe?", "str") == "y")
                {
                    player.SetRecipe();
                }

                Console.WriteLine("");
            

            
            if (Validation.GetUserInput("Would you like to set or change the price per cup?", "str") == "y")
                {
                    player.SetPricePerCup();
                }

            Console.WriteLine("");  
        }
    }
}
