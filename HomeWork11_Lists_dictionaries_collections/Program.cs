//Створити програму "Список справ". (List)
//Реалізувати (окремими функцiями):
//додавання завдання до списку завдань
//зміна завдання (знайти за індексом)
//видалення завдання (знайти за індексом)
//Завдання являє собою рядок (string).


using System;
using System.Collections.Generic;

class ToDoListProgram
{
    static List<string> toDoList = new List<string>();

    static void Main()
    {
        // Метод для виведення списку завдань
        static void PrintToDoList()
        {
            if (toDoList.Count == 0)
            {
                Console.WriteLine("Список порожній.");
            }
            else
            {
                for (int i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {toDoList[i]}");
                }
            }
        }

        // Метод для додавання завдання
        static void AddTask()
        {
            Console.Write("Введіть нове завдання: ");
            string task = Console.ReadLine();
            toDoList.Add(task);
            Console.WriteLine("Завдання додано.");
        }

        // Метод для зміни завдання
        static void EditTask()
        {
            Console.Write("Введіть номер завдання для зміни: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= toDoList.Count)
            {
                Console.Write("Введіть новий текст завдання: ");
                string newTask = Console.ReadLine();
                toDoList[index - 1] = newTask;
                Console.WriteLine("Завдання змінено.");
            }
            else
            {
                Console.WriteLine("Неправильний номер завдання.");
            }
        }

        // Метод для видалення завдання
        static void DeleteTask()
        {
            Console.Write("Введіть номер завдання для видалення: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= toDoList.Count)
            {
                toDoList.RemoveAt(index - 1);
                Console.WriteLine("Завдання видалено.");
            }
            else
            {
                Console.WriteLine("Неправильний номер завдання.");
            }
        }
        bool exit = false;

        while (!exit)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\nСписок справ:");
            PrintToDoList();

            Console.WriteLine("\nОберіть дію:");
            Console.WriteLine("1. Додати завдання");
            Console.WriteLine("2. Змінити завдання");
            Console.WriteLine("3. Видалити завдання");
            Console.WriteLine("4. Вийти");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    EditTask();
                    break;
                case "3":
                    DeleteTask();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неправильний вибір, спробуйте ще раз.");
                    break;
            }
        }
    }    
}
