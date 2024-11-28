﻿using Tyuiu.AlshinAF.Sprint5.Task1.V27.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнил: Альшин А. Ф. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема:  Класс File. Запись набора данных в текстовый файл                *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #27                                                             *");
Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана функция F(x) = (3x-1.5)/(sin x - 3+x)+2, произвести табулирование  *");
Console.WriteLine("* f(x) на диапозоне [-5; 5] с шагом 1. Произвести проверку деления на 0.  *");
Console.WriteLine("* При делении на 0 вернуть значение 0. Результат сохранить в текст. файл и*");
Console.WriteLine("* вывесим на консоль в таблицу значение. Значение округлить до 2 знаков   *");
Console.WriteLine("* после запятой.                                                          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int stop = 5;
int start = -5;
Console.WriteLine("startValue = " + start);
Console.WriteLine("stoptValue = " + stop);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.SaveToFileTextData(start, stop);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();