using System;
using Tyuiu.BazilevichAV.Sprint5.Task1.V4.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #5                                               *");
Console.WriteLine("* Тема: Запись набора данных в текстовый файл             *");
Console.WriteLine("* Задание #1                                              *");
Console.WriteLine("* Вариант #4                                              *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine("Начало шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

string res = ds.SaveToFileTextData(startValue, stopValue);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();