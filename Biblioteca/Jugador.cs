namespace Biblioteca;

public class Jugador
{
public double VisionJuego { get; set; }
public double VisionCompañeros { get; set; }
public double Potencia { get; set; }
public double HabilidadPases { get; set; }

public double GetPrecision(Jugador jugador)
{
    return 2;

}

public double GetVisionGeneral()
{
    return 2;
}
public void AplicarEntrenamientoFisico()
{

}
public void AplicarEntrenamientoLirico()
{

}
public void AplicarEntrenamientoTactico()
{

}



}