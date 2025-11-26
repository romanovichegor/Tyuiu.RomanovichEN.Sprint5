using Tyuiu.RomanovichEN.Sprint5.Task4.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask4V29.txt";
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine($"Result: {res}");
    }
}