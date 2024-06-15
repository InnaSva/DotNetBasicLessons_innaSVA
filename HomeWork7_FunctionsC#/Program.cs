//Завдання 1. Написати функцію, яка приймає два параметри: основу ступеня та показник ступеня, та обчислює ступінь числа на основі отриманих даних.
//using System;
//public class Program
//{
//    // Функція для обчислення ступеня числа
//    public static double Power(double baseNumber, int exponent)
//    {
//        double result = 1;
//        for (int i = 0; i < exponent; i++)
//        {
//            result *= baseNumber;
//        }
//        return result;
//    }
//    public static void Main()
//    {
//        double baseNumber = 2.0;
//        int exponent = 3;
//        double result = Power(baseNumber, exponent);
//        Console.WriteLine($"{baseNumber}^{exponent} = {result}");
//    }

//}

//Завдання 2. Написати функцію, яка отримує як параметри 2 цілих числа і повертає суму чисел з діапазону між ними.

//using System;

//public class Program
//{
//    // Функція для обчислення суми чисел у діапазоні
//    public static int SumInRange(int start, int end)
//    {
//        int sum = 0;
//        for (int i = start; i <= end; i++)
//        {
//            sum += i;
//        }
//        return sum;
//    }
//    public static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        int start = 3;
//        int end = 7;
//        int sum = SumInRange(start, end);
//        Console.WriteLine($"Сума чисел в діапазоні від {start} до {end} включно = {sum}");
//    }
//}

//Завдання 3. Число називається досконалим, якщо сума всіх його дільників дорівнює йому самому. Напишіть функцію пошуку таких чисел у введеному інтервалі.
//using System;

//public class Program
//{
//    // Функція для перевірки, чи є число досконалим
//    public static bool IsPerfectNumber(int number)
//    {
//        if (number < 2)
//        {
//            return false;
//        }

//        int sumOfDivisors = 1;

//        for (int i = 2; i <= Math.Sqrt(number); i++)
//        {
//            if (number % i == 0)
//            {
//                sumOfDivisors += i;
//                if (i != number / i)
//                {
//                    sumOfDivisors += number / i;
//                }
//            }
//        }

//        return sumOfDivisors == number;
//    }
//    public static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;

//        Console.Write("Введіть початок інтервалу: ");
//        int start = int.Parse(Console.ReadLine());

//        Console.Write("Введіть кінець інтервалу: ");
//        int end = int.Parse(Console.ReadLine());

//        Console.WriteLine($"Досконалі числа в інтервалі від {start} до {end}:");
//        for (int i = start; i <= end; i++)
//        {
//            if (IsPerfectNumber(i))
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }    
//}


//Завдання 4. Написати функцію, яка приймає як параметр масив карт і порядковий номер картки, вивести на екран передану їй гральну картку.
//using System;

//public class Program
//{

    // Функція для виведення гральної картки за її порядковим номером
//    public static void DisplayCard(string[] cards, int index)
//    {
//        if (index >= 0 && index < cards.Length)
//        {
//            Console.WriteLine("Ваша карта: " + cards[index]);
//        }
//        else
//        {
//            Console.WriteLine("Неправильний номер картки.");
//        }
//    }
//    public static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;

//        string[] cards = { "Чирвова дама", "Бубновий король", "9-ка чирвова", "Туз піковий", "8-ка пікова", "10-ка бубнова", "Валет хрестовий" };

//        while (true)
//        {
//            Console.Write("Введіть порядковий номер картки (від 0 до " + (cards.Length - 1) + "): ");
//            int cardIndex;
//            bool isValid = int.TryParse(Console.ReadLine(), out cardIndex);

//            if (isValid && cardIndex >= 0 && cardIndex < cards.Length)
//            {
//                DisplayCard(cards, cardIndex);
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Неправильний номер картки. Спробуйте ще раз.");
//            }
//        }
//    }
//}

//Завдання 5. Написати функцію, яка визначає, чи є «щасливим» шестизначне число.
using System;

public class Program
{
    public static bool IsHappyNumber(int number)
    {
        string numStr = number.ToString();

        int sumFirstHalf = int.Parse(numStr[0].ToString()) + int.Parse(numStr[1].ToString()) + int.Parse(numStr[2].ToString());
        int sumSecondHalf = int.Parse(numStr[3].ToString()) + int.Parse(numStr[4].ToString()) + int.Parse(numStr[5].ToString());

        return sumFirstHalf == sumSecondHalf;
    }
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть шестизначне число: ");
        string input = Console.ReadLine();

        if (input.Length == 6 && int.TryParse(input, out int number))
        {
            bool isHappy = IsHappyNumber(number);
            Console.WriteLine($"Число {number} є щасливим: {isHappy}");
        }
        else
        {
            Console.WriteLine("Неправильний формат числа. Введіть шестизначне число.");
        }
    }    
}




