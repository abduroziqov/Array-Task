
namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int row = GetNumber(); //Qiymatni methoddan qabul qildik

            int[] fillArray = FillArray(row);
            int[] fillArray2 = FillArray2(row);

            CommonEnd(fillArray2, fillArray,row);
        }
        public static int GetNumber()
        {
            Console.Write("Enter row length: ");
            int row = int.Parse(Console.ReadLine());
            return row;
        }
        public static int[] FillArray(int row)
        {
            Random random = new Random();
            int[] array = new int[row];

            for (int i = 0; i < row; i++)
            {
                array[i] = random.Next(1, 10);
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"[ {array[i]} ] ");
            }
            Console.WriteLine();
            return array;
        }
        public static int[] FillArray2(int row)
        {
            Random random = new Random();
            int[] array = new int[row];

            for (int i = 0; i < row; i++)
            {
                array[i] = random.Next(1, 10);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"[ {array[i]} ] ");
            }
            Console.WriteLine();
            return array;
        }
        public static void CommonEnd(int[] Array, int[] Array2,int row)
        {
            if (Array[0] == Array2[0] || Array[row - 1] == Array2[row - 1])
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