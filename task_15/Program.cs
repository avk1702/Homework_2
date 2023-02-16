//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да 7 -> да 1 -> нет
// решение с Random без метода
Random rnd = new Random();
int numberOfweek = rnd.Next(1,7);
Console.WriteLine(numberOfweek);
if (numberOfweek == 6 || numberOfweek == 7)
{
  Console.WriteLine("Да, это выходной день ");
}
else
{
  Console.WriteLine("Нет, это не выходной день "); 
}