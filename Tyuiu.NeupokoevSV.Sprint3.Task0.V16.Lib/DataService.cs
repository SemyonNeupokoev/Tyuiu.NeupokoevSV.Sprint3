using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NeupokoevSV.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sum = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sum = sum * Math.Pow(((double)value / i), 3);
            }
            return Math.Round(sum, 3);
        }
    }
}
