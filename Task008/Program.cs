Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int num = 2;
while(num <= N)
{
    Console.Write($"{num};");
    num = num +2;
}
