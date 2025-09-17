namespace ConsoleAppFileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define file path
            string filePath = "faith.txt";

            // Open file in Append Mode
            using (FileStream fs = new FileStream(
                filePath,
                FileMode.Append,          // Append to existing text
                FileAccess.Write,         // Only Write 
                FileShare.Read))          // only Read
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.WriteLine("Enter text to append:");
                    string input = Console.ReadLine();
                    sw.WriteLine(input);   // Append user text
                }
            }

            Console.WriteLine("Text successfully appended!");
        }
    }
}