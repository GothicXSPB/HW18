    internal class Array
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 4, -20, 3, 54, 0, -5, 18, 56 };

        array = SortBuble(array);
        WriteResult(array);
    }

    private static int[] SortDescending(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int maxIndex = i;
            for (int j = i; j < array.Length; j++)
            {
                if (array[maxIndex] < array[j])
                {
                    maxIndex = j;
                }
            }
            int temp = array[maxIndex];
            array[maxIndex] = array[i];
            array[i] = temp;
        }
        return array;
    }

    private static int[] SortBuble(int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                }
            }
        }
        return array;
    }

    private static void WriteResult(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
}
