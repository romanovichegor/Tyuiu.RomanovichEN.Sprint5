using Tyuiu.RomanovichEN.Sprint5.Task7.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask7V22.txt";
        Console.WriteLine("File: "+ ds.LoadDataAndSave(path));
    }
}