using System.Collections.Generic;

namespace Primera.Libreria
{
    public class OperacionFabrica
    {
        private Dictionary<string, IOperacion> _operacions;  
        public OperacionFabrica(Dictionary<string, IOperacion> operacions)
        {
            _operacions = operacions;
        }

        public  IOperacion CrearOperacion(string operador)
        {
            return _operacions[operador];
        }
    }
}