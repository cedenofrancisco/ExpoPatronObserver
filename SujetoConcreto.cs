public class SujetoConcreto : Isujeto
{
    private List<IObserver> observers = new List<IObserver>();
    private string estado;

    public string Estado
    {
        get
        {
            return estado;
        }
        set
        {
            estado = value;
            Notificar();
        }

    }
    public void Añadir(IObserver observer)
    {
        observers.Add(observer);
    }
    public void Quitar(IObserver observer)
    {
        observers.Remove(observer);
    }
    public void Notificar()
    {
        foreach (IObserver observer in observers)
        {
            observer.Actualizar();
        }
    }
}