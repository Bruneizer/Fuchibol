using Biblioteca;
using Biblioteca.Sesion;
public class JugadorTests
{
    [Fact]
    public void AplicarEntrenamientoFisico()
    {
        var atacante = new Atacante { Anotacion = 5 };
        var jugador = new Jugador { Potencia = 10, HabilidadPases = 5, TipoJugador = atacante };

        jugador.AplicarEntrenamientoFisico();

        Assert.Equal(11, jugador.Potencia);
        Assert.Equal(5.5, jugador.HabilidadPases);
    }
}
  