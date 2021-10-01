namespace Converting
{
    public class Converter
    {
        public double usd, eur;
        public Converter(double usd, double eur)
        {
            this.usd = usd;
            this.eur = eur;
        }
        public double UahToUsd(double value)
        {
            return value / usd;
        }
        public double UahToEur(double value)
        {
            return value / eur;
        }
        public double UsdToUah(double value)
        {
            return value * usd;
        }
        public double EurToUah(double value)
        {
            return value * eur;
        }
    }
}
