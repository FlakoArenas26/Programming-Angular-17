using ProyectoEnUno.Model.Model_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEnUno
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" ------J--------  EVALUANDO LO APRENDIDO EN C# 2024 ------------------- ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("1 - Datos de usuario");
            Console.WriteLine("2 - Prueba Calculadora");
            Console.WriteLine("3 - Información estudiante");
            Console.WriteLine("4 - Buscar ciudades");
            Console.WriteLine("5 - Calculadora");
            Console.WriteLine("6 - Contador de palabras");
            Console.WriteLine("7. Contador de 5 palabras más repetidas");
            Console.WriteLine("9. Salir");

            var Result = ""; var mensaje = ""; var nombre = "";

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Por favor ingrese el número del ejercicio que quiere realizar: ");
                Console.WriteLine("---------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                string Option = Console.ReadLine().ToLower();

                int optionInt;
                if (int.TryParse(Option, out optionInt))
                {

                    if (optionInt == 1)
                    {

                        Console.WriteLine("1. Crea un programa que solicite al usuario su nombre y edad, y luego imprima un mensaje personalizado");
                        Console.WriteLine("---");
                        Console.WriteLine("Sr. Usuario, por favor digite su nombre");
                        nombre = Console.ReadLine().ToLower();
                        Console.WriteLine("Sr. Usuario, por favor digite un mensaje: ");
                        mensaje = Console.ReadLine().ToLower();
                        Console.WriteLine("Sr. Usuario, por favor digite su edad: ");
                        string edad = Console.ReadLine().ToLower();


                        Exercise1 datosTodo = new Exercise1(nombre, mensaje, edad);
                        datosTodo.ValidarEdad();
                        datosTodo.validarVacios(nombre, mensaje);
                        // datosTodo.MostrarDatosAlmacenados();
                        Console.WriteLine();

                    }
                    else if (optionInt == 2)
                    {
                        Console.WriteLine("Calculadora");
                        Console.WriteLine("1. suma");
                        Console.WriteLine("2. resta");
                        Console.WriteLine("3. Multiplicación");
                        Console.WriteLine("4. División");
                        Console.WriteLine("");

                        Console.WriteLine("Ingrese entre comas los dos valores a operar, finalmente, el tipo de operación que desea.");
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.WriteLine("Número uno,Número dos,NumeroOperación ");
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("--------------------------------- ");

                        // string OptionOpera = Console.ReadLine().ToLower();
                        Result = Exercise2.OperacionsMath(Console.ReadLine().ToLower());
                        Console.WriteLine("Resultado: " + Result);
                        Console.WriteLine();

                    }

                    else if (optionInt == 3)
                    {
                        string nombreTres = "";
                        string retorno = Exercise3.PuntoTres(nombreTres);
                        Console.WriteLine(retorno);
                    }

                    else if (optionInt == 4)
                    {
                        Console.WriteLine("5 Ciudades más grandes de COLOMBIA");

                        Console.WriteLine("Digite el nombre de la ciudad que deseas buscar:");
                        string ciudad = Console.ReadLine().ToLower();
                        Result = Exercise4.PuntoCuatro(ciudad);
                        Console.WriteLine(Result);
                        Console.WriteLine();

                    }

                    else if (optionInt == 5)
                    {
                        Console.WriteLine("Calculadora");
                        Console.WriteLine("Introduzca un primer número: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Introduzca un segundo número: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("Elija una opción:\n 1. Suma \n 2. Resta \n 3. Multiplicación \n 4. División \n");
                        int opc = Convert.ToInt32(Console.ReadLine());


                        double resultado = Exercise5.PuntoCinco(opc, num1, num2);
                        Console.WriteLine($"El resultado es: {resultado}"); //Salida
                        Console.ReadLine();
                    }

                    else if (optionInt == 6)
                    {
                        Console.WriteLine("Contador de cadena");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese una frase");
                        Console.WriteLine();
                        string cadena = Console.ReadLine();
                        string longitud = Exercise6.PuntoSeis(cadena); //Enlaza
                        Console.WriteLine();
                        Console.WriteLine($"La longitud de la cadena es {longitud}");
                        Console.WriteLine();

                    }

                    else if (optionInt == 7)
                    {
                        Console.WriteLine("Contador de palabras repetidas del Archivo contarPalabras");

                        string cade = Exercise7.PuntoSiete("C:/TI/OneDrive - EEP/Documentos/contarPalabras.txt");
                        Console.WriteLine($"Palabras repetidas {cade}");
                    }

                    else if (optionInt == 9)
                    {
                        break;

                    }

                }

                else
                {
                    Console.WriteLine("El valor ingresado no es válido. Por favor ingrese un número entero.");
                }
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\n\t Aviso \nDigite 0 (cero) únicamente para salir del programa, cualquier letra para continuar");
                string resp = Console.ReadLine().Trim();

                if (int.TryParse(resp, out int numero) && numero == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("¿Desea salir del programa? Ingrese '0' para confirmar la salida, cualquier otra tecla para continuar.");
                    if (Console.ReadLine().Trim() == "0")
                    {

                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("El valor ingresado no es 0, por lo tanto, continuas en el programa.");
                }

            } while (true);


        }
    }
}
