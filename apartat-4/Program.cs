namespace Apartat_4
{
    class Program
    {
        static void Main()
        {
            int[] array = {1,2,3,4,5,6,7,8,9,10};
            if (EstaOrdenat(array))
            {
                System.Console.WriteLine("L'array està ordenat");
            }
            else
            {
                System.Console.WriteLine("L'array no està ordenat");
            }
        }

        static bool EstaOrdenat(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}