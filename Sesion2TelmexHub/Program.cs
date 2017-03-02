using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sesion2TelmexHub.Entidades;

namespace Sesion2TelmexHub
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir=true;
            while (repetir)
            {
                Console.Clear();
                Console.WriteLine("Introduce el número de pasajeros que deseas ");
                string numeroDePasajerosTexto = Console.ReadLine();
                int numeroDePasajeros = 0;
                Automovil MiPrimerAutomovil = new Automovil();
                if (int.TryParse(numeroDePasajerosTexto, out numeroDePasajeros))
                {
                    Console.WriteLine("Introduce el color  que deseas ");
                    string color = Console.ReadLine();
                    Colores colorSeleccionado;
                    if (Enum.TryParse(color, out colorSeleccionado))
                    {
                        switch (colorSeleccionado)
                        {
                            case Colores.Rojo:
                            case Colores.Plata:
                            case Colores.Azul:
                                MiPrimerAutomovil.ProducirAutomovil(numeroDePasajeros, colorSeleccionado);
                                break;
                            case Colores.Negro:
                                Console.WriteLine("No en este color disponible");
                                break;
                            default:
                                Console.WriteLine("Color no válido");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error al seleccionar el color");
                    }
                    //Colores colorSeleccionado = (Colores)Enum.Parse(typeof(Colores), color);


                }
                else
                {
                    Console.WriteLine("Error en número de pasajeros");
                }


                //if(VariableTipoBool) if(miBool)
                //if(invocacionAMetodo) if(miPrimerAutomovil.ValidarNumero(numero))
                //if(lineaDeCodigo) if(numeroDePasajeros==4) < > <= >=

                Console.WriteLine("Desea seleccionar otro Automovil S/N");
                var continuar = Console.ReadLine();
                if (continuar.ToUpper() != "S") repetir = false;
                 
            }
           Console.ReadKey();
        }
    }
}
