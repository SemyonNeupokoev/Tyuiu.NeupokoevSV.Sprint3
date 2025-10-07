using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NeupokoevSV.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sum = 1;
            while(startValue <= stopValue)
            {
                sum = sum * Math.Pow(((0.5 + ((double)startValue / 5)) / (Math.Cos(value) + 0.5)), 3);
                startValue ++;
            }
            return Math.Round(sum, 3);
        }
    }
}
 