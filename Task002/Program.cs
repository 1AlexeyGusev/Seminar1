Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"Число {a} > числа {b}");
}
else if(a < b)
{
    Console.WriteLine($"Число {a} < числа {b}");
}
else
{
    Console.WriteLine("Числа равны");
}