public class Forecast
{
    public double Predict(double value, double rate, int years)
    {
        if(years == 0)
        {
            return value;
        }
        return Predict(value * (1+rate), rate, years-1);
    }
}