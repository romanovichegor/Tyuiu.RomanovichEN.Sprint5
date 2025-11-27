using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RomanovichEN.Sprint5.Task6.V28.Lib
{
    public class DataService : ISprint5Task6V28
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    foreach (string s in str.Split(' '))
                    {
                        if (int.TryParse(s, out int x)&& x  >= 1000 && x <= 9999)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
