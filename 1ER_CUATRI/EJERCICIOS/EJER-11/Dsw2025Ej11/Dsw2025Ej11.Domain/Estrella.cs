namespace Dsw2025Ej11.Domain;

public class Estrella
{
    public int Edad { get; set; }
    public int TiempoDeVida { get; set; }
    public Luminosidad Luminosidad { get; set; }

    public Estrella()
    {
        var random = new Random();
        var vida = random.Next(50, 300);
        TiempoDeVida = vida;
        Edad = 0;
    }

    public void EvolucionEstelar()
    {
        if (Edad <= TiempoDeVida * 0.1)
        {
            Luminosidad = Luminosidad.Media;
        }
        else if (Edad > TiempoDeVida * 0.1 && Edad <= TiempoDeVida * 0.8)
        {
            Luminosidad = Luminosidad.Alta;
        }
        else
        {
            Luminosidad = Luminosidad.Baja;
        }

        if (Edad <= TiempoDeVida)
        {
            Edad++;
        }
        else
        {
            Luminosidad = Luminosidad.Nula;
        }
    }
}
