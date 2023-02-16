//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да 7 -> да 1 -> нет
// решение с Random c методом

Random rnd = new Random();
int numberOfweek = rnd.Next(1,7);
Console.WriteLine(numberOfweek);
bool DayOfRest(int numberOfweek)
{
  return numberOfweek == 6 || numberOfweek == 7;
}
Console.WriteLine(DayOfRest(numberOfweek));
