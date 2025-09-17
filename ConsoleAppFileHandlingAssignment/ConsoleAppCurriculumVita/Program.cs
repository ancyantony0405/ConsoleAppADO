namespace ConsoleAppCurriculumVita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = "CVs";
            Directory.CreateDirectory(folderPath);

            Console.Write("Enter number of applicants: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nApplicant {i}:");
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Location: ");
                string location = Console.ReadLine();
                Console.Write("Enter Qualification: ");
                string qualification = Console.ReadLine();
                Console.Write("Enter Skills: ");
                string skills = Console.ReadLine();

                string fileName = $"{name}_{location}.txt";
                string filePath = Path.Combine(folderPath, fileName);

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("Curriculum Vitae");
                    sw.WriteLine("--------------------");
                    sw.WriteLine($"Name: {name}");
                    sw.WriteLine($"Location: {location}");
                    sw.WriteLine($"Qualification: {qualification}");
                    sw.WriteLine($"Skills: {skills}");
                }
                Console.WriteLine($"CV saved at {filePath}");
            }
        }
    }
}