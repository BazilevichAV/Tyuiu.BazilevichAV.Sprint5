using System;
using Tyuiu.BazilevichAV.Sprint5.Task5.V16.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #5                                               *");
Console.WriteLine("* Тема: Чтение набора данных из текстового файла          *");
Console.WriteLine("* Задание #5                                              *");
Console.WriteLine("* Вариант #16                                             *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

string path = args.Length > 0 ? args[0] : @"C:\DataSprint5\InPutDataFileTask5V16.txt";
Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

double res = ds.LoadFromDataFile(path);
Console.WriteLine("Ответ: " + res);
Console.WriteLine("Файл создан: " + path);
Console.WriteLine("");
Console.ReadKey();