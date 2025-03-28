namespace Biblioteca.Sesion;

public class SessionTactica : Sesion
{
     public override void AplicarA(Jugador jugador) => jugador.AplicarEntrenamientoTactico();
}