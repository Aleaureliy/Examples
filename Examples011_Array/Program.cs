internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 5, 6, 6, 7, 8, 9 };

        int n = array.Length;
        Console.Write("Введите число для поиска: ");
        int find = int.Parse(Console.ReadLine());

        int index = 0;

        while (index < n)
        {
            if (array[index] == find)
            {
                Console.WriteLine(index);
                break;
            }
            //index = index + 1;
            index++;
        }
    }
}