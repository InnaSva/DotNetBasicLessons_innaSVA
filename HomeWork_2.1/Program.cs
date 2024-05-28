////Завдання 1. Користувач вводить три цифри з клавіатури. Порахувати їх суму, та середнє арифметичне.

//Console.OutputEncoding = System.Text.Encoding.UTF8;
//Console.WriteLine("Введіть 3 цифри:");

//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//int num3 = Convert.ToInt32(Console.ReadLine());

//int result_sum = num1 + num2 + num3;
//int result_av = (num1 + num2 + num3) / 3;

//Console.WriteLine($"Сума: {result_sum}");
//Console.WriteLine($"Середнє значення: {result_av}");

////Завдання 2.Користувач вводить з клавіатури вартість одного ноутбука, їх кількість та відсоток знижки. Порахувати суму замовлення.
//Console.OutputEncoding = System.Text.Encoding.UTF8;
//Console.WriteLine("Введіть вартість ноутбука:");
//decimal price = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введіть кількість ноутбуків:");
//int quantity = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введіть знижку (ціле значення):");
//decimal discount = Convert.ToInt32(Console.ReadLine());

//decimal order_amount = price * quantity * (1 - discount / 100);

//Console.WriteLine($"Сума замовлення: {order_amount}");

////Завдання 3.Зарплата менеджера - 100 $ + 5% від продажів. Користувач вводить з клавіатури загальну суму угод менеджера протягом місяця. Порахувати підсумкову зарплату менеджера. 
//Console.OutputEncoding = System.Text.Encoding.UTF8;
//decimal salary = 100;
//decimal bonus = 5;
//Console.WriteLine($"Зарплата менеджера {salary} $");
//Console.WriteLine($"Відсоток від продажів {bonus} %");
//Console.WriteLine("Введіть загальну суму угод менеджера в $");
//decimal sum_contractor = Convert.ToInt32(Console.ReadLine());
//decimal salary_amount = salary + sum_contractor * bonus / 100;
//Console.WriteLine($"Зарплата менеджера з бонусом: {salary_amount} $");


//Завдання 4. Користувач вводить з клавіатури розмір одного файлу в гігабайтах і швидкість підключення до Інтернету в бітах в секунду. Порахувати, за скільки годин, хвилин та секунд скачається фільм.
