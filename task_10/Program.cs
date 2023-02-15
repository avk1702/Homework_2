//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// Решение с методом и с Random

Random rnd = new Random();
int value = rnd.Next(100,999);
Console.WriteLine(value);

int Middle (int value)
{
  int a = value / 100;
  int b = value / 10;
  int result = b - a * 10;
  return result;
}

System.Console.WriteLine(Middle (value));