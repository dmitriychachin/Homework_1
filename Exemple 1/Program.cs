Console.WriteLine("Введите первое число:");
int num1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Int32.Parse(Console.ReadLine());

if(num1 > num2){
    Console.WriteLine($"max = {num1}");
}else if (num1 < num2){
    Console.WriteLine($"max = {num2}");
}else{
    Console.WriteLine($"max = {num1}");
};