namespace Apartat_2
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 200, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("El número major és: " + Major(numbers));
        }
        
        static int Major(int[] numbers)
        {
            int biggest = 0;
            foreach (int number in numbers)
            {
                if (number > biggest)
                {
                    biggest = number;
                }   
            }
            return biggest;
        }
    }
}