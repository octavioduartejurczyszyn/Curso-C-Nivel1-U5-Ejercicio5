using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           // 5. Hacer un programa que solicite 20 números y luego emitir 
           // por pantalla el máximo de los números pares y el mínimo de los números impares.
            int a, maxpar = 0, minimpar = 0; 
            bool bp = false, bi = false;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Escriba un nro: ");
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    if (bp == false)
                    {
                        maxpar = a;
                        bp = true;
                    }
                    else if(a > maxpar)
                        maxpar = a;
                }
                else if(bi == false)
                {
                    minimpar = a;
                    bi = true;
                }
                else if(a < minimpar)
                minimpar = a; 
            }

            Console.WriteLine("El máximo par es: " + maxpar + " y el mínimo impar es: " + minimpar);
        }
    }
}
