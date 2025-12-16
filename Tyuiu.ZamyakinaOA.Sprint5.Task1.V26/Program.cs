using Tyuiu.ZamyakinaOA.Sprint5.Task1.V26.lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int startValue = -5;
        int stopValue = -5;

        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Замякина О.А. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнила: Замякина Олеся Андреевна | ПКТб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана функция, произвести табулирование на заданном диапазоне [-5;5]     *");
        Console.WriteLine("* с шагом 1.                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("startValue = " + startValue);
        Console.WriteLine("stopValue = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}