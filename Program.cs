using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int valorUno = 0, valorDos = 0, resultado;

            try
            {
                Console.Write("Numero 1: ");
                valorUno = int.Parse(Console.ReadLine());
                Console.Write("Numero 2: ");
                valorDos = int.Parse(Console.ReadLine());
            }
            catch (FormatException fex)
            {
               Console.WriteLine(fex.Message);
            }
        

            try
            {
                resultado = valorUno / valorDos;
                Console.WriteLine(resultado);
            }
            catch(DivideByZeroException dbzex)
            {
                Console.WriteLine(dbzex.Message);
            }          
            *

            /*
            byte numeroChico = byte.MaxValue;
            try
            {
                checked
                {
                    ++numeroChico;
                }
                Console.WriteLine(numeroChico);
            }
            catch (OverflowException ofex)
            {
                Console.WriteLine(ofex.Message);
            }finally
            {
                Console.WriteLine(numeroChico);
            }
            */

            /*
          int[] numeros = new int[3];

          for (int a = 0; a < 5; a++)
          {
              try {
                  numeros[a] = a * 3;
                  Console.WriteLine(numeros[a]);
              }
              catch (IndexOutOfRangeException iorex)
              {
                  Console.WriteLine(iorex.Message);
              }

          } 
        */

            
            int valorUno = 0, valorDos = 0, resultado;

            try
            {
                Console.Write("Numero 1: ");
                valorUno = int.Parse(Console.ReadLine());
                Console.Write("Numero 2: ");
                valorDos = int.Parse(Console.ReadLine());
                resultado = valorUno / valorDos;
                Console.WriteLine(resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
