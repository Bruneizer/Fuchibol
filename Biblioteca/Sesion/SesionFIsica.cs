namespace Biblioteca.Sesion;

public class SessionFisica: Sesion
{
    public override void AplicarA(Jugador jugador) => jugador.AplicarEntrenamientoFisico();
}