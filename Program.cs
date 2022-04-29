using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{

    class Class
    {
        static void Main(string[] args)
        {

            Console.WriteLine("MENU");
            Console.WriteLine("Elija a opcion que desea: \n1 Operadores. \n2 If. \n3 Ciclos. \n4 Areglos. \n9 Salir.");
            int menú = Convert.ToInt32(Console.ReadLine());
            switch (menú)
            {
                case 1:
                    Console.WriteLine("***************************");
                    Console.WriteLine("         OPERADORES        ");
                    Console.WriteLine("Elija a opcion que desea: \n1 Área del triangulo. \n2 Suma de dos numeros. \n3 Numero elevado al cuadrado. \n4 Convertir euros a dolares. \n5 Area y perimetro de un cuadrado. \n6 Area y volumen de un cilindro. \n7 Longitud y area de una circunferencia. \n8 Promedio de tres numeros. \n9 Salir.");
                    int operacion = Convert.ToInt32(Console.ReadLine());
                    switch (operacion)
                    {

                        case 1:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("Área del triangulo");
                            Console.WriteLine("Ingrese un numero para la base del triangulo: ");
                            int bas = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese un numero para la altura del triangulo: ");
                            int altura = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("el area del triangulo es : " + (bas * altura) / 2);
                            break;

                        case 2:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("Suma de dos numeros");
                            Console.WriteLine("Ingrese un numero: ");
                            int numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese otro numero: ");
                            int numero2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("el resultado de la suma es : " + (numero1 + numero2));
                            break;
                        case 3:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("Numero elevado al cuadrado");
                            Console.WriteLine("Ingrese un numero: ");
                            int numero3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("el resultado del numero al cuadrado es : " + Math.Pow(numero3, 2));
                            break;
                        case 4:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("Convertir euros a dolares");
                            Console.WriteLine("Ingrese un monto: ");
                            double monto = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(monto + " euros a dolares es : " + (monto * 1.06 + " USD"));
                            break;
                        case 5:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("Area y perimetro de un cuadrado");
                            Console.WriteLine("Ingrese un numero para el lado del cuadrado: ");
                            int lado = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("el resultado del area del cuadrado es : " + (lado * 2) + " y el perimetro es: " + (lado + lado + lado + lado));
                            break;
                        case 6:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("Area y volumen de un cilindro");
                            Console.WriteLine("Ingrese un numero para la altura del cilindro: ");
                            int Altura = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese un numero para la base del cilindro: ");
                            int Base = Convert.ToInt32(Console.ReadLine());
                            int radio = (Base / 2);
                            double área = (2 * 3.1416 * radio * Altura) + (2 * 3.1416 * Math.Pow(radio, 2));
                            Console.WriteLine("el resultado del area del cilindro es : " + área + " y el volumen es: " + ((3.1416 * Math.Pow(radio, 2)) * Altura));
                            break;
                        case 7:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("Longitud y area de una circunferencia");
                            Console.WriteLine("Ingrese un numero para el radio de la circunferencia: ");
                            double rad = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("la longitud de la circunferencia es : " + (2 * 3.1416) * rad + " y el area es: " + (3.1416 * Math.Pow(rad, 2)));
                            break;
                        case 8:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("Promedio de tres numeros");
                            Console.WriteLine("Ingrese un numero : ");
                            int numero4 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese otro numero : ");
                            int numero5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese otro numero : ");
                            int numero6 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("el promedio de los 3 numeros es : " + (numero4 + numero5 + numero6));
                            break;
                        case 9:
                            Console.WriteLine("----------------------");
                            Console.WriteLine("Salir");
                            break;

                        default:
                            {
                                Console.WriteLine("Dato invalido");
                                break;
                            }

                    }
                    break;



                case 2:

                    Console.WriteLine("***************************");
                    Console.WriteLine("             IF            ");
                    Console.WriteLine("Elija a opcion que desea: \n1 positovos y negativos. \n2 numero mayor y numero menor. \n3 Ciclos. \n4 Areglos. \n9 Salir.");
                    int IF = Convert.ToInt32(Console.ReadLine());
                    switch (IF)
                    {

                        case 1:

                            Console.WriteLine("Ingresar un numero positivo o negativo");
                            int numero7 = Convert.ToInt32(Console.ReadLine());

                            if (numero7 > 0)
                            {
                                Console.WriteLine("El numero es positivo");

                            }
                            else
                            {
                                Console.WriteLine("El numero es negativo");
                            }
                            break;

                        case 2:

                            Console.WriteLine("Ingresar un numero");
                            int numero8 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingresar un segundo numero");
                            int numero9 = Convert.ToInt32(Console.ReadLine());

                            if (numero8 > numero9)
                            {
                                Console.WriteLine("El numero mayor es", numero8, " y el menor", numero9);
                            }
                            else
                            {
                                Console.WriteLine("El numero mayor es", numero9, "y el menor", numero8);
                            }



                            break;
                    }

                    break;
                case 3:
                    Console.WriteLine("En proceso...");
                    break;
                case 4:
                    Console.WriteLine("En proceso...");
                    break;
                case 9:
                    Console.WriteLine("Salir");
                    break;
                default:
                    {
                        Console.WriteLine("Dato invalido.");
                        break;
                    }
            }

        }

    }
}


