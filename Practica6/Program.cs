using System;

namespace Practica6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nEjercicio 2:");

            //Crea un programa que escriba en pantalla los números del 1 al 10, "while".
            //Console.WriteLine("\nEjercicio 1:");
            int i = 1;
            while (i < 11)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();


            Console.WriteLine("\nEjercicio 2:");

            /*Crear un programa calcule cuantas cifras tiene un número entero positivo (pista:
         se puede hacer dividiendo varias veces entre 10).*/
            int nb, dig = 0;
            do
            {
                Console.WriteLine("Digite un numero positivo:");
                nb = Convert.ToInt32(Console.ReadLine());

                if (nb <= 0)
                {

                    Console.WriteLine("Digite un número cualquiera positivo");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
            } while (nb <= 0) ;


                if (nb > 0)
                {
                    do
                    {
                        nb = nb / 10;
                        dig = dig + 1;
                    } while (nb > 0);

                    Console.WriteLine("Tiene:" + dig + " cifras.");
                    Console.ReadLine();


                }


                Console.WriteLine("\nEjercicio 3:");

            /*Crear un programa que dé al usuario tres oportunidades para adivinar un número
            del 1 al 23*/


            Random aleatorio = new Random();
            int numbers = aleatorio.Next(1, 24);

            Console.WriteLine("Adivina el número aleatorio, tienes 3 oportunidades.");

            int e = 0;
            int num;
            do
            {
                Console.WriteLine("Adivine el número aleatorio: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num != numbers && e < 2)
                {
                    Console.WriteLine("El numero que ingresaste no es el correcto, vuelva intentarlo otra vez: ");
                }

                if (num == numbers)
                {
                    Console.WriteLine("felicidades! el número que ingresaste es el correcto!");
                }

                e++;

            } while (num != numbers && e < 3);

            if (num != numbers)
            {
                Console.WriteLine("Ya ha agotado todas sus oportunidades, gameover");
            }
            Console.ReadKey();
            
            /*Crea un programa que escriba en pantalla los números del 1 al 10, usando
             "do..while".*/

            Console.WriteLine("\nEjercicio 4:");
            int n = 0;
            do
            {
                n++;
                Console.WriteLine(n);
            } while (n < 10);



            Console.WriteLine("\nEjercicio 5:");


            /*Crear un programa que pida números positivos al usuario, y vaya calculando la
              suma de todos ellos(terminará cuando se teclea un número negativo o cero).
            

                int num1;
                int num2;
                int sum;

                do
                {
                Console.WriteLine("Digita un número positivo: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digita otro número positivo: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                sum = num1 += num2;
            } while (num1 != 0 || num2 > 0);

                if (num1 == 0 || num2 < 0)
                {
                    Console.WriteLine("La suma de los números digitados es: " + sum);
                }


                Console.WriteLine("\nEjercicio 6:");

                /*Crea un programa que pida al usuario su cedula y su contraseña (ambos
                numéricos), y no le permita seguir hasta que introduzca como cedula
                "00113764530" y como contraseña "1823".*/

            double cedula = 00113764764530;
            int clave = 1823;
            double ced;
            int clave1;
            do
            {
                Console.WriteLine("Introduzca su cedula: ");
                ced = Convert.ToDouble(Console.ReadLine());

                if (ced != cedula)
                {
                    Console.WriteLine("Usuario invalido, vuelva a intentarlo");
                }

            } while (ced != cedula);


            do
            {
                Console.WriteLine("Introduzca su contraseña: ");
                clave1 = Convert.ToInt32(Console.ReadLine());

                if (clave1 != clave)
                {
                    Console.WriteLine("contraseña incorrecta, vuelva a intentarlo");
                }

            } while (clave1 != clave);

            if (ced == cedula && clave1 == clave)
            {
                Console.WriteLine("Usted ha ingresado a su usario con exito.");
            }

            Console.ReadKey();



            Console.WriteLine("\nEjercicio 7:");

            /*Crear un programa que muestre los primeros ocho números pares(tips: en cada
            pasada habrá que aumentar de 2 en 2, o bien mostrar el doble del valor que hace
            de contador).*/

            for (int i = 2; i < 18; i = i + 2)

            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            Console.WriteLine("\nEjercicio 8:");

            char letra;

                for (letra = 'Z'; letra >= 'A'; letra--)
                    Console.Write("{0} ", letra);

                Console.WriteLine("\nEjercicio 9:");

            ///*Crear un programa que escriba en pantalla los números del 1 al 50 que sean
            //múltiplos de 3*/

            for (int e = 1; e < 51; e++)
            {
                if (e % 3 == 0)
                {
                    Console.WriteLine(e);
                }
            }

            Console.WriteLine("\nEjercicio 10:");

                /*Crear un programa que pregunte al usuario su edad y su año de nacimiento. Si la
                  edad que introduce no es un número válido, mostrará un mensaje de aviso, pero
                  aun así le preguntará su año de nacimiento.*/


                Console.WriteLine("Cual es tu edad?");
                byte edad = Convert.ToByte(Console.ReadLine());

                double cal;
                do
                {

                    Console.WriteLine("Cual es tu año de nacimiento?");
                    double año = Convert.ToDouble(Console.ReadLine());

                    cal = 2020 - año;

                    if (edad != cal)
                    {
                        Console.WriteLine("Tu edad es invalida. Vuelve a introducir tu año de nacimiento");
                    }

                    if (edad == cal)
                    {
                        Console.WriteLine("Tu edad es de " + edad + " años y tu año de nacimiento es " + año);
                    }

                } while (edad != cal);

                Console.ReadKey();


                Console.WriteLine("\nEjercicio 11:");

                /*Crear un programa que pida al usuario su nombre completo y año de nacimiento
                y muestre un mensaje (Su nombre es: NOMBRE, su edad: EDAD.*/

                Console.WriteLine("Escriba su nombre completo: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Digite su año de nacimiento: ");
                double añoN = Convert.ToDouble(Console.ReadLine());

                double edad1 = 2020 - añoN;

                Console.WriteLine("Su nombre es: " + nombre + ", su edad: " + edad1);





            }


            
    }
}
