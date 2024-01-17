using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEnUno.Model.Model_Class
{

   

    class Exercise2
    {
        public static string OperacionsMath(string Inf)
        {
            try
            {
              
                decimal Num1 = 0, Num2 = 0, Result = 0;

                char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
                var InfSegmentada = Inf.Split(delimiterChars);


                 if (!decimal.TryParse(InfSegmentada[0], out Num1) || !decimal.TryParse(InfSegmentada[1], out Num2))
                {
                    return "Error: Debes ingresar números válidos para las operaciones.";
                }



                switch (InfSegmentada[2])
                {
                    case "1":
                        Result = Num1 + Num2;
                        break;

                    case "2":
                        Result = Num1 - Num2;
                        break;

                    case "3":
                        Result = Num1 * Num2;
                        break;

                    case "4":
                        Result = Num1 % Num2;
                        break;

                    default:
                        return "Error: La opción ingresada no es válida. Debe ser 1, 2, 3 o 4.";
                }
                // No se necesita el break aquí después de una sentencia return

                return Result.ToString();
            }
            catch (Exception prueba)
            {
                return prueba.Message;
            }
        }
    }
}
