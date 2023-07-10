internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        SujetoConcreto sujeto = new SujetoConcreto();

        ObserverConcreto observer1 = new ObserverConcreto("Youtube", sujeto);
        ObserverConcreto observer2 = new ObserverConcreto("Facebook", sujeto);
        ObserverConcreto observer3 = new ObserverConcreto("Instagram", sujeto);

        sujeto.Añadir(observer1);
        sujeto.Añadir(observer2);
        sujeto.Añadir(observer3);

        sujeto.Estado = "Actualizacion pendiente";
        sujeto.Estado = "Actualizando";

        sujeto.Quitar(observer2);
        sujeto.Estado = "Actualizada";

        Console.ReadLine();
    }
}