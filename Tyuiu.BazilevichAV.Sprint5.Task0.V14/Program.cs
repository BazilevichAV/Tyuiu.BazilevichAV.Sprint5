using System;
using Tyuiu.BazilevichAV.Sprint5.Task0.V14.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #5                                               *");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)             *");
Console.WriteLine("* Задание #0                                              *");
Console.WriteLine("* Вариант #14                                             *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Дано выражение вычислить его значение при x = 3,        *");
Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt*");
Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков.         *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int x = 3;
Console.WriteLine("x = " + x);

double z = (4 * Math.Pow(x, 3.0)) / (Math.Pow(x, 3.0) - 1);
z = Math.Round(z, 3);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");
Console.WriteLine("Результат = " + z);

string res = ds.SaveToFileTextData(x);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();