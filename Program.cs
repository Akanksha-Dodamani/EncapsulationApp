namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductApp product1 = new ProductApp(1, "Mobile", 1000);
            product1.DisplayProductDetails(product1);
            ProductApp product2 = new ProductApp(2, "IPad", 500);
            product2.DisplayProductDetails(product2);
        }
    }
}
