////Завдання 1
////Користувач вводить з клавіатури два числа (початок та кінець діапазону).
////Потрібно вивести на екран:
////Усі числа діапазону;
////Усі числа діапазону у спадному порядку;
////Усі числа, кратні 7;
////Кількість чисел, кратних 5.

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;

//        int startrange = 0;
//        int endrange = 0;
//        bool isValid = false;

//        // Введення початкового діапазону з перевіркою формату
//        while (!isValid)
//        {
//            try
//            {
//                Console.WriteLine("Введіть числове значення початку діапазону:");
//                startrange = Convert.ToInt32(Console.ReadLine());
//                isValid = true;
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Некоректний формат. Будь ласка, введіть числове значення.");
//            }
//        }

//        isValid = false;

//        // Введення кінцевого діапазону з перевіркою формату і умови
//        while (!isValid)
//        {
//            try
//            {
//                Console.WriteLine("Введіть числове значення закінчення діапазону:");
//                endrange = Convert.ToInt32(Console.ReadLine());

//                if (endrange >= startrange)
//                {
//                    isValid = true;
//                }
//                else
//                {
//                    Console.WriteLine("Значення закінчення діапазону повинно бути більше або дорівнювати значенню початку діапазону.");
//                }
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Некоректний формат. Будь ласка, введіть числове значення.");
//            }
//        }

//        // Виведення всіх чисел діапазону у порядку зростання
//        Console.WriteLine("Числа у порядку зростання:");
//        for (int i = startrange; i <= endrange; i++)
//        {
//            Console.Write(i + " ");
//        }
//        Console.WriteLine();

//        // Виведення всіх чисел діапазону у порядку зменшення
//        Console.WriteLine("Числа у порядку зменшення:");
//        for (int i = endrange; i >= startrange; i--)
//        {
//            Console.Write(i + " ");
//        }
//        Console.WriteLine();

//        // Виведення чисел у діапазоні, кратних 7
//        Console.WriteLine("Числа діапазону, кратні 7:");
//        for (int i = startrange; i <= endrange; i++)
//        {
//            if (i % 7 == 0)
//            {
//                Console.Write(i + " ");
//            }
//        }
//        Console.WriteLine();

//        // Виведення кількості чисел в діапазоні, кратних 5
//        Console.WriteLine("Числа, кратні 5:");
//        int quantity = 0;
//        for (int i = startrange; i <= endrange; i++)
//        {
//            if (i % 5 == 0)
//            {
//                quantity++;
//            }
//        }
//        Console.WriteLine($"Кількість чисел, кратних 5: {quantity}");
//    }
//}

//Завдання 2
//Користувач вводить із клавіатури два числа.
//Потрібно порахувати окремо суму парних, непарних та чисел,
//кратних 9 у вказаному діапазоні, а також середньоарифметичне кожної групи
using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int startrange = 0;
        int endrange = 0;
        int evenSum = 0;
        int oddSum = 0;
        int sum9 = 0;
        int quantityEven = 0;
        int quantityOdd = 0;
        int quantity9 = 0;
        bool isValid = false;

        // Введення початкового діапазону з перевіркою формату
        while (!isValid)
        {
            try
            {
                Console.WriteLine("Введіть числове значення початку діапазону:");
                startrange = Convert.ToInt32(Console.ReadLine());
                isValid = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Некоректний формат. Будь ласка, введіть числове значення.");
            }
        }

        isValid = false;

        // Введення кінцевого діапазону з перевіркою формату і умови
        while (!isValid)
        {
            try
            {
                Console.WriteLine("Введіть числове значення закінчення діапазону:");
                endrange = Convert.ToInt32(Console.ReadLine());

                if (endrange >= startrange)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Значення закінчення діапазону повинно бути більше або дорівнювати значенню початку діапазону.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Некоректний формат. Будь ласка, введіть числове значення.");
            }
        }

        Console.WriteLine();

        // Виведення суми парних і непарних чисел, середньоариф. кожної групи
        for (int i = startrange; i <= endrange; i++)
        {
            if (i % 2 == 0)
            {
                evenSum += i;
                quantityEven++;
            }
            else
            {
                oddSum += i;
                quantityOdd++;
            }

            if (i % 9 == 0)
            {
                sum9 += i;
                quantity9++;
            }
        }

        Console.WriteLine("Cума парних чисел: " + evenSum);
        Console.WriteLine("Середньоарифметичне значення парних чисел: " + (quantityEven > 0 ? (evenSum / (double)quantityEven) : 0));
        Console.WriteLine("Cума непарних чисел: " + oddSum);
        Console.WriteLine("Середньоарифметичне значення непарних чисел: " + (quantityOdd > 0 ? (oddSum / (double)quantityOdd) : 0));

        Console.WriteLine("Сума чисел, кратних 9: " + sum9);
        Console.WriteLine("Середньоарифметичне значення чисел, кратних 9: " + (quantity9 > 0 ? (sum9 / (double)quantity9) : 0));
    }
}

