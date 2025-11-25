using Tyuiu.RomanovichEN.Sprint5.Task2.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[,] array = new int[3, 3] { { 4, 9, 3}, { 5, 8, 8} , {5, 7, 5}};
        Console.WriteLine("Массив:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"{array[i,j]}  \t");
            }
            Console.WriteLine();
        }
        string res = ds.SaveToFileTextData(array);
        Console.WriteLine($"file:{res}");
        Console.ReadKey();
    }
}