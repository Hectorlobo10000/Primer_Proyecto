namespace Primera.Libreria
{
    public interface IOperacion
    {
        double Operar(int pnumero, int snumero);
    }

    public class Resta : IOperacion
    {
        public double Operar(int pnumero, int snumero)
        {
            return pnumero - snumero;
        }
    }

    public class Suma : IOperacion
    {
        public double Operar(int pnumero, int snumero)
        {
            return pnumero + snumero;
        }
    }
 
}