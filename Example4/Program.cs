
// задача 2 HARD необязательная. 
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
//  Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс, среднее арифметическое.
//   Вывести эту информацию на экран.
int[,] array = CreateArray();
PrintArray(array);
Console.WriteLine("Среднее арифмитичкеское " + arifmeticSum(array));
Console.WriteLine("Наименьшее значение " + minElementArray(array));
Console.WriteLine("Наибольшое значение " + maxElementArray(array));

int[,] CreateArray()
{
    Console.Write("Введите количество строк: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов: ");
    int n = int.Parse(Console.ReadLine()!);
    int[,] array = new int[m, n];

    Random random = new Random();
    for (var i = 0; i < m; i++)
    {
        for (var j = 0; j < n; j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
    return array;
}

void PrintArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write("(" + input[i, j] + ")");

            if (j != input.GetLength(1) - 1)
                Console.Write(" ");
            if (input[i, j] < 10) Console.Write(" ");

        }
        Console.WriteLine();
    }
}

int arifmeticSum(int[,] input)
{
    int sum = 0;
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            sum += input[i, j];
        }
    }
    sum = sum / (input.GetLength(0) * input.GetLength(1));
    return sum;
}

int minElementArray(int[,] input)
{
    int min = 0;
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            if (min < input[i, j]) min = input[i, j];
        }
    }
    return min;
}
int maxElementArray(int[,] input)
{
    int max = 0;
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            if (max > input[i, j]) max = input[i, j];
        }
    }
    return max;
}