using System;
namespace CS7
{
    class Program
    {
        static void Main(string []args)
        {
            //Bloque de la funcion
            //sesion 15: funciones 15102026
            /*
            Funcion: Bloque de instrucciones para realizar una tarea especifica que se ejecute unicamente cuando es invocado.
            Sixtaxis: Definicion de funcion
            tipo_dato_devuelto identificador_funcion(parametros)
            {
                Bloque de instrucciones
            }
            Nota 1: Los parametros se definen incluyendo tipo de dato.
            Nota 2: Los parametros van separados por comas.
            Sintaxis: Invocacion funcion
            identificador_funcion(argumentos);
            Argumento: El valor del parametro.
            WRITELINE ES UNA FUNCION QUE NOS PERMITE MOTRAR INFORMACION EN LA PANTALLA
            */
            //Ejemplo 1: Funcion vacia sin parametros
            //Definicion
            void Saludar() //Con void, la funcion no devuelve ningun valor
            {
                string salon = "Exactas 331";
                Console.WriteLine($"¡Hola. {salon}!");  
            }
            //Invocacion
            Saludar();
            // Ejercitacion
            //1. Definir e invocar una funcion sin parametros para imprimirr: nombre, clave y salon.
            void ncs()
            {
                Console.WriteLine("Nombre: Lia Vargas, clave 331-41, salon 331");
            }
            ncs();
            //2. Definir e invocar una funcion para desplegar el horario de hoy.
            void horario()
            {
                Console.WriteLine("Calculo 7:00, Formacion Humana 7:50, Programacion 8:40, Psicologia 9:50, Idiomas 10:40, Dibujo 11:50-1:30");
            }
            horario();
            //Sesión 16: Función con parámetros
            //return: Palabra reservada para terminar una función y devolver una expresión
            //Ejemplo 1: Doble
            int CalcularDoble(int número)
            {
                int resultado = 2 * número;
                return resultado;
            }
            // Invocación
            int devolución;
            devolución = CalcularDoble(9);
            Console.WriteLine($"Devolución: {devolución}");
            // Ejercitación
            // 1. Definir e invocar una función que devuelva la evaluación de la siguiente espresión f(x) = 4 x - 7/5
            double f(double x)
            {
                double y;
                y = 4 * x - 7 / 5D;
                return y;
            }
            double d;
            d = f(0);
            Console.WriteLine($"f(0): {d}");
        }
    }
}