
namespace Biblioteca;
public class Defensor : ItipoJugador
{
    public double Quite { get; set; }
    public double GetPrecision(Jugador jugador)
    {
        return 2;
    }
    public double GetVisionGeneral(Jugador jugador)
{
        return 2;
}
    public void AplicarEntranmientoFisico(Jugador jugador)
    {
        jugador.Potencia += 1;
        jugador.HabilidadPases += 0.5;
        Quite += 0.5;
    }

    public void AplicarEntranmientoLirico(Jugador jugador)
    {
        
    }

    public void AplicarEntranmientoTactico(Jugador jugador)
    {
        jugador.VisionJuego += 0.5;
        jugador.VisionCompañeros += 1;
    }
}

