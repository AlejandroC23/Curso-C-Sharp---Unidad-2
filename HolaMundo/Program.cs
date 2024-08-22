using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        
        //CONSTANTES
        const double PI = 3.1416;
        static void Main(string[] args)
        {
            //CLASE 3 - TIPOS DE DATOS

            //DATOS NÚMERICOS
            /*
             * BYTE (1 byte)
             * DEL 0 AL 255
             */
            byte miByte = 233;
            //Console.WriteLine(miByte);
            /*
             * SHORT (2 bytes)
             * DEL -32768 AL 32767
             */
            short miShort = 3454;
            //Console.WriteLine(miShort);
            /*
             * INT (4 bytes)
             * DEL -2,147,483,648 AL 2,147,483,647
             */
            int miInt = 234511234;
            //Console.WriteLine(miInt);
            /*
             * LONG (8 bytes)
             */
            long miLong = 24534444433443;
            //Console.WriteLine(miLong);
            /*
             * FLOAT (PUNTO FLOTANTE DE 7 DÍGITOS)
             */
            float miFloat = 2.43785643f; //se necesita poner la 'f' al final para declarar que es de tipo float
            //Console.WriteLine(miFloat);
            /*
             * DOUBLE (PUNTO FLOTANTE DE 15 - 16 DÍGITOS)
             */
            double miDouble = 2.3443234565;
            //Console.WriteLine(miDouble);
            /*
             * DECIMAL (PUNTO FLOTANTE DE 28 - 29 DÍGITOS)
             */
            Decimal miDecimal = 2.3435462435578905m; //se necesita poner la 'm' al final para declarar que es de tipo decimal
            //Console.WriteLine(miDecimal);

            /*
             * DATOS BOOLEANOS
             * SUS VALORES SON DE: true (1) o false (0)
             */
            bool miBooleanFalse = false;
            bool miBooleanTrue = true;
            //Console.WriteLine(miBooleanTrue);
            //Console.WriteLine(miBooleanFalse);
            int edad = 12;
            bool miBoolean = edad < 18;
            //SE PUEDE DECLARAR EL VALOR DEL BOOLEANO CON CONDICIONES LÓGICAS

            //DATOS DE TIPO TEXTO
            /*
             * CHAR - SOLO ADMITE UN CARACTER (comillas simples)
             */
            char miChar = 'c';
            /*
             * STRING - CADENA DE CARACTERES (comillas dobles)
             */
            string miStr = "Hola mundo";

            //OTROS TIPOS DE DATOS
            /*
             * DYNAMIC: SU CONTENIDO VARIA A LO QUE EL USUARIO O EL PROGRAMADOR INGRESA
             */
            dynamic dy = 3.234;
            double mult = dy * 2;
            Console.WriteLine(dy);
            Console.WriteLine(mult);

            //TENER EN CUENTA QUE TIPO DE DATO QUE SE ESPECIFICA
            //dynamic dyc = "asddd";
            //double multc = dyc * 2;

            //CAMBIAR EL TIPO DE DATO
            dy = "HOLA MUNDO";
            Console.WriteLine(dy);
            dy = Math.PI;
            Console.WriteLine(dy);
            dy = true;
            Console.WriteLine(dy);

            /*
             * VAR: PERMITE OMITIR LA DECLARACIÓN DE UN TIPO DE DATO A UNA VARIABLE
             */
            var vnc = 6.2676404;
            double suma = vnc + 2;
            Console.WriteLine(suma);

            //NO ES POSIBLE CAMBIAR SU TIPO DE DATO
            //vnc = "HOLA MUNDO";
            //vnc = true;

            //SUMAR TEXTOS
            //PODEMOS 'SUMAR' O CONCATENAR TEXTOS DE LA SIGUIENTE MANERA:
            string texto1 = "Hola ";
            string texto2 = " Mundo";
            string miPrimer = texto1 + texto2;
            Console.WriteLine(miPrimer);

            //CONVERTIR DE TEXTO A NÚMERO
            string numeros1 = "20";
            int numeros2 = 30;
            Console.WriteLine(numeros2 + Convert.ToInt32(numeros1));

            //CLASE 2  - VARIABLES y CONSTANTES
            //VARIABLES

            /*
             * COMO DECLARAR UNA VARIABLE (REGLAS)
             * 1. Declarar el tipo.
             * 2. Declarar el nombre:
             *    - Sin caracteres especiales.
             *    - No puede iniciar con números o ser números.
             *    - Recomendación: Utilizar nomenglatura de camello (en métodos iniciar con máyusculas)
             *    - Puede llevar guion bajo
             *    - Puede contener números
             */

            //FORMA 4
            int numero1, numero2, numero3, numero4;
            numero1 = numero2 = 50;
            numero3 = numero4 = 60;

            //FORMA 3
            int numero5 = 30, numero6 = 40;

            //FORMA 2
            int numero7, numero8;
            numero7 = 10; numero8 = 20;

            //Console.WriteLine("El valor del número 1 es: " + numero1);
            //Console.WriteLine("El valor del número 2 es: " + numero2);
            //Console.WriteLine("El valor del número 3 es: " + numero3);
            //Console.WriteLine("El valor del número 4 es: " + numero4);

            //FORMA 1
            double pesoColombiano = 10.0000;
            int dolar;

            //USO DE VARIABLES
            //Console.WriteLine("El valor de pesos colombianos a dólares es: " + pesoColombiano);

            dolar = 1;
            //Console.WriteLine("El valor del dólar 1: " + dolar);

            //USO DE CONSTANTES
            //Console.WriteLine("El valor de pi es: " + PI);
            //NuevoMetodo();
            //NuevoMetodo2();

            //CLASE 1 - ESCRITURA EN CONSOLA
            //Console.WriteLine("Hola Mundo");
            //Console.WriteLine("Este es mi primer programa desde C#");

            /*
             * ASDSDASDASDDFSD
             * Este es un comentario de
             * multiples lineas
             */

            //LEER TECLA DIGITADA
            Console.ReadKey();

        }

        //PROBAR CONSTANTES GLOBALES EN OTROS METODOS
        //public static void NuevoMetodo()
        //{
        //    Console.WriteLine("El valor de pi en NuevoMetodo() es: " + PI);
        //}
        //public static void NuevoMetodo2()
        //{
        //    Console.WriteLine("El valor de pi en NuevoMetodo2() es: " + PI);
        //}
    }
}
