namespace Primera.Libreria
{
    public class Resta : IOperacion
    {
        public double Operar(int pnumero, int snumero)
        {
            return pnumero - snumero;
        }
    }
}