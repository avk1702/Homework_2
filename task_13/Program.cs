//Задача 13: Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

// решение с вводом числа без метода
Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
int third = 0;
while (value >= 1000)
  {
    value = value / 10;
  }
third = value % 10;
if (value < 100)
{
  Console.WriteLine(" третьей цифры в числе нет ");
}
else
{
  Console.WriteLine(third);
}


