using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundeklub
{
    public class Dog
    {

        //Instance field
        private int _dogid;


        //Properties
        public int DogID {  get; set; }
        public string DogName { get; set; }
        public string DogRace {  get; set; }

        public int YearOfBirth { get; set; }

        //Default constructor
        public Dog()
        {

        }


        //Constructor with parameters
        public Dog (int  dogid, string dogName, string dogRace, int yearOfBirth) 
        { 
        DogID = dogid;
        DogName = dogName;
        DogRace = dogRace;
        YearOfBirth = yearOfBirth;
        
        }

        // implement a ToString method
        public override string ToString()
        {
            return $"Dog number: {DogID},Dog name: {DogName},Dog race: {DogRace}, Dog birth year: {YearOfBirth}";
        }

        

    }
}
