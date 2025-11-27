using System.IO;
using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.RomanovichEN.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string pathout = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V22.txt"); 
            FileInfo fileexists = new FileInfo(pathout);
            if (fileexists.Exists) { File.Delete(pathout); }
            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    foreach (char c in str)
                    {
                        if (char.IsPunctuation(c))
                        {
                            res += '#';
                        }
                        else
                        {
                            res += c;
                        }
                    }
                }
            }
            File.AppendAllText(pathout, res);
            return pathout;
        }
    }
}
