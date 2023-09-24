Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if(number == 1)
{
    Console.WriteLine("Сегодня понедельник!");
}
else if(number == 2)
{
    Console.WriteLine("Сегодня вторник!");
}
else if(number == 3)
{
    Console.WriteLine("Сегодня среда!");
}
else if(number == 4)
{
    Console.WriteLine("Сегодня четверг!");
}
else if(number == 5)
{
    Console.WriteLine("Сегодня пятница!");
}
else if(number == 6)
{
    Console.WriteLine("Сегодня суббота!");
}
else if(number == 7)
{
    Console.WriteLine("Сегодня воскресенье!");
}
else
{
    Console.WriteLine("Введите число от 1 до 7!");
}