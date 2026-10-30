using System;
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Unidad 1: Estructuras de control II
            Unidad 2: Funciones II
            Sesion 12: Instruccion while 30092026
             ------
             Sintaxis (orden de los elementos) while
             Inicializacion
             while(expresion)
             {
                  Bloque de instrucciones
                  iterador;
             }
             -------
             Iterar: repetir (Instruccion que permite repetir o terminar el ciclo)
             Ejemplo 1: Ciclo ascendente
             */
             int m = 1; //Inicializacion (esta linea solo se ejecuta una sola vez)
             //Ejemplo 1: Ciclo escendente (rango: 1-3)
             // m: variable de control
             while(m <= 3) //Expresion (el bloque de instrucciones se ejecutara mientras la expresion sea verdadera)
            {
                //Bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1; //Iterador
                
            }
            //Ejercitacion
            //1. definir un ciclo para imprimir tu nombre 5 veces.
            //  n   ota. para la expresion utilizar el operador menor que
            //ciclo ascendente
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine($"Impresion {n + 1}: Lia Mayté Vargas Vargas");
                if (n ==0)
                {
                    n = 10;
                }
                n += 1; //Iterador
            }
            //b. ciclo descendente
            int d = 3;
            while (d >= 1)
            {
                Console.WriteLine("Nombre: Lia Mayté Vargas Vargas");
                d -= 1; //Iterador
            }//c. Incrementos (ciclo ascendente)
            // Secuencia: 3 6 9 12 15 18
            int i = 3;
            while(i <= 18)
            {
                Console.WriteLine($"i: {i}");
                i += 3;
            }
            //Decrementos
            //Ejercitacion
            //1. definir un ciclo para imprimir "331" 8 veces.
            //Nota: Para la solucion, define un ciclo descendente con decrementos de 2 unidades
            int s = 16;
            while (s >= 0)
            {
                 Console.WriteLine("331");
                 s -= 2;
            }


            //Actividad 1: Ciclo infinito
            //1. Definir un ciclo infinito ascendente. (libre)
            int a = 0;
            while (a >= -1)
            {
                Console.WriteLine($"a: {a}");
                a += 1;
            }

            //2. Definir un ciclo infinito descendente.
            // Nota: Para la solucion, utilizar el operador de diferencia. (para descendente)
            int t = 100;
            while (t != 101)
            {
                Console.WriteLine($"t: {t}");
                t -= 1;
            }

        }
    }
}