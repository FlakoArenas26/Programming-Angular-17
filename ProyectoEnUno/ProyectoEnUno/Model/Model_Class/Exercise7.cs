using System;
using System.Collections.Generic; //es necesaria porque se está utilizando el tipo Dictionary<string, int>, que es una colección genérica que almacena pares clave-valor, donde la clave es de tipo string y el valor es de tipo int.
using System.IO;
using System.Linq; //LINQ para realizar operaciones de consulta de manera más ordenada


namespace ProyectoEnUno.Model.Model_Class
{
    class Exercise7
    {
        public static string PuntoSiete(string ruta)
        {
            try
            {
                string rutaArchivo = "C:/TI/OneDrive - EEP/Documentos/contarPalabras.txt"; //Ruta del archivo .txt


                string[] lineas = File.ReadAllLines(rutaArchivo); // Leer todas las líneas del archivo


                string contenido = string.Join(" ", lineas);  // Combinar todas las líneas en una sola cadena


               // string[] palabras = contenido.Split(' ', StringSplitOptions.RemoveEmptyEntries);  // Dividir el contenido en palabras
                string[] palabras = contenido.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //Valor del índice y el valor que se va a agregar en ese mismo.
                Dictionary<string, int> frecuenciaPalabras = new Dictionary<string, int>();  // Contar la frecuencia de cada palabra
                foreach (string palabra in palabras)
                {
                    // Convertir la palabra a minúsculas
                    string palabraMinuscula = palabra.ToLower();

                    if (frecuenciaPalabras.ContainsKey(palabraMinuscula))
                    {//dic                  //Ordena descendiente
                        // Incrementar el conteo si la palabra ya está en el diccionario
                        frecuenciaPalabras[palabraMinuscula]++;
                    }
                    else
                    {
                        // Veces que se repiten las palabras, al inicio agrega uno.
                        frecuenciaPalabras[palabraMinuscula] = 1;
                    }
                }



                // Mostrar las palabras más comunes (ajusta el número según sea necesario)
                int cantidadPalabrasComunes = 5;
                var palabrasMasComunes = frecuenciaPalabras.OrderByDescending(par => par.Value).Take(cantidadPalabrasComunes);
                Console.WriteLine($"Top {cantidadPalabrasComunes} Palabras que más se repiten: \n");
                foreach (var entrada in palabrasMasComunes)
                {
                    Console.WriteLine($"{entrada.Key}: {entrada.Value} veces");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("No se pudo leer el archivo:");
                Console.WriteLine(e.Message);
            }
            return ruta;
        }
    }
}
