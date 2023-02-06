// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


System.Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 & number < 6) 
{
    System.Console.WriteLine("Это не выходной день");
}
else if (number < 1 || number > 7)
{
    System.Console.WriteLine("Дня не существует"); 
}
else
{
   System.Console.WriteLine("Это выходной день");
}
