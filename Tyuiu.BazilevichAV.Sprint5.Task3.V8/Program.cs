using System;
using Tyuiu.BazilevichAV.Sprint5.Task3.V8.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #5                                               *");
Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл     *");
Console.WriteLine("* Задание #3                                              *");
Console.WriteLine("* Вариант #8                                              *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int x = 3;
Console.WriteLine("x = " + x);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

string res = ds.SaveToFileTextData(x);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();