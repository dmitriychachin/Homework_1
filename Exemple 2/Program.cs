Console.WriteLine("Введите число №1");
int num1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите число №2");
int num2 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите число №3");
int num3 = Int32.Parse(Console.ReadLine());

int max = num1;

if (max < num2){
    max = num2;
} else if (max < num3){
    max = num3;
} else {
    max = max;
}
Console.WriteLine($"max = {max}");