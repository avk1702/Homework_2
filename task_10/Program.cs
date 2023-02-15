//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// Решение без метода с Random
Random rnd = new Random();
int value = rnd.Next(100,999);
Console.WriteLine(value);

int a = value / 100;
int b = value / 10;
int ab = b - a * 10; 

System.Console.WriteLine(ab);