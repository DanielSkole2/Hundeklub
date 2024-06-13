using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundeklub
{
    public class DogCatalog
    {
        

        //List to store Dog item
        private List<Dog> dogcatalog = new List<Dog>();
       
        //Method to add dog 
        public void AddDog(Dog dog)
        {
            dogcatalog.Add(dog);
        }

        //Method to remove a dog from the catalog
        public void RemoveDog(Dog dog)
        {
            dogcatalog.Remove(dog);
        }

        //Method to update a dog in the catalog
        public void UpdateDog(Dog dogToUpdate, Dog newDog)
        {
            //Find the index of the dog to update in the list
            int index = dogcatalog.FindIndex(p => p.DogID == dogToUpdate.DogID);
            //If the dog is found, it is to be updated with a new dog
            if (index != -1)
            {
                dogcatalog[index] = newDog;
            }
        }

        //Method to print the list of dogs 
        public void PrintDogs()
        {
            //Print each dog in the list and their details 
            foreach (var dog in dogcatalog)
            {
                Console.WriteLine($"Dog number: {dog.DogID},Dog name: {dog.DogName},Dog race: {dog.DogRace}, Dog birth year: {dog.YearOfBirth}");


                
            }
        }




    }
}
