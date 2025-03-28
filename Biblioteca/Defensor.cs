
namespace Biblioteca;
public class Defensor : ITipoJugador
{
    public double Quite { get; set; }
    public double GetPrecision(Jugador jugador)
    {
        return Quite;
    } 
    public double GetVisionGeneral(Jugador jugador)
    {
        return jugador.VisionCompañeros + jugador.VisionJuego;
    }
    public void AplicarEntrenamientoFisico(Jugador jugador)
    {
        jugador.Potencia += 1;
        jugador.HabilidadPases += 0.5;
        Quite += 0.5;
    }

    public void AplicarEntrenamientoLirico(Jugador jugador)
    {
        jugador.HabilidadPases += 1;
        jugador.VisionJuego += 0.5;
    }

    public void AplicarEntrenamientoTactico(Jugador jugador)
    {
        jugador.VisionJuego += 0.5;
        jugador.VisionCompañeros += 1;
    }

}