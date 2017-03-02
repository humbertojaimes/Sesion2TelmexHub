using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion2TelmexHub.Entidades
{
    public enum Colores
    {
        Rojo,
        Plata,
        Azul,
        Negro,
        Amarillo
    }

    public enum Estados
    {
        Encendido=10,
        Apagado=20
    }

    public class Automovil
    {
        //http://collabedit.com/bgvuy

        private Colores color;

        public Colores Color
        {
            get { return color; }
            set { color = value; }
        }

        private Estados estadoDeArranque;

        public Estados EstadoDeArranque
        {
            get { return estadoDeArranque; }
            set { estadoDeArranque = value; }
        }

        private Guid numeroDeSerie;

        public Guid NumeroDeSerie
        {
            get { return numeroDeSerie; }
        
        }

        private string tamaño;

        public string Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private string subMarca;

        public string SubMarca
        {
            get { return subMarca; }
            set { subMarca = value; }
        }

        private int numeroDePasajeros;

        public int NumeroDePasajeros
        {
            get { return numeroDePasajeros; }
            set
            {
                if (value < 10)
                {
                    numeroDePasajeros = value;
                }
                else
                {
                    numeroDePasajeros = -1;
                }
            }
        }

        public Automovil()
        {
             numeroDeSerie = Guid.NewGuid();
        }

        public void ProducirAutomovil()
        {
            NumeroDePasajeros = 10;
            Color = Colores.Plata;
            Marca = "Ford";
            Tamaño = "Compacto";
            imprimirAutomovil();
        }

        public void ProducirAutomovil(int numeroDePasajeros)
        {
            NumeroDePasajeros = numeroDePasajeros;
            Color = Colores.Plata;
            Marca = "Ford";
            Tamaño = "Compacto";
            imprimirAutomovil();
        }

        public void ProducirAutomovil(int numeroDePasajeros, Colores color)
        {
            NumeroDePasajeros = numeroDePasajeros;
            Color = color;
            Marca = "Ford";
            Tamaño = "Compacto";
            imprimirAutomovil();
        }

        public void ApagarAuto()
        {
            Console.WriteLine("El auto esta Apagado");
        }



        public void ProducirAutomovil(Colores color)
        {
            NumeroDePasajeros = 4;
            Color = color;
            Marca = "Ford";
            Tamaño = "Compacto";
            imprimirAutomovil();
           
        }

        public void Encender()
        {
            estadoDeArranque = Estados.Encendido;
            imprimirEstado();

        }

        public void Apagar()
        {
            estadoDeArranque = Estados.Apagado;
            imprimirEstado();
        }

        protected void imprimirEstado()
        {
            Console.WriteLine($"Auto: { estadoDeArranque}");
        }

        private void imprimirAutomovil()
        {
            Console.WriteLine
              ($"Número de serie: {NumeroDeSerie}");
            Console.WriteLine
               ($"Número de pasajeros: {NumeroDePasajeros}");
            Console.WriteLine
               ($"Marca: {Marca}");
            Console.WriteLine
               ($"Tamaño: {Tamaño}");
            Console.WriteLine
               ($"Color: {Color}");
            Console.WriteLine();
        }

    }
}
