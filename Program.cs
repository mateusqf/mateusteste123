using System;

namespace mateusgit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero");
            int numero2= int.Parse(Console.ReadLine());

            if (numero1 >= 10 )
            {
                Console.WriteLine("vc passou");
            }
            else if (numero2 < 10)
            {
                Console.WriteLine("vc esta reprovado");
            }
            
            
            }
    }
}
