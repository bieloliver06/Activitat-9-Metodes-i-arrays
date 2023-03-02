namespace Apartat_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introdueix una paraula : ");
            string? input = Console.ReadLine();
            if (input != null)
            {
                char[] word = input.ToCharArray();
                char[] word2 = Girar(word);
                Console.WriteLine(word2);
            }
        }

        static char[] Girar(char[] word)
        {
            char[] word2 = new char[word.Length];
            for (int i = word.Length - 1; i >= 0; i--)
            {
                word2[word.Length - 1 - i] = word[i];
            }

            return word2;
        }
    }
}