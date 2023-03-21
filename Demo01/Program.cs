using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Programacion y funciones";

            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");

                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicacion de dos números");
                Console.WriteLine("[5] Division de dos números");
                Console.WriteLine("[6] Imprimir los 10 primeros numeros primos");
                Console.WriteLine("[7] Convertir a de Celsius a Fahrenheit");
                Console.WriteLine("[8] Convertir a de Fahrenheit a Celsius");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();

                switch(opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese primer numero");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                   case "3":
                        Console.WriteLine("Ingrese primer numero");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c,d, Resta(c, d));
                        Console.ReadKey();
                        break;
                   case "4":
                        Console.WriteLine("Ingrese primer numero");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Ingrese primer numero");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        if(h == 0)
                        {
                            Console.WriteLine("Error! No se puede dividir entre 0");
                        }
                        else
                        {
                            Console.WriteLine("La division de {0} y {1} es {2}", g, h, Division(g, h));
                        }
                        
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        NumerosPrimos();
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.WriteLine("Ingrese temperatura en C");
                        int temperaturaC = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("La conversion de {0} C a Fahrenheit es {1}", temperaturaC, ConvertirTemperaturaF(temperaturaC)+ " F");
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese temperatura en F");
                        int temperaturaF = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("La conversion de {0} F a Celsius es {1}", temperaturaF, ConvertirTemperaturaC(temperaturaF) + " C");
                        Console.ReadKey();
                        break;

                }
            }while (!opcion.Equals("0"));

        }
        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static int Division(int a, int b)
        {
            return a / b;
        }

        static int ConvertirTemperaturaC(int temp)
        {
            return 5 * (temp - 32) / 9;
           
        }

        static int ConvertirTemperaturaF(int temp)
        {
            return 9 * temp / 5 + 32;
             
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static void NumerosPrimos()
            
        {
            int count = 0;

            for (int i = 2;i <= 30; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                    
                }
                if (count <= 2)
                {
                    Console.WriteLine(i);
                }
                count = 0;

            }
            
        }




    }
}
