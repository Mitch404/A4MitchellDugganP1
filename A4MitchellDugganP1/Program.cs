/* Project Name: A4MitchellDugganP1
 *
 * Description: This program maintains a record of a dog and allows the
 *      user to add the information of one dog, display that info or edit
 *      that information. The underlying structures are capable of adding
 *      and displaying any number of dogs, but this program as an interface
 *      does not make use of that functionality.
 *
 * Revision History:
 *      November 2016: Mitchell Duggan
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4MitchellDugganP1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string name, colour, breed, gender;
            string input = "";
            bool cont = true;
            bool valid = false;
            
            DogRecord mainRecord = null;

            // Main menu loop
            do
            {
                Console.WriteLine("***********************");
                Console.WriteLine("* A. Display dog info *");
                Console.WriteLine("* B. Add a new dog    *");
                Console.WriteLine("* C. Edit dog info    *");
                Console.WriteLine("* D. Exit             *");
                Console.WriteLine("***********************");

                input = Console.ReadLine();
                if (input.ToUpper() == "A") // Display dog info
                {
                    if (mainRecord != null)
                    {
                        mainRecord.DisplayDogInformation();
                    }
                    else // No record created yet
                    {
                        Console.WriteLine("\nNo dog record exists.\n");
                    }
                }
                else if (input.ToUpper() == "B") // Add a new dog
                {
                   
                    Console.WriteLine("\nEnter a name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter a breed:");
                    breed = Console.ReadLine();
                    Console.WriteLine("Enter a colour:");
                    colour = Console.ReadLine();

                    do // will loop until valid gender entered.
                    {
                        Console.WriteLine("Enter a gender: ");
                        gender = Console.ReadLine();

                        if (gender.ToUpper() == "MALE"
                            || gender.ToUpper() == "FEMALE")
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.Write("\nPlease enter \"Male\" ");
                            Console.WriteLine("or \"Female\".\n");
                            valid = false;
                        }
                    } while (!valid);

                    if (mainRecord == null)
                    {
                        // creates record object with new dog's information
                        mainRecord = new DogRecord(name, breed, colour, gender);
                        
                    }
                    else
                    {
                        mainRecord.AddDog(name, breed, colour, gender);
                    }

                    Console.WriteLine("\nDog record successfully added.\n");

                }
                else if (input.ToUpper() == "C") // Edit dog record
                {
                    if (mainRecord == null)
                    {
                        Console.WriteLine("\nNo dog record exists.\n");
                    }
                    else // dog record exists
                    {
                        // displays current dog information
                        Console.WriteLine("\nCurrent dog information: ");
                        mainRecord.DisplayDogInformation();

                        // requests new values from user
                        Console.WriteLine("\nEnter a new name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter a new breed:");
                        breed = Console.ReadLine();
                        Console.WriteLine("Enter a new colour:");
                        colour = Console.ReadLine();

                        do // will loop until valid gender entered.
                        {
                            Console.WriteLine("Enter a gender: ");
                            gender = Console.ReadLine();

                            if (gender.ToUpper() == "MALE"
                                || gender.ToUpper() == "FEMALE")
                            {
                                valid = true;
                            }
                            else
                            {
                                Console.Write("\nPlease enter \"Male\" ");
                                Console.WriteLine("or \"Female\".\n");
                                valid = false;
                            }
                        } while (!valid);

                        // the mainRecord is given the new information to
                        // update the dog with
                        mainRecord.EditDogInformation(name, breed, 
                            colour, gender);
                        Console.Write("\nDog record successfully updated.\n");
                        Console.WriteLine("");
                    }
                }
                else if (input.ToUpper() == "D") // We exit
                {
                    cont = false;
                }
                else // Invalid input case.
                {
                    Console.WriteLine("\nPlease enter A, B, C or D.\n");
                }

            } while (cont);
        }
    }
}
