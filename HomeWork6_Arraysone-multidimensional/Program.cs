//1. Написати програму, яка обчислює прибуток фірми за 6 місяців. Користувач запроваджує прибуток фірми за кожен місяць.

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        int month = 6
//        decimal[] profits = new decimal[month];
//        decimal totalProfit = 0;

//        for (int i = 0; i < profits.Length; i++)
//        {
//            while (true)
//            {
//                Console.Write($"Введіть прибуток фірми за місяць {i + 1} першого півріччя 2024 року:  $");
//                string input = Console.ReadLine();

//                if (decimal.TryParse(input, out decimal profit))
//                {
//                    profits[i] = profit;
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Невірний формат. Будь ласка, введіть числове значення.");
//                }
//            }
//            totalProfit += profits[i];
//        }

//        Console.WriteLine("Введені прибутки:");
//        for (int i = 0; i < profits.Length; i++)
//        {
//            Console.WriteLine($"Місяць {i + 1}: {profits[i]} $");
//        }
//        Console.WriteLine($"Сумарний прибуток за перше півріччя 2024 року: {totalProfit} $");
//    }

//}

//2. Користувач вводить прибуток фірми протягом року (12 місяців). Необхідно визначити місяць, у якому прибуток був максимальний і місяць, у якому прибуток був мінімальний.
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        int month = 12;
//        decimal[] profits = new decimal[month];
//        decimal maxProfit = decimal.MinValue;
//        int maxMonth = -1;
//        decimal minProfit = decimal.MaxValue;
//        int minMonth = -1;

//        for (int i = 0; i < profits.Length; i++)
//        {
//            while (true)
//            {
//                Console.Write($"Введіть прибуток фірми за місяць {i + 1} 2024 року:  $");
//                string input = Console.ReadLine();

//                if (decimal.TryParse(input, out decimal profit))
//                {
//                    profits[i] = profit;
//                    
//                    if (profits[i] > maxProfit)
//                    {
//                        maxProfit = profits[i];
//                        maxMonth = i + 1;
//                    }
//                    if (profits[i] < minProfit)
//                    {
//                        minProfit = profits[i];
//                        minMonth = i + 1;
//                    }

//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Невірний формат. Будь ласка, введіть числове значення.");
//                }
//            }
//        }

//        // Виведення результатів
//        Console.WriteLine($"Максимальний прибуток: {maxProfit} в місяці {maxMonth}");
//        Console.WriteLine($"Мінімальний прибуток: {minProfit} в місяці {minMonth}");
//    }
//}

//3. Стиснути (зрушити елементи) масив, видаливши з нього всі 0, і заповнити елементи, що звільнилися праворуч, значеннями -1. (Потрібно зробити через перестворення масиву)
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;

//        int arraySize = 12;
//        Random number = new Random();
//        int[] ArrayOld = new int[arraySize];

//        for (int i = 0; i < ArrayOld.Length; i++)
//        {
//            ArrayOld[i] = number.Next(0, 5);
//        }
//        Console.WriteLine("Початковий масив:");

//        foreach (int value in ArrayOld)
//        {
//            Console.Write(value + " ");
//        }
//        Console.WriteLine();

//        int[] ArrayNew = new int[ArrayOld.Length];

//        int index = 0;

//        for (int i = 0; i < ArrayOld.Length; i++)
//        {
//            if (ArrayOld[i] != 0)
//            {
//                ArrayNew[index] = ArrayOld[i];
//                index++;
//            }
//        }
//        for (int i = index; i < ArrayNew.Length; i++)
//        {
//            ArrayNew[i] = -1;
//        }
//        Console.WriteLine("Новий масив:");
//        foreach (int value in ArrayNew)
//        {
//            Console.Write(value + " ");
//        }
//    }
//}


//4. Cтворити матрицю 10 на 10, заповнити рандомними значеннями від 10 до 99
//вивести на екран:
//-вивести суму чисел головної діагоналі матриці
//- вивести мінімальне та максимальне значення побічної діагоналі матриці
//- ввести з клавіатури порядковий номер стовпця - вивести цифри з цього стовпця на екран (аналогічно зробити з рядком)
//- ввести з клавіатури порядковий номер одного стовпця і потім іншого стовпця і поміняти їх місцями в матрицю (аналогічно зробити з рядком)

using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Random number = new Random();
        int[,] matrix = new int[10, 10];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = number.Next(0, 100);
            }
        }

        Console.WriteLine("Матриця:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Сума чисел головної діагоналі
        int sumMainDiagonal = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumMainDiagonal += matrix[i, i];
        }
        Console.WriteLine($"Сума чисел головної діагоналі: {sumMainDiagonal}");

        // Мінімальне та максимальне значення побічної діагоналі
        int minSecondaryDiagonal = int.MaxValue;
        int maxSecondaryDiagonal = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int value = matrix[i, matrix.GetLength(1) - 1 - i];
            if (value < minSecondaryDiagonal) minSecondaryDiagonal = value;
            if (value > maxSecondaryDiagonal) maxSecondaryDiagonal = value;
        }
        Console.WriteLine($"Мінімальне значення побічної діагоналі: {minSecondaryDiagonal}");
        Console.WriteLine($"Максимальне значення побічної діагоналі: {maxSecondaryDiagonal}");

        // Введення та виведення стовпця
        Console.Write("Введіть порядковий номер стовпця (0-9): ");
        int columnNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"Стовпець {columnNumber}:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.WriteLine(matrix[i, columnNumber]);
        }

        // Введення та виведення рядка
        Console.Write("Введіть порядковий номер рядка (0-9): ");
        int rowNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"Рядок {rowNumber}:");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[rowNumber, j] + "\t");
        }
        Console.WriteLine();

        // Обмін двох стовпців
        Console.Write("Введіть порядковий номер першого стовпця для обміну (0-9): ");
        int firstColumn = int.Parse(Console.ReadLine());
        Console.Write("Введіть порядковий номер другого стовпця для обміну (0-9): ");
        int secondColumn = int.Parse(Console.ReadLine());

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int temp = matrix[i, firstColumn];
            matrix[i, firstColumn] = matrix[i, secondColumn];
            matrix[i, secondColumn] = temp;
        }

        Console.WriteLine("Матриця після обміну стовпців:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Обмін двох рядків
        Console.Write("Введіть порядковий номер першого рядка для обміну (0-9): ");
        int firstRow = int.Parse(Console.ReadLine());
        Console.Write("Введіть порядковий номер другого рядка для обміну (0-9): ");
        int secondRow = int.Parse(Console.ReadLine());

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[firstRow, j];
            matrix[firstRow, j] = matrix[secondRow, j];
            matrix[secondRow, j] = temp;
        }

        Console.WriteLine("Матриця після обміну рядків:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}


