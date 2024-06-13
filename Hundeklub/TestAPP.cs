using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundeklub
{
    public class TestAPP
    {
       

        public void TestClass()
        {

            //Create dog objects
            Dog dog1 = new Dog(1, "Rex", "Bulldog", 2018);
            Dog dog2 = new Dog(2, "John", "Greyhound", 2020);

            //Create member objects
            Member member1 = new Member(1, "Hans", "Kastrup", 1985, 20253046, "johndoe@gmail.com");
            Member member2 = new Member(2, "Erik", "Roskildevej", 1978, 40553046, "erikeriksen@gmail.com");

            
            

            
            Console.WriteLine($"Dog number: {dog1.DogID},Dog name: {dog1.DogName}, Dog Race: {dog1.DogRace}, Year of birth: {dog1.YearOfBirth}");



            Console.WriteLine($"Dog number: {dog2.DogID},Dog name: {dog2.DogName}, Dog Race: {dog2.DogRace}, Year of birth: {dog2.YearOfBirth}");





            Console.WriteLine($"Member number: {member1.MemberID},Member name: {member1.MemberName}, Member adress: {member1.MemberAdress}, Member birtdate: {member1.MemberBirthdate}, Member phone: {member1.MemberPhone}, Member email: {member1.MemberEmail}");


            Console.WriteLine($"Member number: {member2.MemberID},Member name: {member2.MemberName}, Member adress: {member2.MemberAdress}, Member birtdate: {member2.MemberBirthdate}, Member phone: {member2.MemberPhone}, Member email: {member2.MemberEmail}");


           



        }



    }
}
