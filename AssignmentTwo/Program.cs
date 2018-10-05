using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class CreditCardValidation
    {

        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a Credit Card Number: ");
                String input = Console.ReadLine();
                if (input.Length >= 13 && input.Length <= 16)
                {
                    if (CreditCard.IsValid(input) == true)
                    {
                        if (CreditCard.StartsWith(input, "4"))
                        {
                            Console.WriteLine(input + " is a Valid Visa Card.");
                        }
                        else if (CreditCard.StartsWith(input, "5"))
                        {
                            Console.WriteLine(input + " is a Valid Master Card.");
                        }
                        else if (CreditCard.StartsWith(input, "37"))
                        {
                            Console.WriteLine(input + " is a Valid American Express Card.");
                        }
                        else if (CreditCard.StartsWith(input, "6"))
                        {
                            Console.WriteLine(input + " is a Valid Discover Card.");
                        }
                    }
                    else
                    {
                        Console.WriteLine(input + " is an Invalid Card Number.");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Card Number!!");
                }   
            }while(true);          
        }
    }
}
