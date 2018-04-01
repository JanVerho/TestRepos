using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestRepos
{
    class Program
    {
        static void Main(string[] args)
        {
            int intGetal = 15;
            Auto mijnAuto = new Auto();
            mijnAuto.Model = "Golf";
            mijnAuto.Nummerplaat = 116119;
            mijnAuto.Merk = "VW";

            Auto mijnCar = new Auto() { Model = "Golf", Merk = "VW", Nummerplaat = 116119 };
            Console.WriteLine(intGetal.ToString());
            Console.WriteLine(mijnAuto.ToString());
            Console.WriteLine(mijnCar.ToString());
            //mijnCar = null;

            if (mijnAuto.Equals(mijnCar))
            {
                Console.WriteLine("het gaat over dezelfde auto");
                Console.WriteLine(mijnAuto.ToString()+" versus " + mijnCar);
            }

            else
            {
                Console.WriteLine("volgens de huidige conditie is er een verschil.");
                Console.WriteLine(mijnAuto + " versus " + mijnCar);
            }

            //Tel equals voorbeeld uitgewerkt met verschil tss value en reference equal!!!
            //http://www.loganfranken.com/blog/687/overriding-equals-in-c-part-1/

            PhoneNumber numberA = new PhoneNumber() { AreaCode = "123", Exchange = "456", SubscriberNumber = "7890" };
            PhoneNumber numberB = numberA; // copy by reference
            numberB.Exchange = "000";
            PhoneNumber numberC = new PhoneNumber { AreaCode = "123", Exchange = "456", SubscriberNumber = "7890" };
            PhoneNumber numberD = new PhoneNumber { AreaCode = "123", Exchange = "456", SubscriberNumber = "7890" };
            //numberD.SubscriberNumber = ("0000");
            //numberD = null;

            // Equality checks fail because these are two different objects
            // But these are the *same* phone numbers as far as we're concerned
            Console.WriteLine("\n");

            if (numberA.Equals(numberB)) // check value equal
            //if (Object.ReferenceEquals(numberA, numberB)) // check ref equal

            {
                Console.WriteLine("Gelijk");
            }
            else
            {
                Console.WriteLine("Verschil");
            }
            Console.WriteLine(numberB.ToString() + " " + numberA.ToString());

            try
            {
                if (Object.ReferenceEquals(numberC, numberD))
                    //if (numberC.AreaCode.Equals(numberD.AreaCode))
                    //if (numberC.Equals(mijnAuto))
                    //if (numberC.Equals(numberD))
                {
                    Console.WriteLine("Gelijk");
                }
                else
                {
                    Console.WriteLine("Verschil");
                }
                Console.WriteLine(numberC.ToString() + " " + numberD.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Fout in code object waarde= 'null' ???");
            }

            Console.ReadKey(); //to stop the application
        }
    }
}
