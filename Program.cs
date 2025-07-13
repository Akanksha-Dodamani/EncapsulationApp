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
        }
    }
}
