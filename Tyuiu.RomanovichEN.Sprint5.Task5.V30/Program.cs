using Tyuiu.RomanovichEN.Sprint5.Task5.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask5V30.txt";
        Console.WriteLine(ds.LoadFromDataFile(path));
        Console.ReadKey();
    }
}