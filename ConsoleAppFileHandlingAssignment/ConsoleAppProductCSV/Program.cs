namespace ConsoleAppProductCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "product.csv";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"\nEnter details for Product {i}:");
                    Console.Write("Product Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Product Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Product Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Quantity: ");
                    int qty = int.Parse(Console.ReadLine());

                    string line = $"{id},{name},{price},{qty}";
                    sw.WriteLine(line);
                }
            }
            Console.WriteLine("Product details saved to product.csv");
        }
    }
}
