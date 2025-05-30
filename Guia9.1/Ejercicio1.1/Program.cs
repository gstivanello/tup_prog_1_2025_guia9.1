using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_guia9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region definicion de variables
            int[] numeros;
            int contador;
            int mayor;
            int menor;
            int posicionMe;
            int posicionMa;
            int acumulador = 0;
            double prom;

            #endregion

            #region definicion del vector

            numeros = new int[100];

            #endregion

            #region inicializacion

            Console.WriteLine("Ingrese el valor");
            int valor =Convert.ToInt32(Console.ReadLine());
            contador = 0;
            mayor = valor;
            menor = valor;
            posicionMe = 0;
            posicionMa = 0;

            while (valor !=-1)
            {
                numeros[contador] = valor;
                contador++;

                if (valor > mayor)
                {
                    mayor = valor;
                    posicionMa = contador - 1;
                }
                if (valor < menor)
                { 
                    menor = valor;
                    posicionMe = contador - 1;
                }

                Console.WriteLine("Ingrese otro valor y para cortar (-1)");
                valor = Convert.ToInt32(Console.ReadLine());

            }

            #endregion

            #region

            for (int n=0 ; n<contador ; n++)
            {
                Console.Write($"{numeros[n],3} \n");
                acumulador += numeros[n]; // forma correcta de acumular cuando se tiene un vector
            }

            if (contador > 0)
            {
                prom = 1.0 *acumulador / contador;
                Console.WriteLine($"El promedio de los numeros ingresados es: {prom:f2}");
                Console.WriteLine($"El mayor valor ingresado es: {mayor}, en la posicion: {posicionMa}");
                Console.WriteLine($"El menor valor ingresado es: {menor}, en la posicion: {posicionMe}");

            }
            
            else
            {
                Console.WriteLine("No hay numeros");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
