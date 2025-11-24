using Tyuiu.RomanovichEN.Sprint5.Task1.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int start = -5;
        int end = 5;
        Console.WriteLine("start: " + start);
        Console.WriteLine("end: " + end);
        Console.WriteLine("res:");
        string res = ds.SaveToFileTextData(start, end);
        Console.WriteLine("File:" + res);
        Console.ReadKey();
    }
}