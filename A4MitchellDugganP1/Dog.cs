/*  Class Name: Dog
 *
 *  Description: Dog class, it contains four strings for its different
 *      attributes. It contains methods to get/set those attributes,
 *      as well as a method to display its attributes via console
 *
 *  Revision History:
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
    // Dog class, it contains the values of the dog itself
    class Dog
    {
        private string name = "";
        private string breed = "";
        private string colour = "";
        private string gender = "";

        public Dog()
        {
        }
        
        // Takes values, applies them to the private variables of the class
        public Dog(string newName, string newBreed, 
            string newColour, string newGender)
        {            
            name = newName;
            breed = newBreed;
            colour = newColour;
            gender = newGender;
        }

        // Will update the class's values with the values given
        public void SetValues(string newName, string newBreed,
            string newColour, string newGender)
        {            
            name = newName;
            breed = newBreed;
            colour = newColour;
            gender = newGender;
        }
        
        // Interface methods for updating individual values of the class
        public void SetName(string newName)
        {
            name = newName;
        }

        public void SetBreed(string newBreed)
        {
            breed = newBreed;
        }

        public void SetColour(string newColour)
        {
            colour = newColour;
        }

        // This method expects "male" or "female", validation is expected
        // at a higher level.
        public void SetGender(string newGender)
        {
            gender = newGender;
        }

        // The Get methods which return the different values of the Dog
        public string GetName()
        {
            return name;     
        }

        public string GetBreed()
        {
            return breed;         
        }

        public string GetColour()
        {
            return colour;          
        }

        public string GetGender()
        {
           return gender;           
        }

        // This method is the default display method for the Dog class
        // It handles basic formatting.
        public void DisplayValues()
        {            
            Console.WriteLine("Name: " + GetName());
            Console.WriteLine("Breed: " + GetBreed());
            Console.WriteLine("Colour: " + GetColour());
            Console.WriteLine("Gender: " + GetGender());
        }

    }
}
