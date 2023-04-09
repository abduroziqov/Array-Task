namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0, newArray = 0;
            GetNumber(ref row);
            FillArray(row, ref newArray);                     
        }
        public static int GetNumber(ref int row)
        {
            Console.Write("Enter row length: ");
            row = int.Parse(Console.ReadLine());
            return row;
        }
        public static int FillArray(int row,ref int newArray)
        {
            Random random = new Random();
            int[] array = new int[row];

            for (int i = 0; i < row; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write($"[ {array[i]} ] ");
            }
            Console.WriteLine();

             newArray = array[0];

            for (int i = 1; i < row; i ++)
            {
                Console.Write($"[ {array[i]} ] ");
                
            }
            Console.Write($"[ {newArray} ]");
            return newArray;
        }
    }
}