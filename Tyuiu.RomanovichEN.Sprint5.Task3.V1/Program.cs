using Tyuiu.RomanovichEN.Sprint5.Task3.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 3;
        Console.WriteLine("x:" + x);
        Console.WriteLine("file:" + ds.SaveToFileTextData(x));
        Console.ReadKey();
    }
}