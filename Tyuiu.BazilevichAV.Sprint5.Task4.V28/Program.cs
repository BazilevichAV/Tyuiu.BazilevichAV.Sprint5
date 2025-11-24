using System;
using Tyuiu.BazilevichAV.Sprint5.Task4.V28.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #5                                               *");
Console.WriteLine("* Тема: Чтение данных из текстового файла                 *");
Console.WriteLine("* Задание #4                                              *");
Console.WriteLine("* Вариант #28                                             *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

string path = args.Length > 0 ? args[0] : @"C:\DataSprint5\InPutDataFileTask4V28.txt";
Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

double res = ds.LoadFromDataFile(path);
Console.WriteLine("Ответ: " + res);
Console.WriteLine("Файл создан: " + path);
Console.WriteLine("");
Console.ReadKey();