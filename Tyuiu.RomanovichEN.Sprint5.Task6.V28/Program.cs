using Tyuiu.RomanovichEN.Sprint5.Task6.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask6V28.txt";
        Console.WriteLine($"Result: {ds.LoadFromDataFile(path)}");
    }
}