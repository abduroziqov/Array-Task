namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            GetNumber(ref row);
            FillArray(row);
        }
        public static void GetNumber(ref int row)
        {
            Console.Write("Enter row value=> ");
            row = int.Parse(Console.ReadLine());
        }
        public static void FillArray(int row)
        {
            Random random = new Random();
            int[] array = new int[row];

            for (int i = 0; i < row; i++)
            {

                array[i] = random.Next(1, 10);
                Console.Write($"[ {array[i]} ] ");

            }
            Console.WriteLine();

            if (array[0] == 6 || array[row - 1] == 6)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }              
        }
    }
}