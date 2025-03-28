namespace Biblioteca.Sesion;

public abstract class Sesion
{
    public string Nombre { get; set; }

    public abstract void AplicarA(Jugador jugador);

}