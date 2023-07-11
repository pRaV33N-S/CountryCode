using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string countryCode;
            string lang;
            string choice;
            do 
            {
                Console.WriteLine("Enter Country Code");
                countryCode = Console.ReadLine().ToLower();
                switch (countryCode)
                {
                    case "usa":
                    case "uk":
                        {
                            lang = "English";
                            break;
                        }
                    case "af":
                        {
                            lang = "Dari, Pashto";
                            break;
                        }
                    case "in":
                        {
                            lang = "Hindi, English, Tamil, Telugu, Punjabi";
                            break;
                        }
                    case "uae":
                        {
                            lang = "Arabic";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Sorry!! Your Country {countryCode} is not in Our Database");
                            lang = "Not Found!!!";
                            break;
                        }
                }
                Console.WriteLine("Country Code: \t " + countryCode + "\n Language(s): \t" + lang);
                Console.WriteLine("Do you wanna continue if yes press y \n To exit press any key");
                choice = Console.ReadLine().ToLower();
            }
            while (choice == "y");
        }
            
        
 
    }
}
