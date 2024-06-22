//Метод BubbleSort
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Створення масив на 30 елементів
//        int[] numbers = new int[30];

//        // Ініціалізація генератора випадкових чисел
//        Random random = new Random();

//        // Заповнення масиву випадковими числами від 1 до 100
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = random.Next(1, 101);
//        }
//        // Метод для виведення масиву на екран
//        static void PrintArray(int[] array)
//        {
//            foreach (int number in array)
//            {
//                Console.Write(number + " ");
//            }
//            Console.WriteLine();
//        }

//        // Метод бульбашкового сортування
//        static void BubbleSort(int[] array)
//        {
//            // Зовнішній цикл проходить через весь масив
//            for (int i = 0; i < array.Length - 1; i++)
//            {
//                // Внутрішній цикл проходить через масив до не відсортованої частини
//                for (int j = 0; j < array.Length - i - 1; j++)
//                {
//                    // Порівняння сусідніх елементів
//                    if (array[j] > array[j + 1])
//                    {
//                        // Зміна місцями елементів, якщо вони стоять в неправильному порядку
//                        int temp = array[j];
//                        array[j] = array[j + 1];
//                        array[j + 1] = temp;
//                    }
//                }
//            }
//        }
//        // Виводення початкового масив
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        Console.WriteLine("Початковий масив:");
//        PrintArray(numbers);

//        // Виклик метода бульбашкового сортування
//        BubbleSort(numbers);

//        // Виводення відсортованого масиву
//        Console.WriteLine("Відсортований масив:");
//        PrintArray(numbers);
//    }    
//}

//Метод InsertionSort
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Створення масиву на 30 елементів
//        int[] numbers = new int[30];

//        // Ініціалізація генератору випадкових чисел
//        Random random = new Random();

//        // Заповнення масиву випадковими числами від 1 до 100
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = random.Next(1, 101);
//        }
//        // Метод для виведення масиву на екран
//        static void PrintArray(int[] array)
//        {
//            foreach (int number in array)
//            {
//                Console.Write(number + " ");
//            }
//            Console.WriteLine();
//        }

//        // Метод сортування вставками
//        static void InsertionSort(int[] array)
//        {
//            // Цикл по всім елементам масиву, починаючи з другого
//            for (int i = 1; i < array.Length; i++)
//            {
//                int key = array[i]; // Поточний елемент, який буде вставляти в відсортовану частину масиву
//                int j = i - 1;

//                // Зрушення елементу масиву, що більші за ключ, на одну позицію вправо
//                while (j >= 0 && array[j] > key)
//                {
//                    array[j + 1] = array[j];
//                    j = j - 1;
//                }

//                // Вставлення ключа в правильну позицію
//                array[j + 1] = key;
//            }
//        }

//        // Виводення початкового масиву
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        Console.WriteLine("Початковий масив:");
//        PrintArray(numbers);

//        // Виклик методу сортування вставками
//        InsertionSort(numbers);

//        // Виведення відсортованого масиву
//        Console.WriteLine("Відсортований масив:");
//        PrintArray(numbers);
//    }
//}

//Метод InsertionSortRecursi
using System;

class Program
{
    static void Main()
    {
        // Створення масиву на 30 елементів
        int[] numbers = new int[30];

        // Ініціалізація генератора випадкових чисел
        Random random = new Random();

        // Заповнення масиву випадковими числами від 1 до 100
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }
        // Метод для виведення масиву на екран
        static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        // Метод рекурсивного сортування вставками
        static void InsertionSortRecursive(int[] array, int n)
        {
            // Базовий випадок: якщо розмір масиву n <= 1, він вже відсортований
            if (n <= 1)
            {
                return;
            }

            // Сортування першого n-1 елементу
            InsertionSortRecursive(array, n - 1);

            // Вставлення останнього елементу у відсортовану частину
            int last = array[n - 1];
            int j = n - 2;

            // Зрушуння елементи масиву, що більші за останній елемент, на одну позицію вправо
            while (j >= 0 && array[j] > last)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }

            // Вставлення останній елемент у правильну позицію
            array[j + 1] = last;
        }
        // Виводення початкового масиву
        Console.WriteLine("Початковий масив:");
        PrintArray(numbers);

        // Виклик метода рекурсивного сортування вставками
        InsertionSortRecursive(numbers, numbers.Length);

        // Виводення відсортованого масиву
        Console.WriteLine("Відсортований масив:");
        PrintArray(numbers);
    }    
}
