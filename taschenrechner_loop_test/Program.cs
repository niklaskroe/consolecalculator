using System;

namespace taschenrechner_loop_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib hier die erste Zahl ein:");
                string zahl1 = Console.ReadLine();

            int zwischenergebnis = 0;
            bool firstcalc = true;


            while (true)
            {
               
                if (firstcalc == false)
                {
                    zahl1 = zwischenergebnis.ToString();
                }

                Console.WriteLine("Gib hier den Operator ein:");
                string rechenoperator = Console.ReadLine();

                if (rechenoperator == "e")
                {
                    break;
                }

                Console.WriteLine("Gib hier die zweite Zahl ein:");
                string zahl2 = Console.ReadLine();

                int ergebnis = 0;
                
                if (rechenoperator == "+")
                {
                    ergebnis = int.Parse(zahl1) + int.Parse(zahl2);
                }
                else if (rechenoperator == "-")
                {
                    ergebnis = int.Parse(zahl1) - int.Parse(zahl2);
                }
                else if (rechenoperator == "*")
                {
                    ergebnis = int.Parse(zahl1) * int.Parse(zahl2);
                }
                else if (rechenoperator == "/")
                {
                    if (zahl2 == "0")
                    {
                        Console.WriteLine("ERROR: Durch 0 kann nicht geteilt werden!");
                    }
                    else
                    {
                        ergebnis = int.Parse(zahl1) / int.Parse(zahl2);
                    }

                }

                

                zwischenergebnis = ergebnis;
                firstcalc = false;

                Console.WriteLine("Ergibt:" + ergebnis);
            }

            
            
        }
    }
}
