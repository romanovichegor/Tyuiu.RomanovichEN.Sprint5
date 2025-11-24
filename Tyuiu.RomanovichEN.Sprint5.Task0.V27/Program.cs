using Tyuiu.RomanovichEN.Sprint5.Task0.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 3;
        Console.WriteLine("x = "+x);
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("file:" + res);
        Console.ReadKey();

    }
}