using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NeupokoevSV.Sprint3.Task3.V9.Lib
{
    public class DataService : ISprint3Task3V9
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach(char c in value)
            {
                if ((c == '4') || (c == '5') || (c == '6'))
                {
                    value = value.Replace(c, item);
                }
            }
            return value;
        }
    }
}
