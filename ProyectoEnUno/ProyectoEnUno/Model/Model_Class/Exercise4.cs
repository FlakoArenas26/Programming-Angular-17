using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEnUno.Model.Model_Class
{
    class Exercise4
    {
        public static string PuntoCuatro(string ciud)
        {
            try
            {
                List<string> ciudades = new List<string>
                {
                    "bogota",
                    "medellin",
                    "cali",
                    "cartagena",
                    "barranquilla",
                };
                 // Validaci�n s�lo para letras
                foreach (char c in ciud)//bucle para c iterar en ciudad
                {
                    if (!char.IsLetter(c))//m�todo que devuelve true si es letra.
                    {
                        return "Caracteres  inv�lidos. S�lo se permiten letras.";
                    }
                }

                if (ciudades.Contains(ciud.ToLower()))
                {
                    return $"La ciudad {ciud} se encuentra en la lista.";
                }
                else
                {
                    return $"La ciudad {ciud} no se encuentra en la lista.";
                }
            }
            catch (Exception prueba)
            {
                return prueba.Message;
            }
        }
    }
}
