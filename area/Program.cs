using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseX=0, alturaX=0;

            Console.WriteLine("Calculadora - Area do Triângulo");
            
            Console.Write("Digite o Valor da Base: ");
            baseX = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura: ");
            alturaX = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A Area do triângulo é " + ((baseX*alturaX)/2));
            
            
            Console.ReadKey();
        }
    }
}
