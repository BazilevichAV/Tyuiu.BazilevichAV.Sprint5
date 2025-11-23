using System;
using Tyuiu.BazilevichAV.Sprint5.Task2.V12.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #5                                               *");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)             *");
Console.WriteLine("* Задание #2                                              *");
Console.WriteLine("* Вариант #12                                              *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int[,] matrix = new int[3, 3] { { -5, -5, 9 },
                                { -7, 3, -4 },
                                { 8, 7, 9 }, };

int rows = matrix.GetUpperBound(0) + 1;
int columns = matrix.Length / rows;

Console.WriteLine("Массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }

    Console.WriteLine();
}

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

string res = ds.SaveToFileTextData(matrix);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();