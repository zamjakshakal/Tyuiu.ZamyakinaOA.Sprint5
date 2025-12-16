using Tyuiu.ZamyakinaOA.Sprint5.Task3.V6.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint5.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Введите элемент [{i},{j}]:");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.SaveToFileTextData(array);
            //Console.WriteLine(result);
            Console.WriteLine("Файл " + result + " создан.");
            Console.ReadKey();
        }
    }
}