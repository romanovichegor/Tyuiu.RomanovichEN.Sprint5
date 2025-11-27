using System.IO;
using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RomanovichEN.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            string strx = File.ReadAllText(path);
            strx = strx.Replace('.', ',');
            string[] strings = strx.Split(' ');
            foreach (string s in strings)
            {
                int IntPart = (int)Math.Floor(double.Parse(s));
                if (Prime(IntPart))
                {
                    if (IntPart > res)
                    {
                        res = IntPart;
                    }
                }
            }
            bool Prime(int number)
            {
                if (number < 2) return false;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            return res;
        }
    }
}
