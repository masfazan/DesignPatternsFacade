using Fachada2;

public class Program
{
    static void Main(string[] args)
    {
        // O código do cliente pode já ter alguns objetos do subsistema criados.
        // Nesse caso, pode valer a pena inicializar a Facade com esses objetos
        // em vez de permitir que a Facade crie novas instâncias.
        Subsystem1 subsystem1 = new Subsystem1();
        Subsystem2 subsystem2 = new Subsystem2();
        Facade facade = new Facade(subsystem1, subsystem2);
        Client.ClientCode(facade);
    }
}