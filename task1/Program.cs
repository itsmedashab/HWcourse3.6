// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Введите N чисел через пробел: ");

string[] line = Console.ReadLine()!.Split(' ');
int[] numbers = new int[line.Length];

for (int i = 0; i < line.Length; i++)
int.TryParse(line[i], out numbers[i]);

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0) count = count + 1;
} 

Console.Write($"Вы ввели {count} числа больше 0\n");   