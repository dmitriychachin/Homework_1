Console.WriteLine ("Введите число");

int num = Int32.Parse(Console.ReadLine());

int result = num % 2;

if (result == 0){
    Console.WriteLine($"Число {num} четное");
} else {
    Console.WriteLine($"Число {num} нечетное");
}