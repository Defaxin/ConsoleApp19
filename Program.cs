namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            int x = 4;
            int y = 5;
            int z = 1;
            int[] arr = { 2, 4, 6, 7, 8 };
            Console.Write($"X: {x}\nY: {y}\nZ: {z}\n");
            new Task1().Max(ref x, ref y, ref z);
            new Task2().Min(ref x, ref y, ref z);
            new Task3().ArSum(ref arr);

        }
    }
}
