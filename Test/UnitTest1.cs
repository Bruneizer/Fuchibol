using Biblioteca;
using Biblioteca.Sesion;
public class JugadorTests
{
    [Fact]
    public void AplicarEntrenamientoFisico_IncrementaPotenciaYHabilidadPases()
    {
        var atacante = new Atacante { Anotacion = 5 };
        var jugador = new Jugador { Potencia = 10, HabilidadPases = 5, TipoJugador = atacante };

        jugador.AplicarEntrenamientoFisico();

        Assert.Equal(11, jugador.Potencia);
        Assert.Equal(5.5, jugador.HabilidadPases);
    }

    [Fact]
    public void GetPrecision_DevuelveValorCorrectoSegunTipoJugador()
    {
        var atacante = new Atacante { Anotacion = 7 };
        var jugador = new Jugador { TipoJugador = atacante };

        Assert.Equal(7, jugador.GetPrecision());
    }
}

public class AtacanteTests
{
    [Fact]
    public void AplicarEntrenamientoLirico_IncrementaHabilidadPasesYAnotacion()
    {
        var atacante = new Atacante { Anotacion = 5 };
        var jugador = new Jugador { HabilidadPases = 5, TipoJugador = atacante };

        atacante.AplicarEntrenamientoLirico(jugador);

        Assert.Equal(6, jugador.HabilidadPases);
        Assert.Equal(5.5, atacante.Anotacion);
    }
}

public class DefensorTests
{
    [Fact]
    public void AplicarEntrenamientoFisico_IncrementaPotenciaHabilidadPasesYQuite()
    {
        var defensor = new Defensor { Quite = 4 };
        var jugador = new Jugador { Potencia = 10, HabilidadPases = 5, TipoJugador = defensor };

        defensor.AplicarEntrenamientoFisico(jugador);

        Assert.Equal(11, jugador.Potencia);
        Assert.Equal(5.5, jugador.HabilidadPases);
        Assert.Equal(4.5, defensor.Quite);
    }
}

public class EquipoTests
{
    [Fact]
    public void GetPotencia_DevuelveSumaDeDosJugadoresMasFuertes()
    {
        var equipo = new Equipo();
        equipo.jugador.Add(new Jugador { Potencia = 8 });
        equipo.jugador.Add(new Jugador { Potencia = 15 });
        equipo.jugador.Add(new Jugador { Potencia = 20 });

        double potencia = equipo.GetPotencia();

        Assert.Equal(35, potencia);
    }

  [Fact]
public void GetVision_DevuelveSumaTotalDeVision()
{
    var equipo = new Equipo();
    equipo.jugador.Add(new Jugador { 
        VisionJuego = 5, 
        VisionCompañeros = 3, 
        TipoJugador = new Atacante() // Asignamos un tipo de jugador
    });
    equipo.jugador.Add(new Jugador { 
        VisionJuego = 4, 
        VisionCompañeros = 2, 
        TipoJugador = new Defensor() // Asignamos un tipo de jugador
    });

    double vision = equipo.GetVision();

    Assert.Equal(14, vision);
}
}
