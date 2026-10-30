using System;
namespace CS6
{
    class Program
    {
        static void Main(string []args)
        {
            Console.WriteLine("Lia Mayté Vargas Vargas 331-41");
            string nombre = "Diana";
            double zancada = 0.63;
            int maraton = 21000;
            double distancia = 0;
            int zancadas = 0;
            double hidratación = 2000;
            int total_hidrataciones = 1;
            //int numero_hidratacion = 0;
            //int recorrido_hidratacion = 2000;
            Console.WriteLine("Día: Sábado 10 de octubre");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"{nombre} correra medio maratón de 21km. Tiene una zancada de {zancada}m.");
            while (distancia < maraton)
            {
                distancia = distancia + zancada;
                zancadas += 1;
                /*
                if (recorrido >= recorrido_hidratacion)
                {
                numero_hidratacion += 1;
                recorrido_hidratacion += 2000;
                Console.WriteLine($"Recorrido: {recorrido} m\n"hidratacion {numero_hidratacion});
                }
                */
                if (distancia >= hidratación)
                {
                    Console.WriteLine($"Pausa para hidratación en {hidratación}m, hidratación num. {total_hidrataciones}");
                    hidratación += 2000;
                    total_hidrataciones += 1;
                }
            }
            Console.WriteLine($"Diana necesita {zancadas} zancadas para terminar el circuito");
            // 1. ciclo for
            /*
            for (inicialización; expresión; iterador)   SON SEPARADOS CON PUNTO Y COMA
            {
                    //Bloque de instrucciones
            }
            */
            // Ejemplo: Secuencia 35-41
            for (int m = 35; m <= 41; m++) //++ es solo incremento de UNA UNIDAD
            {
                Console.WriteLine($"m: {m}");
            }
            //Sesion 14: Ciclo for 14102026
            //1. Definir un ciclo for para la siguiente secuencia: -33 -34 -35 -36 -37 -38 -39
            Console.WriteLine($"Ciclo 1: Descendente");
            for (int i = -33; i >= -39; i -= 1)
            {
                Console.WriteLine($"i: {i * -1}");
            }
            Console.WriteLine("Ciclo 2: Ascendente");
            for (int a = 9; a <= 15; a += 1)
            {
                if (a != 13)
                Console.WriteLine($"a: {a}");
            }
            //Incluir las instrucciones para omitir la impresion de 13.
            //Ejercicio libro
        }
    }
}