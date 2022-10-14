using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoSwitch
{
    public class Menu
    {

        public void PrintMenu()
        {
            //Console.Clear();
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Read"); 
            Console.WriteLine("3. Update"); 
            Console.WriteLine("4. Delete");
            Console.WriteLine();
            Console.WriteLine("9. STOP");
            Console.WriteLine();

        }

        public bool ReadChoice()
        {
            Console.Write("Indtast valg : ");
            String line = Console.ReadLine();


            switch (line)
            {
                case "1":
                    Console.WriteLine("Du har valgt Create");
                    break;
                case "2":
                    Console.WriteLine("Du har valgt Read");
                    break;
                case "3":
                    Console.WriteLine("Du har valgt Update");
                    break;
                case "4":
                    Console.WriteLine("Du har valgt Delete");
                    break;
                case "9":
                    Console.WriteLine("Du har valgt at stoppe");
                    return true;
                    // break;
                default:
                    Console.WriteLine("Du skal vælge 1,2,3,4 eller 9");
                    break;
            }


            return false;

        }

    }
}
