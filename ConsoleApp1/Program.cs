public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!!!");
    }

    private static double CalculateAverage(int[] arr)
    {
        double avg = 0;
        foreach(int number in arr)
        {
            avg += number;
        }
        return avg/arr.Length;
    }

    private static int GetMax(int[] arr)
    {
        return arr.Max();
    }
}