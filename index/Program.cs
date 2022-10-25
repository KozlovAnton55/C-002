internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 123, 234, 356, 47, 58, 69, 74, 86 };
        int n = array.Length;
        int find = 47;
        int index = 0;

        while (index < n)
        {
            if (array[index] == find)
            {
                Console.WriteLine(index);
            }

            index++;

        }
    }
}