
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
        throw new NotImplementedException();
    }

    public void AplicarEntranmientoLirico(Jugador jugador)
    {
        throw new NotImplementedException();
    }

    public void AplicarEntranmientoTactico(Jugador jugador)
    {
        throw new NotImplementedException();
    }
}

