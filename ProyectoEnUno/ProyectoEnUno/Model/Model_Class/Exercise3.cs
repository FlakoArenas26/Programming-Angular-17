using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEnUno.Model.Model_Class
{
    class Exercise3
    {
        public static string PuntoTres(string datosEstudiante3)
        {
            Estudiante informacionEstudiante = new Estudiante();

            //Asignar valores a las propiedades
            informacionEstudiante.nombre = "Juan";
            informacionEstudiante.edad = 22;
            informacionEstudiante.notas = 7;

   

            //LLamar método
            informacionEstudiante.datosEstudiante();
        return datosEstudiante3;
        }
    }

    class Estudiante
    {
        public string nombre; //Propiedades o campo de clase
        public int edad;
        public int notas;

        public void datosEstudiante() //Método
        {
            Console.WriteLine($"\nNombre estudiante: {nombre} \nedad: {edad} \ncalificación: {notas}");
        }
    }

}
