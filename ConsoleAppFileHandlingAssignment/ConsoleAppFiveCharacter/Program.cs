namespace ConsoleAppFiveCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define file path
            string filePath = "faith.txt";

            // Read the entire file content
            string content = File.ReadAllText(filePath);

            if (content.Length >= 7) // at least 7 characters needed 
            {
                // Start from index 2 
                string result = content.Substring(2, 5);
                Console.WriteLine("Five characters starting from 3rd character: " + result);
            }
            else
            {
                Console.WriteLine("File does not have enough characters");
            }
        }
    }
}