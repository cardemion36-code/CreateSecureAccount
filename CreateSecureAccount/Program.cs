using System;

namespace CreateSecureAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static string GenerateRandom(int Size, string AddAfter)
        {
            string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string result = null;
            Random random = new Random(Size);

            for (int i = 0; i < Size; i++)
            {
                int randomIndex = random.Next(validChars.Length);
                result += validChars[randomIndex];
            }

            return $"{result}{AddAfter}";
        }
    }
}
