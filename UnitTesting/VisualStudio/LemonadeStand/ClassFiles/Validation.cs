using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.ClassFiles
{
    public static class Validation
    {
        //memb vars

        //constr?
        

        //memb meth
        public static string GetUserInput(string message, string ValidationType)
        {
            bool inputIsValid = false;
            do
            {
                Console.WriteLine(message);

                switch (ValidationType)
                {
                    case "int":
                        string tempInt = Console.ReadLine();
                        if (ValidInt(tempInt))
                        {
                            inputIsValid = true;
                            return tempInt;
                        }
                        else
                        {
                            GetUserInput(message, "int");
                            return "";
                        }
                    case "bool":
                        Console.WriteLine(Environment.NewLine + "1 = 'Yes'" + Environment.NewLine + "0 = 'No'");
                        string tempBool = Console.ReadLine();
                        if (ValidBool(tempBool))
                        {
                            inputIsValid = true;
                            return tempBool;
                        }
                        else
                        {
                            GetUserInput(message, "bool");
                            return "";
                        }
                    case "str":
                        try
                        {
                            string tempStr = Console.ReadLine();
                            if (ValidStr(tempStr))
                            {
                                inputIsValid = true;
                                return tempStr;
                            }
                            else
                            {
                                GetUserInput(message, "str");
                                return "";
                            }
                        }
                        catch (NullReferenceException)
                        {
                            GetUserInput(message, "str");
                            return "";
                        }
                    //return ValidStr(Console.ReadLine());
                    default:
                        return "";
                }
            } while (!inputIsValid);
        }

        private static bool ValidStr(string Input)
        {
            bool tempResult = false;
            try
            {
                if (!string.IsNullOrEmpty(Input))
                {
                    string tempString = Input.ToLower();
                    //bool tempResult = true;
                    tempResult = true;
                    for (int i = 0; i < Input.Length; i++)
                    {
                        foreach (char asciiChar in Input.ToCharArray())
                        {
                            //if (!(asciiChar > 96 && asciiChar < 123))
                            if (!(asciiChar > 32 && asciiChar < 127))
                            {
                                tempResult = false;
                                break;
                            }
                        }
                    }
                }
            }
            catch(Exception)
            {
                tempResult = false;
            }

            return tempResult;
        }

        private static bool ValidInt(string Input)
        {
            bool tempResult = true;
            for (int i = 0; i < Input.Length; i++)
            {
                foreach (char asciiChar in Input.ToCharArray())
                {
                    if (!(asciiChar > 47 && asciiChar < 58))
                    {
                        tempResult = false;
                        break;
                    }
                }
            }
            return tempResult;
        }

        private static bool ValidBool(string Input)
        {
            bool tempResult = true;
            for (int i = 0; i < Input.Length; i++)
            {
                foreach (char asciiChar in Input.ToCharArray())
                {
                    if (!(asciiChar > 47 && asciiChar < 50))
                    {
                        tempResult = false;
                        break;
                    }
                }
            }
            return tempResult;
        }



   
    }
}
