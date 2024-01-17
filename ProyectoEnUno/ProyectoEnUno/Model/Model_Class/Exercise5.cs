using System;

namespace ProyectoEnUno.Model.Model_Class
{
    public class Exercise5
    {

        public static double PuntoCinco(int opc, double num1, double num2)
        {

            double resultado = 0;
            switch (opc)
            {
                case 1:
                    resultado = num1 + num2;
                    break;

                case 2:
                    resultado = num1 - num2;
                    break;

                case 3:
                    resultado = num1 * num2;
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        throw new ArgumentException("No se puede dividir por 0.");

                    }
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
            return resultado;
        }
    }
}




//public static string PuntoCinco(string Calculadora)

//{
//    try
//    {
//        /* Console.WriteLine("Calculadora");
//          Console.WriteLine("Introduzca un primer número: ");
//          double num1 = Convert.ToDouble(Console.ReadLine()); // Convertir a double en lugar de int
//          Console.WriteLine("Introduzca un segundo número: ");
//          double num2 = Convert.ToDouble(Console.ReadLine()); // Convertir a double en lugar de int

//          Console.WriteLine("Elija una opción:\n 1. Suma \n 2. Resta \n 3. Multiplicación \n 4. División \n 5. Cancelar");
//          int opc = Convert.ToInt32(Console.ReadLine());*/
//        int num1 = 0, num2 = 0, opc = 0;
//        double resultado = 0;
//        switch (opc)
//        {
//            case 1:
//                resultado = num1 + num2;
//                Console.WriteLine("El resultado de la suma es: " + resultado);
//                Console.WriteLine();
//                break;
//            case 2:
//                resultado = num1 - num2;
//                Console.WriteLine("El resultado de la resta es: " + resultado);
//                Console.WriteLine();

//                break;
//            case 3:
//                resultado = num1 * num2;
//                Console.WriteLine("El resultado de la multiplicación es: " + resultado);
//                Console.WriteLine();

//                break;
//            case 4:
//                if (num2 == 0)
//                {
//                    Console.WriteLine("No se puede dividir entre 0");
//                }
//                else
//                {
//                    resultado = num1 / num2; // Utilizar la operación de división (/) en lugar del módulo (%)
//                    Console.WriteLine("El resultado de la división es: " + resultado);
//                }
//                Console.WriteLine();

//                break;
//            case 5:
//                Console.WriteLine("Salir");
//                break;
//            default:
//                Console.WriteLine("Opción inválida");
//                break;
//        }
//    }
//    return Calculadora;



//    catch (FormatException)
//    {
//        Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
//    }

//}


