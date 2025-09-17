namespace ConsoleAppCopy_FileToAnotherDestination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter source file path: ");
            string source = Console.ReadLine();

            Console.Write("Enter destination file path: ");
            string destination = Console.ReadLine();

            try
            {
                File.Copy(source, destination, true);
                Console.WriteLine("File copied successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
