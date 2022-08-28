using System;

namespace RandomPasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string smallLetters = "abcdefghijklmnopqrstuvwxyz";
            const string numbers = "0123456789";
            const string specChars = ".,!?@#";

            Console.WriteLine("Enter the number of characters : (At least 4 !)");
            int passwordLength = Convert.ToInt32(Console.ReadLine());

            var random = new Random();

            char[] password = new char[passwordLength];
            for (int i = 1; i < passwordLength-2; i++)
            {
                password[0] = capitalLetters[random.Next(capitalLetters.Length)];
                password[i] = smallLetters[random.Next(smallLetters.Length)];
                password[passwordLength - 2] = specChars[random.Next(specChars.Length)];
                password[passwordLength - 1] = numbers[random.Next(numbers.Length)];
            }

            foreach (char symbol in password)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
