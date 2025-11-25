using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RomanovichEN.Sprint5.Task3.V1.Lib
{
    public class DataService : ISprint5Task3V1
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double y = Math.Round((Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2)),3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }

    }
}
