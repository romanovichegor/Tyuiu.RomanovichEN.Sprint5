using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RomanovichEN.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            strx = strx.Replace('.',',');
            double x = double.Parse(strx);
            double sinx2 = Math.Sin(Math.Pow(x, 2));
            double res = x / (2 * x) + sinx2;
            res = Math.Round(res, 3);
            return res; 
        }
    }
}
