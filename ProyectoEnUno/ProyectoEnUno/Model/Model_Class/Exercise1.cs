using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEnUno.Model.Model_Class
{
    public class Exercise1
    {
            public string Nombre{get;set;}
            public string Mensaje{get;set;}
            public string Edad{get;set;}


        public Exercise1(string Nombre, string Mensaje, string Edad)
        {
                this.Nombre = Nombre;
                this.Mensaje = Mensaje;
                this.Edad = Edad;
        }


        public  void validarVacios(string ingresa1,string ingresa2)
        {
            


            while (string.IsNullOrWhiteSpace(ingresa1) || string.IsNullOrWhiteSpace(ingresa2))
            {
            string msjError = "Error no se pueden agregar espacios en blanco";
                if (string.IsNullOrWhiteSpace(ingresa1))
                {
                    Console.WriteLine("Por favor, ingrese su nombre: ");
                    ingresa1 = Console.ReadLine();

                }
                else
                {
                Console.WriteLine(msjError);
                }

                if (string.IsNullOrWhiteSpace(ingresa2))
                {
                    Console.WriteLine("Por favor, ingrese su mensaje: ");

                    ingresa2 = Console.ReadLine();
                }
                else
                {
                Console.WriteLine(msjError);
                }
              // msjError = "Error: no se pueden agregar espacios en blanco\n";
            }
              Console.WriteLine("\nSu nombre es: " + ingresa1 + " \nMensaje Enviado: " + ingresa2);
           
        }
         public void ValidarEdad()
         {        
               while(true)
               {

                    if (int.TryParse(Edad, out int EdadInt)) //Convierte Edad a entero//Try parse devuelve true
                    {
                       // Console.WriteLine("\nDatos Ingresados\nSu nombre es: " + Nombre +"\nSu edad es: " + EdadInt+ " \nMensaje Enviado: " + Mensaje);
                    Console.WriteLine("\nSu edad es: " + EdadInt);

                    }
                    else
                    {
                        Console.WriteLine("La edad ingresada no es válida.");
                    }
                    break;
               }
         }

       // public int GetNuevaEdad()
      //  {
       //     return "La edad"; 
      //  }

       
    }
}
 
/*
      using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEnUno.Model.Model_Class
{
    public class Exercise1
    {
            public string Nombre{get;set;}
            public string Mensaje{get;set;}
            public string Edad{get;set;}


        public Exercise1(string Nombre, string Mensaje, string Edad)
        {
                this.Nombre = Nombre;
                this.Mensaje = Mensaje;
                this.Edad = Edad;
        }


        public  void validarVacios(string ingresa1,string ingresa2)
        {
            


            while (string.IsNullOrWhiteSpace(ingresa1) || string.IsNullOrWhiteSpace(ingresa2))
            {
            string msjError = "Error no se pueden agregar espacios en blanco";
                if (string.IsNullOrWhiteSpace(ingresa1))
                {
                    Console.WriteLine("Por favor, ingrese su nombre: ");
                    ingresa1 = Console.ReadLine();

                }
                else
                {
                Console.WriteLine(msjError);
                }

                if (string.IsNullOrWhiteSpace(ingresa2))
                {
                    Console.WriteLine("Por favor, ingrese su mensaje: ");

                    ingresa2 = Console.ReadLine();
                }
                else
                {
                Console.WriteLine(msjError);
                }
              // msjError = "Error: no se pueden agregar espacios en blanco\n";
            }
              Console.WriteLine("\nSu nombre es: " + ingresa1 + " \nMensaje Enviado: " + ingresa2);
           
        }
         public void ValidarEdad()
         {        
               while(true)
               {

                    if (int.TryParse(Edad, out int EdadInt)) //Convierte Edad a entero//Try parse devuelve true
                    {
                       // Console.WriteLine("\nDatos Ingresados\nSu nombre es: " + Nombre +"\nSu edad es: " + EdadInt+ " \nMensaje Enviado: " + Mensaje);
                    Console.WriteLine("\nSu edad es: " + EdadInt);

                    }
                    else
                    {
                        Console.WriteLine("La edad ingresada no es válida.");
                    }
                    break;
               }
         }
       
    }
}*/
   
