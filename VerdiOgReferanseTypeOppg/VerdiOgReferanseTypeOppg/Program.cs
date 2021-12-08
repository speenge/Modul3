using System;

namespace VerdiOgReferanseTypeOppg
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal sum = a + b;
            Console.WriteLine($"Variabel a: {a} Variabel b: {b} og summen av disse er: {sum}");
        }
    }
}
