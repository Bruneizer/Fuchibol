using Biblioteca;

public class Atacante
{
    public double Anotacion  { get; set; }

    public double GetPresicion(Jugador jugador)
    {
        return 2;
    }
    public double GetVisionGeneral(Jugador jugador)
    {
        return 2;
    }
    public void AplicarEntrenamientoFisico(Jugador jugador)
    {
    }
    public void AplicarEntrenamientoLirico(Jugador jugador)
    {
        jugador.Potencia += 1;
        jugador.HabilidadPases += 0.5;
        
    }
    public void AplicarEntranmientoTactico (Jugador jugador)
    {
        jugador.HabilidadPases += 0.5;
        jugador.VisionJuego += 0.5;
        jugador.VisionCompañeros += 0.5; 

    }
}