
namespace Biblioteca;

public class Jugador
{
public double VisionJuego { get; set; }
public double VisionCompañeros { get; set; }
public double Potencia { get; set; }
public double HabilidadPases { get; set; }
public ITipoJugador TipoJugador { get; set; }

    public double GetPrecision() => TipoJugador.GetPrecision(this);
    public double GetVisionGeneral() => TipoJugador.GetVisionGeneral(this);

    public void AplicarEntrenamientoFisico() => TipoJugador.AplicarEntrenamientoFisico(this);
    public void AplicarEntrenamientoLirico() => TipoJugador.AplicarEntrenamientoLirico(this);
    public void AplicarEntrenamientoTactico() => TipoJugador.AplicarEntrenamientoTactico(this);
}