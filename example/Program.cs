// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void amountNull(int M)
{
      int count = 0;
    for (var i = 0; i < M; i++)
    {
      Console.Write("Введите число: ");
      int Number = int.Parse(Console.ReadLine()!);
      if (Number> 0) count++;
    }
    Console.WriteLine(count+" - количество чисел больше нуля");
}
amountNull(5);
