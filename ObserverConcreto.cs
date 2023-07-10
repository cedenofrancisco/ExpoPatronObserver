public class ObserverConcreto : IObserver
{
    private string nombre;
    private SujetoConcreto sujeto;

    public ObserverConcreto(string nombre, SujetoConcreto sujeto)
    {
        this.nombre = nombre;
        this.sujeto = sujeto;
    }
    public void Actualizar()
    {
        Console.WriteLine("La aplicacion {0} está en estado: {1}", nombre, sujeto.Estado);
    }
}