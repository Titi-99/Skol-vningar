using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skol_övningar
{
    internal class Application
    {        
            public void Run()
            {
            //Lab 4 Loopar:
            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());

            int y = 0;
            while (y < x)
            {
                Console.WriteLine($"You entered {x}");

            }




//----------------------------------------------------------------------------------           
            
            //Lab 3 Loopar:

           /*Console.WriteLine("1. Simple math. ");
            Console.WriteLine("2. Close app? ");
            string choice = Console.ReadLine();

            while (choice != "2")
            {
                
                    Console.Write("Enter a number: ");
                    int x = int.Parse(Console.ReadLine());

                    Console.Write("Enter a number again: ");
                    int y = int.Parse(Console.ReadLine());

                    int combined = x + y;
                    Console.WriteLine(x + " + " + y + " = " + combined);

                Console.Write("Do you wanna play again? ");
                string again = Console.ReadLine();

                if (again == "Y")
                {
                    Console.WriteLine("Restarting");
                }

                else if (again == "N")
                {
                   break;
                }
            }
            Console.WriteLine("Closing... ");




            

//------------------------------------------------------------------------------------

            //lab 2 Loopar
           /* int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------");

            while (true)
            {
               //om d(40) är mindre än e(50) skriv ut d 10 gånger++
                if (d < e )
                {
                    Console.WriteLine(d);
                    d++;
                }

                if (d > e)
                {
                    Console.WriteLine(d);
                    d--;
                }

            }


           /* int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------");

            //a = 50.|| om a är mindre än b (60). a++

            for (int i = a; a <= b; a++)
            {
                Console.WriteLine(a);
            }
           
            /*Console.Write("Two numbers: ");

            int x = int.Parse(Console.ReadLine());  
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------");
            while (y >= x)
            {
                Console.WriteLine(x);
                x++;
            }






//------------------------------------------------------------------------------------

            //Lab 1 Loopar

           /* for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            int x = 0; 
            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }



//---------------------------------------------------------------------------------------------------
// Undervisning
           /* string name = "Chris";
            char letter = 'A';

            foreach (char c  in name)
            {
                Console.WriteLine(c);
            }

           /* while (true)
            {
                Console.WriteLine("1. Start game");
                Console.WriteLine("2. Highscore");
                Console.WriteLine("3. End game");

                Console.Write("Pick between 1 - 3: ");

                string sel = Console.ReadLine();
               
                if (sel == "1")
                {
                    Console.WriteLine("Game is booting up!");
                    Console.WriteLine("...And ends");
                }

                if (sel == "2")
                {
                    Console.WriteLine("Shows Highscore");
                    Console.WriteLine("Done");
                }

                if (sel == "3")
                {
                    break;
                    
                }



            }
            Console.WriteLine("Closing...");

            //For loop
           // for (int year2 = 2022; year2 >= 1972; year2--)
            //{
            //    Console.WriteLine(year2);
            //}

            /*for (int year = 1972; year <= 2022; year++)
            {
                Console.WriteLine(year);
            }

            
            /* for (int counter = 0; counter < 5; counter++)
             {
                 Console.WriteLine("Hej");
                 Console.WriteLine("Chris");
             }


             //While loop
             /*int counter = 0;
             while (counter < 5)
             {
                 Console.WriteLine("Chris");
                 Console.WriteLine("Hej");
                 counter++
             }

             Console.WriteLine("Slut");

             //---------------------------------------------------------------------------------------------------            




             //Lab if 8

             /*Console.Write("How much money you got? ");
             int money = int.Parse(Console.ReadLine());

             Console.Write("Do you have coupon? Y/N: ");
             string coupon = Console.ReadLine();

             string msg = "";

             if (coupon == "N")
             {
                 if (money >= 15 && money <25)
                 {
                     msg = "You can buy a smol borgir";
                 }

                 else if (money >25 && money <= 50)
                 {
                     msg = "You can buy a big borgir";
                 }

             }

             else if (coupon == "Y")
             {
                 if (money >= 15 && money <25)
                 {
                     msg = "You can buy a smol borgir with fries";
                 }

                 else if (money >25 && money <= 50)
                 {
                     msg = "You can buy a big borgir with smol fries";
                 }

                 else if (money > 60 || money >= 50 && money <60)
                 {
                     msg = "You can buy a meal with a drink";
                 }

             }
             Console.WriteLine(msg);


 -------------------------------------------------------------------------------------------------



             //Lab if 7:
             /*Console.Write("What country are you from? ");
             string country = Console.ReadLine();
             string msg = "";

             if (country == "Sweden" || country == "Norway" || country == "Denmark ")
             {
                 msg = "You're from scandinavia";
             }

             else
             {
                 msg = "You're not from scandinavia";
             }
             Console.WriteLine(msg);


 -----------------------------------------------------------------------------------------------

             //Lab if 6;
            /* Console.WriteLine("What year were you born in? ");
             int year = int.Parse(Console.ReadLine());
             string msg = "";

             if (year >= 1980 && year < 1990)
             {
                 msg = "80's";
             }

             else if (year >= 1990 && year < 2000)
             {
                 msg = "90's";
             }

             else if (year <1980 || year >= 2000)
             {
                 msg = "not born in 90's or 80's";
             }
             Console.WriteLine(msg);

 --------------------------------------------------------------------------------------



             //Lab if 5:
             /*Console.Write("Enter A if adult, S for student, E for elderly: ");
             string stage = Console.ReadLine();

             if (stage == "A"|| stage == "E")
             {
                 Console.WriteLine("You will get a reduced price (10 kr less)");

             }

             else if (stage == "V")
             {
                 Console.WriteLine("You pay full price");
             }

             else
             {
                 Console.WriteLine("Invalid input");
             }

 ------------------------------------------------------------------------------------




             //Lab if 4:
            /* Console.Write("Enter your age: ");
             int age = int.Parse(Console.ReadLine());
             string msg = "";

             if (age <18)
             {
                 msg = "ikke myndig";
             }

             else if (age > 65)
             {
                 msg = "pensionär";
             }

             Console.WriteLine(msg);


 ------------------------------------------------------------------------------



             //Lab if 3:
             /*Console.Write("How high is your temp? ");
             float temp = Single.Parse(Console.ReadLine());

             if (temp >= 39.5)
             {
                 Console.WriteLine("Get a doctor");
             }

             else if (temp > 37.9)
             {
                 Console.WriteLine("You have a cold");
             }

             else
             {
                 Console.WriteLine("You're healthy");
             }



 ------------------------------------------------------------------------



            /* //Lab if 2:
             Console.Write("How much milk you got? ");
             int milk = int.Parse(Console.ReadLine());

             if (milk < 10)
             {
                 Console.WriteLine("Order 30");
             }

             else if (milk >=10 && milk <= 20)
             {
                 Console.WriteLine("Order 20");
             }

             else
             {
                 Console.WriteLine("No need to order more");
             }

 --------------------------------------------------------------------------------------------------

             //Lab if 1:
             int tal = int.Parse(Console.ReadLine());
             if (tal > 10)
             {
                 Console.WriteLine("Talet är större än 10");
             }

             else if (tal < 10) 
             {
                 Console.WriteLine("Talet är mindre än 10");
             }


 ------------------------------------------------------------------------------------------



             /*Console.Write("Ange tröjnummer: ");
             int jerseyNumber = int.Parse(Console.ReadLine());

             switch (jerseyNumber)
             {
                 case 21:
                     Console.WriteLine("Foppa");
                     break;

                 case 13:
                     Console.WriteLine("Sudden");
                     break;

                 case 2:
                     Console.WriteLine("Anders");
                     break;

                 default:
                     Console.WriteLine("Who?");
                     break;
             }



             /*if (jerseyNumber == 21)
             {
                 Console.WriteLine("Mats Sundin");
             }

             else if (jerseyNumber == 13)

             {

                 Console.WriteLine("");
             }



             else if (jerseyNumber == 3)
                     {
                 Console.WriteLine("");
                     }
             /*Console.Write("Var är du S/K: ");
             string location = Console.ReadLine();

             Console.Write("Hur gammal är du? ");
             int age = int.Parse(Console.ReadLine());

             Console.Write("Vilken promillehalt: ");
             double promille = Convert.ToDouble(Console.ReadLine());


             if (age >=18 && location == "K" && promille < 1.0)
             {
                 Console.WriteLine("Du får köpa öl");
             }

             else if (age >= 20 && location == "S" && promille < 1.0)
             {
                 Console.WriteLine("Du får köpa");
             }

             else
             {
                 Console.WriteLine("För ung för att köpa");
             }


                 /*Console.Write("Vad heter du? ");
                 string namn = Console.ReadLine();

                 if (namn == "Chris")
                 {
                     Console.WriteLine("Nice name");

                 }

             if (namn == "Titi") 
                 {
                    Console.WriteLine("Awsome");
                 }

                 else
                 {
                     Console.WriteLine("Cool name");
                 }
                 */
        }        
    
        }

}
