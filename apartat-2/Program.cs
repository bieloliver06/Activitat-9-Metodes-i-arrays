namespace Apartat_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introdueix el primer número: ");
            int a = int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Introdueix el segon número: ");
            int b = int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("El número major és: " + Major(a, b));
        }
        
        static int Major(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}