namespace Biblioteca;

public interface  ItipoJugador
{
public double GetPrecision (Jugador jugador)
{
    return 2;
}
public  double GetVisionGeneral (Jugador jugador)
{
    return 2;
}
public void AplicarEntranmientoFisico(Jugador jugador);

public void AplicarEntranmientoLirico(Jugador jugador);
public void AplicarEntranmientoTactico(Jugador jugador);

}