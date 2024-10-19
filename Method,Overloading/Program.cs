namespace Method_Overloading;
using static System.Console;

internal class Program
{
    static void Main(string[] args)
    {
        int[] array = { 0, 3, 8, 9, 4 };

        int minElement = Element(array);

        Write("Arrayin en kicik elementi: " + minElement);
    }

    static int Element(int[] arr)
    {
        int min = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
}







