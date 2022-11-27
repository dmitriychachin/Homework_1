Console.WriteLine("Введите число");

int num = Int32.Parse(Console.ReadLine());

for (int i = 2; i < num; i = i + 2)
{
    Console.Write($"{i},");
}

Console.Write($"{num}");