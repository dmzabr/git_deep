Console.WriteLine("Введите первое число: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number > max)
    max = number;

if (number2 > max)
    max = number2;

Console.WriteLine("Большее число - " + max);
