namespace ConsoleAppArrayDelegate
{
     public class Program
    {
        public delegate int[] ArrayOperation(int[] arr);

        // Method to sort array
        public static int[] SortArray(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        // Method to sort array
        public static int[] ReverseArray(int[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nOriginal Array:");
            foreach (int num in numbers) Console.Write(num + " ");
            Console.WriteLine();

            Console.WriteLine("\nChoose Operation:");
            Console.WriteLine("1. Sort");
            Console.WriteLine("2. Reverse");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            // Declare delegate
            ArrayOperation operation;

            if (choice == 1)
                operation = SortArray;
            else
                operation = ReverseArray;

            // Invoke delegate
            int[] result = operation(numbers);

            Console.WriteLine("\nResult Array:");
            foreach (int num in result) Console.Write(num + " ");

        }
    }
}