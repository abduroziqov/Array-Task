namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            GetNumber(ref row);
            FillArray(row);
        }
        public static int GetNumber(ref int row)
        {
            Console.Write("Enter row length: ");
            row = int.Parse(Console.ReadLine());
            return row;
        }
        public static int FillArray(int row)
        {
            Random random = new Random();
            int[] array = new int[row];

            for (int i = 0; i < row; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write($"[ {array[i]} ] ");
            }
            Console.WriteLine();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"[ {array[i]} ] ");
            }
            return row;
        }
    }
}