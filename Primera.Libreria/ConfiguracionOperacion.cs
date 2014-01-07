using System.Collections.Generic;

namespace Primera.Libreria
{
   public class ConfiguracionOperacion
    {
        public static OperacionFabrica ObtenerFabrica()
        {
            return new OperacionFabrica(new Dictionary<string, IOperacion>
            {
                {"+", new Suma()}, 
                {"-", new Resta()},
                {"*", new Multiplicacion()},

            });
        }
    }
}