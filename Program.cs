using System;
using System.IO;

namespace Viernes4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Añadir datos a un fichero existente;
            //StreamWriter fichero;
            //fichero = File.AppendText("prueba.txt");//Append bc añade;
            //fichero.WriteLine("Una linea más xd");
            //fichero.Close();

            // string nombreFichero =//ruta a carpeta sin @(no reconocería las /;
            //string nombreFichero = @"";//Para que interprete lo que siga como un link de carpeta;

            //////1.Abrimos.
            try //PARA LOS ERRORES;
            {
                StreamWriter fichero;

                ////2.Escritura en fichero de txt.
                fichero = File.CreateText("prueba.txt");
                string frase = "";
                do
                {
                    Console.Write("Introduce frase");
                    frase = Console.ReadLine();
                    if (frase != "")
                        fichero.WriteLine(frase);
                } while (frase != "");
                fichero.Close();
            } 
                        //Tipo de errores;
            catch(PathTooLongException e)
            {
                Console.WriteLine("Nombre demasiado largo {0}" e.Message);
            }
            catch(IOException e)
            {
                Console.WriteLine("El error exacto es {0}",e.Message)
            }
            catch (Exception e)
            {
                Console.WriteLine("Error {0}", e.Message);
            }

            //StreamReader fichero1;
            //string linea;
            //fichero1 = File.OpenText("prueba.txt");
            //do
            //{
            //    linea = fichero1.ReadLine();
            //    if (linea != null)
            //        Console.WriteLine(linea);
            //} while (linea != null);
            //fichero.Close();
            //Console.ReadKey();








            //fichero.WriteLine("Esto es una linea");
            //fichero.WriteLine("y esto otra");
            //fichero.Write("y esto está a continuación");

            ////3.Cerramos
            //fichero.Close();

        }
    }
}
