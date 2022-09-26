// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write ("Введите любое количество чисел через пробел:");
string line = Console.ReadLine ()!; 
string[] parts = line.Split (' '); 
int[] numbers = new int[parts.Length];

for (int i = 0; i < numbers.Length; i++)
numbers[i] = int.Parse (parts[i]);

int CountPositiveNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count ++;
        }
    }
    return count;
}
Console.Write($"Колличество положительных чисел = {CountPositiveNumbers(numbers)}");
