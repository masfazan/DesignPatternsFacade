using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Fachada2
{
    public class Facade
    {
        protected Subsystem1 _subsystem1;
        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }
        // Os métodos da Facade são atalhos convenientes para a funcionalidade sofisticada
        // dos subsistemas. No entanto, os clientes têm acesso apenas a uma
        // fração das capacidades de um subsistema.

        //principal operação oferecida pela fachada. Ele invoca métodos dos subsistemas para realizar as ações.
        public string Operation()
        {
            string result = "Facade inicializa subsistemas:\n";
            result += this._subsystem1.operation1();
            result += this._subsystem2.operation1();
            result += "A fachada ordena aos subsistemas que realizem a ação:\n";
            result += this._subsystem1.operationN();
            result += this._subsystem2.operationZ();
            return result;
        }
    }
}
