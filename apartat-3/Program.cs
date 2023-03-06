namespace Apartat_3
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int suma = SumaParells(array);
            Console.WriteLine("La suma dels números parells és: " + suma);
        }
        
        static int SumaParells(int[] array)
        {
            int suma = 0;
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    suma += number;
                }
            }
            return suma;
        }
    }
}