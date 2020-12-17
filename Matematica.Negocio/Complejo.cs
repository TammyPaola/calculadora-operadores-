namespace Matematica.Negocio
{
    public class Complejo
    {
        

        public Complejo(double real, double imaginaria)
        {
            this.Real = real;
            this.Imaginaria = imaginaria;
           
        }

        public double Imaginaria { get; internal set; }
        public double Real { get; internal set; }
    }
}