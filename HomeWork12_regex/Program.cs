//Написати валідації за допомогою регулярних виразів:
//﻿-домашній номер телефону(тільки цифри та довжина номера)
//-Мобільний номер телефону(тільки цифри, можлива наявність плюса, довжина номера)
//-email(наявність @, домену: gmail.com наприклад, мінімальна довжина та максимальна на ваш вибір)
//- ПІБ клієнта(3 слова, мінімальна довжина 2 символи, максимальна довжина 20) HomeWork12_regex

using System;
using System.Text.RegularExpressions;

class ValidationProgram
{
    // Метод для отримання валідного вводу
    static string GetValidInput(string prompt, Func<string, bool> validate, string errorMessage)
    {
        while (true)
        {
            try
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (validate(input))
                {
                    return input;
                }
                else
                {
                    throw new ArgumentException(errorMessage);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Спробуйте ще раз.");
            }
        }
    }

    // Валідація домашнього номера телефону
    static bool ValidateHomePhone(string phone)
    {
        // Домашній номер телефону - тільки цифри, довжиною від 6 до 10 символів
        string pattern = @"^\d{6,10}$";
        return Regex.IsMatch(phone, pattern);
    }

    // Валідація мобільного номера телефону
    static bool ValidateMobilePhone(string phone)
    {
        // Мобільний номер телефону може починатися з плюса, тільки цифри, довжиною від 10 до 15 символів
        string pattern = @"^\+?\d{10,15}$";
        return Regex.IsMatch(phone, pattern);
    }

    // Валідація електронної пошти
    static bool ValidateEmail(string email)
    {
        // Електронна пошта має містити @, домен, довжиною від 5 до 50 символів
        string pattern = @"^[\w\.-]+@[\w\.-]+\.\w{2,}$";
        return Regex.IsMatch(email, pattern) && email.Length >= 5 && email.Length <= 50;
    }

    // Валідація ПІБ клієнта
    static bool ValidateFullName(string fullName)
    {
        // ПІБ клієнта має складатися з трьох слів, починається з великої літери, має довжину від 2 до 20 символів
        string pattern = @"^([A-ZА-ЯІЇЄҐ][a-zа-яіїєґ]{1,19}\s+){2}[A-ZА-ЯІЇЄҐ][a-zа-яіїєґ]{1,19}$";
        return Regex.IsMatch(fullName, pattern);
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Перевірка введених даних:");

        // Перевірка домашнього номера телефону
        string homePhone = GetValidInput("Введіть домашній номер телефону: ", ValidateHomePhone, "Домашній номер телефону некоректний.");

        // Перевірка мобільного номера телефону
        string mobilePhone = GetValidInput("Введіть мобільний номер телефону: ", ValidateMobilePhone, "Мобільний номер телефону некоректний.");

        // Перевірка електронної пошти
        string email = GetValidInput("Введіть електронну пошту: ", ValidateEmail, "Електронна пошта некоректна.");

        // Перевірка ПІБ клієнта
        string fullName = GetValidInput("Введіть ПІБ клієнта: ", ValidateFullName, "ПІБ клієнта некоректний.");

        Console.WriteLine("Усі дані введені коректно!");
    }    
}

