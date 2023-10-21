using System;

namespace JuegoDeGuerreros
{
    class Guerrero
    {
        private int vida;
        private int nivelAtaque;
        private string nombre;


        public Guerrero( int vida, int nivelAtaque, string nombre)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.nivelAtaque = nivelAtaque;
        }

        public void Atacar(Guerrero oponente)
        {
            Console.WriteLine($"{this.nombre} ataca a {oponente.nombre}!");
            oponente.RecibirAtaque(this.nivelAtaque);
        }

        public void RecibirAtaque(int cantidadAtaque)
        {
            this.vida -= cantidadAtaque;
            Console.WriteLine($"{this.nombre} recibe {cantidadAtaque} de daño.");
            if (this.vida <= 0)
            {
                Console.WriteLine($"{this.nombre} ha sido vencido.");
            }
            else
            
            {
                Console.WriteLine($"{this.nombre} tiene {this.vida} de vida restante.");
            }
        }

        public bool con vida()
        {
            return this.vida > 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Guerrero guerrero1 = new Guerrero("Guerrero1", 100, 25);
            Guerrero guerrero2 = new Guerrero("Guerrero2", 100, 15);

            Console.WriteLine("¡Comienza el combate!");
            while (guerrero1.EstaVivo() && guerrero2.EstaVivo())
            {
                guerrero1.Atacar(guerrero2);
                if (guerrero2.EstaVivo())
                {
                    guerrero2.Atacar(guerrero1);
                }
            }

            if (guerrero1.EstaVivo())
            {
                Console.WriteLine($"{guerrero1} es el ganador.");
            }
            else
            {
                Console.WriteLine($"{guerrero2} es el ganador.");
            }
        }
    }
} 

