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
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    suma += array[i];
                }
            }
            return suma;
        }
    }
}