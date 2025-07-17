using System.Numerics;

namespace EncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Product app
            ProductApp product1 = new ProductApp(1, "Mobile", 1000);
            product1.DisplayProductDetails(product1);
            ProductApp product2 = new ProductApp(2, "IPad", 500);
            product2.DisplayProductDetails(product2);


            // Student encapsulation
            StudentApp student1 = new StudentApp();
            student1.RollNo = 1;
            student1.Name = "Test name";
            student1.Cgpa = 8.6;

            Console.WriteLine($"Id: {student1.RollNo}, Name: {student1.Name}, Cgpa: {student1.Cgpa}, Percentage: {student1.GetPercentage()}");

            // Player App
            PlayerApp player1 = new PlayerApp(1, "Sam", 10);
            PlayerApp player2 = new PlayerApp(2, "Pam");

            Console.WriteLine($"Player 1: {player1.GetName()}, ID: {player1.GetId()}, Age: {player1.GetAge()}");
            Console.WriteLine($"Player 2: {player2.GetName()}, ID: {player2.GetId()}, Age: {player2.GetAge()}\n");

            player1.WhoIsElder(player1, player2);
        }
    }
}
