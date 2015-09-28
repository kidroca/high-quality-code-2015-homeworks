namespace GameFifteen
{
    using System;

    public class MainClass
    {
        private static int GetUserInput()
        {
            Console.Write("Enter a positive number between 1 and 100: ");
            string input = Console.ReadLine();
            int n = 0;

            if (!int.TryParse(input, out n) || n < 1 || n > 100)
            {
                Console.WriteLine("You haven't entered incorrect number, try again.");
                return GetUserInput();
            }
            else
            {
                return n;
            }
        }

        private static void Main()
        {
            int n = GetUserInput();

            Matrix matrix = new Matrix(n);

            Console.WriteLine(matrix);
        }
    }
}
