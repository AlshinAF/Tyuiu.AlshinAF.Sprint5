using Tyuiu.AlshinAF.Sprint5.Task2.V21.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнил: Альшин А. Ф. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема:  Класс File. Запись набора данных в текстовый файл                *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль     *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int rows = 3;
int colums = 3;
int[,] mtrx = new int[rows, colums];
Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Console.Write($"Введите {i},{j} элементов массива: ");
        mtrx[i, j] = Convert.ToInt32(Console.ReadLine());

    }
}
Console.WriteLine("\nМассив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");
    }
    Console.WriteLine();

}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.SaveToFileTextData(mtrx);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
Console.ReadKey();