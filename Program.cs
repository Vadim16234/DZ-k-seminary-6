// Задача 41
//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// РЕШЕНИЕ

// Console.WriteLine("Введите количество чисел: ");
// int number = int.Parse(Console.ReadLine()!);

// int[] array = GetArray(number, -100, 100);
// Console.WriteLine(String.Join(", ", array));

// int[] GetArray(int size, int minValue, int maxValue){
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// int sum = 0;
// for (int i = 0; i < array.Length; i++){
//     if (array[i] >= 0){
//         sum++;
//     }
// }
// Console.WriteLine($"Количество чисел больше нуля = {sum}");




//Задача 43
//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// РЕШЕНИЕ

// Console.WriteLine("Введите значение b1: ");
// double b1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите значение k1: ");
// double k1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите значение b2: ");
// double b2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите значение k2: ");
// double k2 = int.Parse(Console.ReadLine()!);

// double x = (b2 - b1) / (k1 - k2);
// double y = x * k1 + b1;


// Console.WriteLine($"Точка пересечения двух прямых: x = {x}, y = {y} ");

