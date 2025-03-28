namespace Biblioteca.Sesion;


public class SesionLirica : Sesion
{
    public override void AplicarA(Jugador jugador) => jugador.AplicarEntrenamientoLirico();
}