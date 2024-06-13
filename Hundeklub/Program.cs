namespace Hundeklub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            TestAPP testmyAPP = new TestAPP();
            testmyAPP.TestClass();


            

            Member member1 = new Member(1, "Hans", "Kastrup", 1985, 20253046, "johndoe@gmail.com");

            Console.WriteLine($"This is the current age for member nr1: {member1.CalcoAge()}");



        }
    }
}
