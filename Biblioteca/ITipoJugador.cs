namespace Biblioteca;

public interface  ITipoJugador
{
public double GetPrecision (Jugador jugador);

public  double GetVisionGeneral (Jugador jugador);

public void AplicarEntrenamientoFisico(Jugador jugador);

public void AplicarEntrenamientoLirico(Jugador jugador);
public void AplicarEntrenamientoTactico(Jugador jugador);

}