using System.IO;
using System.Net;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RomanovichEN.Sprint5.Task1.V4.Lib
{
    public class DataService : ISprint5Task1V4
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string stry;

            for (int x = startValue; x <= stopValue; x++)
            {
                double cosx = Math.Cos(x);
                if (x + 1 != 0)
                {
                    y = Math.Round(cosx / (x + 1) - cosx * 1.3 + 3 * x,2);
                    stry = Convert.ToString(y);
                }
                else
                {
                    y = 0;
                    stry = Convert.ToString(y);
                }
                if (x != stopValue)
                {
                    File.AppendAllText(path, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stry);
                }
            }
            return path;
        }
    }
}
