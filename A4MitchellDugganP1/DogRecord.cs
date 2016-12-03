/*  Class Name: DogRecord
 *
 *  Description: This class is the record which serves as an interface
 *      for the dogList which works with the dog and dogNode objects. This
 *      class can add dogs, edit the first dog in the list, and make the 
 *      dogList display the values for all dogNodes
 *
 *  Revision History:
 *      November 2016: Mitchell Duggan
 *
 */

 // test commit

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4MitchellDugganP1
{
    class DogRecord
    {
        private DogList dogs;

        // This constructor is not used within assignment 4
        public DogRecord()
        {
            dogs = new DogList();
        }

        // This constructor takes the values for the dog and creates a
        // dog list to hold a new dog object with those values
        public DogRecord(string name, string breed,
           string colour, string gender)
        {
            dogs = new DogList();
            Dog newDog = new Dog(name, breed, colour, gender);
            dogs.AddDog(newDog);
        }

        // This is only for handling a multiple dog record case
        // This does not occur within assignment 4
        public void AddDog(string name, string breed,
            string colour, string gender)
        {
            Dog newDog = new Dog(name, breed, colour, gender);
            dogs.AddDog(newDog);
        }

        // This will replace the values of the first dog in the list of dogs
        public void EditDogInformation(string name, string breed,
            string colour, string gender)
        {
            dogs.EditDog(name, breed, colour, gender);
        }

        // This will print the values of all dogs in the list.
        public void DisplayDogInformation()
        {
            dogs.PrintAllDogs();
        }
    }
}
