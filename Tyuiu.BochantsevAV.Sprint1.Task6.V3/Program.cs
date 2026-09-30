using Tyuiu.BochantsevAV.Sprint1.Task6.V3.Lib;
namespace Tyuiu.BochantsevAV.Sprint1.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бочанцев А.В | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил Бочанцев Артем Викторович | ИИПБ-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать строку,       *");
            Console.WriteLine("* составленную из последних букв всех слов.                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            Console.WriteLine();

            Console.Write("Введите текст -> ");
            string value = Console.ReadLine();

            string result = ds.LastLetterWord(value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();
            Console.WriteLine($"Последние буквы слов -> {result}");

            Console.ReadKey();
        }
    }
}
