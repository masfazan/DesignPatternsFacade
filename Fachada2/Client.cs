

namespace Fachada2
{
    public class Client
    {
        // O código do cliente trabalha com subsistemas complexos por meio de uma interface simples
        // fornecida pela Facade. Quando uma fachada gerencia o ciclo de vida
        // do subsistema, o cliente pode nem mesmo saber sobre a existência
        // do subsistema. Essa abordagem permite manter a complexidade sob
        // controle.
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }
}
