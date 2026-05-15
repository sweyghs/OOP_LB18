using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("\nЗавдання 1: Одномірний масив\n");

        Console.Write("Введіть кількість елементів n: ");
        string? input = Console.ReadLine();
        int n = int.Parse(input ?? "0");

        double[] arr = new double[n];

        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"  arr[{i}] = ");
            string? elem = Console.ReadLine();
            arr[i] = double.Parse(elem ?? "0");
        }

        Console.Write("\nПочатковий масив: [ ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("]");

        int negativeCount = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] < 0) negativeCount++;
        }
        Console.WriteLine($"\nа) Кількість від'ємних елементів: {negativeCount}");

        int minAbsIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (Math.Abs(arr[i]) < Math.Abs(arr[minAbsIndex]))
                minAbsIndex = i;
        }
        Console.WriteLine($"Мінімальний за модулем елемент: arr[{minAbsIndex}] = {arr[minAbsIndex]}");

        double sumAfter = 0;
        for (int i = minAbsIndex + 1; i < n; i++)
        {
            sumAfter += Math.Abs(arr[i]);
        }
        Console.WriteLine($"б) Сума модулів елементів після нього: {sumAfter}");

        for (int i = 0; i < n; i++)
        {
            if (arr[i] < 0)
                arr[i] = arr[i] * arr[i];
        }
        Console.WriteLine("\n▶ Після заміни від'ємних квадратами:");
        Console.Write("[ ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("]");

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] > arr[j])
                {
                    double temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        Console.WriteLine("\n▶ Відсортований масив за зростанням:");
        Console.Write("[ ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("]");

        Console.WriteLine("Завдання 2: Двовимірний масив\n");

        int[,] matrix = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Початковий двовимірний масив (3x3):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        int tempCorner = matrix[0, 2];
        matrix[0, 2] = matrix[2, 0];
        matrix[2, 0] = tempCorner;

        Console.WriteLine("\nа) Після обміну верхнього правого і нижнього лівого:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        tempCorner = matrix[2, 2];
        matrix[2, 2] = matrix[0, 0];
        matrix[0, 0] = tempCorner;

        Console.WriteLine("\nб) Після обміну нижнього правого і верхнього лівого:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Програма завершена. Натисніть Enter для виходу...");
        Console.ReadLine();
    }
}