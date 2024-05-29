//Завдання1.Користувач із клавіатури вводить 5 оцінок студента.
//Визначити, чи допущено студента до іспиту.
//Студент отримує допуск, якщо його середній бал 4 бали та вище.

//Console.OutputEncoding = System.Text.Encoding.UTF8;
//Console.WriteLine("Введіть оцінку студента:");

//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введіть оцінку студента:");
//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введіть оцінку студента:");
//int num3 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введіть оцінку студента:");
//int num4 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введіть оцінку студента:");
//int num5 = Convert.ToInt32(Console.ReadLine());

//int result_average = (num1 + num2 + num3 + num4 + num5) / 5;
//Console.WriteLine($"Середня оцінка студента: {result_average}");

//if (result_average >= 4)
//{
//    Console.WriteLine("Cтудента допущено до іспиту");
//            }
//            else
//{
//    Console.WriteLine("Cтудента НЕ допущено до іспиту");
//}

//2.Користувач вводить із клавіатури число.
//Якщо воно парне, помножити його на три, інакше поділити на два.
//Результат вивести на екран.

//Console.OutputEncoding = System.Text.Encoding.UTF8;
//Console.WriteLine("Введіть число:");
//decimal num = Convert.ToInt32(Console.ReadLine());
//if (num % 2 == 0)
//{
//    num *= 3;
//    Console.WriteLine($"{num}");
//}
//else
//{
//    num /= 2;
//    Console.WriteLine($"{num}");
//}

//3.Написати програму - калькулятор.
//Користувач вводить два числа та вибирає арифметичну дію.
//Вивести на екран результат.

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введіть число_1");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введіть число_2:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Виберіть операцію (+, -, *, /):");
string operation = Console.ReadLine();
int result = 0;
if (operation == "+")
{
    result = num1 + num2;
}
else if (operation == "-")
{
    result = num1 - num2;
}
else if (operation == "*")
{
    result = num1 * num2;
}
else if (operation == "/")
{
    if (num2 != 0)
    {
        result = num1 / num2;
    }
    else
    {
        Console.WriteLine("Ділення на нуль неможливе!");
        return;
    }
}
else
{
    Console.WriteLine("Невідома операція!");
    return;
}

Console.WriteLine($"Результат: {result}");

