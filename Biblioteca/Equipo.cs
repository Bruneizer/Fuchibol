namespace Biblioteca.Sesion;

public class Equipo 
{

public List<Jugador> jugador = new List<Jugador>();
public List<Sesion> sesion = new List<Sesion>();

public void Entrenar()
{

}
public double GetPotencia()
{
    return jugador  
            .OrderByDescending(j => j.Potencia)
            .Take(2)
            .Sum(j => j.Potencia);
    
}
public double GetPrecision()
{
    return jugador
        .Sum(j => (3 * j.GetPrecision()) + j.HabilidadPases);
}

public double GetVision()
{
     return jugador
            .Sum(j => j.GetVisionGeneral());
}
}
