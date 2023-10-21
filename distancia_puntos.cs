using System;

public class Punto
{
    private decimal x;
    private decimal y;
    private decimal z;

    public Punto(decimal x, decimal y)
    {
        this.x = x;
        this.y = y;
    }

    public Punto(decimal x, decimal y, decimal z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public double MedirDistancia(Punto puntoDestino)
    {
        if (puntoDestino == null) throw new ArgumentNullException("puntoDestino");

        if (this.z == 0 && puntoDestino.z == 0)
        {
            return Math.Sqrt((double)((puntoDestino.x - this.x) * (puntoDestino.x - this.x) + (puntoDestino.y - this.y) * (puntoDestino.y - this.y)));
        }
        else
        {
            return Math.Sqrt((double)((puntoDestino.x - this.x) * (puntoDestino.x - this.x) + (puntoDestino.y - this.y) * (puntoDestino.y - this.y) + (puntoDestino.z - this.z) * (puntoDestino.z - this.z)));
        }
    }
}

class Program
{
    static void Main()
    {
        // Puntos en 2D
        Punto puntoOrigen2D = new Punto(1, 2);
        Punto puntoDestino2D = new Punto(4, 6);

        double distancia2D = puntoOrigen2D.MedirDistancia(puntoDestino2D);
        Console.WriteLine($"La distancia en 2D es: {distancia2D}");

        // Puntos en 3D
        Punto puntoOrigen3D = new Punto(1, 2, 3);
        Punto puntoDestino3D = new Punto(4, 6, 8);

        double distancia3D = puntoOrigen3D.MedirDistancia(puntoDestino3D);
        Console.WriteLine($"La distancia en 3D es: {distancia3D}");
    }
}
