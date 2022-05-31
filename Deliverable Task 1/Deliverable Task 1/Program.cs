using System;

namespace DeliverableTask1 
{

 class Program 
 {
    static void Main(string[] args)
    {


       string input = "yes";

            while (input == "y" || input == "yes")
            
                {
                    Console.WriteLine("How many people are we making pb&j sandwiches for?");
                    int sandwich = int.Parse(Console.ReadLine());
                                        
                        int slice = sandwich * 2;
                        double loaf = Math.Ceiling(slice / 28.0);

                        int tblspoon = sandwich * 2;
                        double jarp = Math.Ceiling(tblspoon / 32.0);

                        int teaspoon = sandwich * 4;
                        double jarj = Math.Ceiling(teaspoon / 48.0);

                        Console.WriteLine("\nYou will need:\n\n" + slice + " slices of bread\n"
                                           + tblspoon + " tablespoons of peanut butter\n"
                                           + teaspoon + " teaspoons of jelly\n\nwhich is:\n\n"
                                           + loaf + " loaves of bread\n"
                                           + jarp + " jars of peanut butter\n"
                                           + jarj + " jars of jelly\n\n");

                        Console.WriteLine("Would you like to restart?  Enter y or yes to continue," +
                                          " or enter any other key to exit");
                        input = Console.ReadLine();
                        
                }

            while ( input != "y" || input != "yes")
                {
                         Console.WriteLine("\nGoodbye!");
                         break;
                }
     }
 }
}