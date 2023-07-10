public interface Isujeto
{
    void Añadir(IObserver observer);
    void Quitar(IObserver observer);
    void Notificar();
}