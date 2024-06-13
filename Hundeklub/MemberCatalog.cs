using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundeklub
{
    public class MemberCatalog
    {


        //List to store Member item
        public List<Member> membercatalog = new List<Member>();



        //Method to add member 
        public void AddMember(Member member)
        {
            membercatalog.Add(member);
        }

        //Method to remove a member from the catalog
        public void RemoveMember(Member member)
        {
            membercatalog.Remove(member);
        }

        //Method to update a Member in the catalog
        public void UpdateMember(Member memberToUpdate, Member newMember)
        {
            //Find the index of the member to update in the list
            int index = membercatalog.FindIndex(m => m.MemberID == memberToUpdate.MemberID);
            //If the member is found, it is to be updated with a new member
            if (index != -1)
            {
                membercatalog[index] = newMember;
            }
        }



        //Method to print the list of members 
        public void PrintMembers()
        {
            //Print each member in the list and their details 
            foreach (var member in membercatalog)
            {
                Console.WriteLine($"Member number: {member.MemberID},Member name: {member.MemberName},Member adress: {member.MemberAdress}, Member birth year: {member.MemberBirthdate},Member phone number {member.MemberPhone},Member email: {member.MemberEmail}");



            }
        }



    }
}
