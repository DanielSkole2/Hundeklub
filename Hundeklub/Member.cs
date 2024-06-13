using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundeklub
{
    public class Member
    {
        
        private Dog dog = new Dog();
        

        //Properties
        public int MemberID { get; set; }

        public string MemberName { get; set; }

        public string MemberAdress { get; set; }

        public int MemberBirthdate { get; set; }

        public int MemberPhone { get; set; }

        public string MemberEmail { get; set; }


       

        //Default constructor
        public Member()
        {

        }




      

      
        


        //Constructor with parameters
        public Member (int memberId, string membername, string memberadress, int memberBirthdate, int memberPhone, string memberEmail)
        {
        MemberID = memberId;
        MemberName = membername;
        MemberAdress = memberadress;
        MemberBirthdate = memberBirthdate;
        MemberPhone = memberPhone;
        MemberEmail = memberEmail;

        }

        //Function to calculate the current age
        public int CalcoAge()
        {


            int currentyear = 2024;
            int currentAge = currentyear-MemberBirthdate;

            return currentAge;


        }

        





       

        // implement a ToString method
        public override string ToString()
        {
            return $"Member number: {MemberID},Member name: {MemberName},Member adress: {MemberAdress}, Member birth year: {MemberBirthdate},Member phone number {MemberPhone},Member email: {MemberEmail}";
        }





      
        

        public void RegisterDog()
        {
            //Create dog objects
            Dog dog1 = new Dog(1, "Rex", "Bulldog", 2018);
            Dog dog2 = new Dog(2, "John", "Greyhound", 2020);

            Console.WriteLine($"Member nr1 has dog number: {dog1.DogID},Member nr1 also has dog number: {dog2.DogID}");

        }



     


    }
}
