/*  Class Names: DogNode, DogList
 *
 *  Description: DogNode is just a node structure for a single linked list,
 *      it contains a Dog and the next DogNode.
 *
 *      DogList is the interface class for the list, it contains the head
 *      DogNode, will iterate through the list to add new DogNodes to the
 *      end of the list, will iterate through the list requesting each DogNode
 *      to display its values, and can change the values of the first DogNode
 *      in the list.
 *
 *      An easy optimization to add would be a variable directing to the last
 *      DogNode in the list for when adding new Dogs, but at this time the 
 *      assignment interface no longer supports multiple dogs and would be 
 *      untested if added.
 *
 *  Revision History:
 *      November 2016: Mitchell Duggan
 *
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4MitchellDugganP1
{
    // The DogNode class, it contains a Dog and a variable
    // which will contain the next DogNode in the list
    class DogNode
    {
        public Dog dogNode = null;
        public DogNode nextDog = null;
    }

    // The DogList class, it is our interface for the contained DogNode
    // and Dog classes.
    class DogList
    {
        private DogNode firstDog = null;

        // PrintAllDogs() will iterate through the list and have
        // each node display its values
        public void PrintAllDogs()
        {
            DogNode currentDog = firstDog;
            int dogCount = 1;

            while (currentDog != null)
            {                
                Console.WriteLine("Dog " + dogCount + ":");
                currentDog.dogNode.DisplayValues();

                dogCount++;
                Console.WriteLine();

                currentDog = currentDog.nextDog;
            }
        }


        // AddDog takes a Dog object, places it within a DogNode and
        // adds it to the end of the list of linked DogNodes
        public void AddDog(Dog newDog)
        {
            DogNode newDogNode = new DogNode();
            newDogNode.dogNode = newDog;

            DogNode currentDog = firstDog;

            if (currentDog == null)
            {
                firstDog = newDogNode;
            }
            else
            {
                // iterates through list until the next node is null
                while (currentDog.nextDog != null)
                {
                    currentDog = currentDog.nextDog;
                }

                currentDog.nextDog = newDogNode;
            }
        }

        // This will replace the values of only the first node with
        // the strings given
        public void EditDog(string name, string breed,
            string colour, string gender)
        {
            if (firstDog != null)
            {
                firstDog.dogNode.SetValues(name, breed, colour, gender);
            }
        }
    }
}
