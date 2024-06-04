// Завдання 1: 1. Написати програму-калькулятор. Користувач вводить два числа та вибирає арифметичну дію. Вивести на екран результат.

//using System;

//enum MathOper
//{
//    add = '+',
//    subtract = '-',
//    multiply = '*',
//    divide = '/'
//}

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.WriteLine("Калькулятор: введіть число_1");
//            double number1 = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Калькулятор: введіть число_2");
//            double number2 = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Калькулятор: введіть очікувану математичну дію (+, -, *, /)");
//            var mathOper = (MathOper)Convert.ToChar(Console.ReadLine());

//            double result = 0;

//            switch (mathOper)
//            {
//                case MathOper.add:
//                    result = number1 + number2;
//                    break;
//                case MathOper.subtract:
//                    result = number1 - number2;
//                    break;
//                case MathOper.multiply:
//                    result = number1 * number2;
//                    break;
//                case MathOper.divide:
//                    if (number2 != 0)
//                    {
//                        result = number1 / number2;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Помилка: ділення на нуль неможливе.");
//                        return;
//                    }
//                    break;
//                default:
//                    Console.WriteLine("Невідома математична дія.");
//                    return;
//            }

//            Console.WriteLine($"Результат: {result}");
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Помилка: неправильний формат введення.");
//        }
//        catch (InvalidCastException)
//        {
//            Console.WriteLine("Помилка: неправильна математична дія.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Невідома помилка: {ex.Message}");
//        }
//    }
//}


//using System;
//using System.Collections.Generic;

//enum TypeProduct
//{
//    Pizza,
//    Drink
//}

//enum Product
//{
//    Margherita = 1,
//    Pepperoni,
//    Hawaiian,
//    Vegetarian,
//    Cola,
//    Fanta,
//    Sprite
//}

//class Program
//{
//    static void Main()
//    {
//        // Словник відповідності між продуктами і їх типами
//        Dictionary<Product, TypeProduct> productTypes = new Dictionary<Product, TypeProduct>
//        {
//            { Product.Margherita, TypeProduct.Pizza },
//            { Product.Pepperoni, TypeProduct.Pizza },
//            { Product.Hawaiian, TypeProduct.Pizza },
//            { Product.Vegetarian, TypeProduct.Pizza },
//            { Product.Cola, TypeProduct.Drink },
//            { Product.Fanta, TypeProduct.Drink },
//            { Product.Sprite, TypeProduct.Drink }
//        };

//        // Словник цін для продуктів
//        Dictionary<Product, decimal> prices = new Dictionary<Product, decimal>
//        {
//            { Product.Margherita, 10.0m },
//            { Product.Pepperoni, 12.0m },
//            { Product.Hawaiian, 11.0m },
//            { Product.Vegetarian, 13.0m },
//            { Product.Cola, 2.0m },
//            { Product.Fanta, 2.0m },
//            { Product.Sprite, 2.0m }
//        };

//        // Виведення меню на екран
//        Console.WriteLine("Меню:");
//        foreach (var product in Enum.GetValues(typeof(Product)))
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;
//            Console.WriteLine($"{(int)product}. {product} - {prices[(Product)product]} грн");
//        }

//        // Замовлення: список продуктів і їх кількостей
//        Dictionary<Product, int> order = new Dictionary<Product, int>();

//        // Введення коду товару і кількості через цикл
//        while (true)
//        {
//            Console.Write("Введіть код товару і кількість (через пробіл), або '=' для завершення: ");
//            string input = Console.ReadLine();
//            if (input == "=")
//            {
//                break;
//            }

//            string[] parts = input.Split(' ');
//            if (parts.Length != 2 || !int.TryParse(parts[0], out int productCode) || !int.TryParse(parts[1], out int quantity))
//            {
//                Console.WriteLine("Неправильний формат вводу. Спробуйте ще раз.");
//                continue;
//            }

//            Product product = (Product)productCode;
//            if (!Enum.IsDefined(typeof(Product), product))
//            {
//                Console.WriteLine("Неправильний код товару. Спробуйте ще раз.");
//                continue;
//            }

//            if (order.ContainsKey(product))
//            {
//                order[product] += quantity;
//            }
//            else
//            {
//                order[product] = quantity;
//            }
//        }

//        // Розрахунок початкової суми замовлення
//        decimal total = 0;
//        int totalPizzas = 0;
//        int totalDrinks = 0;
//        decimal totalDrinkPrice = 0;

//        foreach (var item in order)
//        {
//            Product product = item.Key;
//            int quantity = item.Value;
//            decimal price = prices[product];
//            total += price * quantity;

//            if (productTypes[product] == TypeProduct.Pizza)
//            {
//                totalPizzas += quantity;
//            }
//            else if (productTypes[product] == TypeProduct.Drink)
//            {
//                totalDrinks += quantity;
//                if (price > 2.0m)
//                {
//                    totalDrinkPrice += price * quantity;
//                }
//            }
//        }

//        decimal initialTotal = total;

//        // Умови акції
//        // Акція 1: якщо сума замовлення > 50$, то знижка на всю суму замовлення 20%
//        decimal discount1 = 0;
//        if (total > 50)
//        {
//            discount1 = total * 0.2m;
//            total -= discount1;
//        }

//        // Акція 2: кожна п'ята піца в чеку безкоштовно
//        int freePizzas = totalPizzas / 5;
//        decimal discountForFreePizzas = 0;

//        foreach (var item in order)
//        {
//            Product product = item.Key;
//            int quantity = item.Value;
//            decimal price = prices[product];

//            if (productTypes[product] == TypeProduct.Pizza)
//            {
//                discountForFreePizzas += Math.Min(freePizzas, quantity) * price;
//                freePizzas -= Math.Min(freePizzas, quantity);
//                if (freePizzas <= 0)
//                {
//                    break;
//                }
//            }
//        }

//        total -= discountForFreePizzas;

//        // Акція 3: якщо вартість напою більше 2$ і кількість таких напоїв більше 3-ьох в чеку, то на всі напої в чеку знижка 15%
//        decimal discountForDrinks = 0;
//        if (totalDrinkPrice > 0 && totalDrinks > 3)
//        {
//            foreach (var item in order)
//            {
//                Product product = item.Key;
//                int quantity = item.Value;
//                decimal price = prices[product];

//                if (productTypes[product] == TypeProduct.Drink)
//                {
//                    discountForDrinks += price * quantity * 0.15m;
//                }
//            }
//            total -= discountForDrinks;
//        }

//        // Виведення чека замовлення
//        Console.WriteLine("\nЧек замовлення:");
//        Console.WriteLine("-----------------------------------------------------------");
//        Console.WriteLine($"{"Назва",-20}{"Кількість",-10}{"Ціна",-10}");
//        Console.WriteLine("-----------------------------------------------------------");

//        foreach (var item in order)
//        {
//            Product product = item.Key;
//            int quantity = item.Value;
//            decimal price = prices[product];
//            Console.WriteLine($"{product,-20}{quantity,-10}{price * quantity,-10}");
//        }

//        decimal totalDiscount = discount1 + discountForFreePizzas + discountForDrinks;
//        Console.WriteLine("-----------------------------------------------------------");
//        Console.WriteLine($"{"Загальна сума",-30}{initialTotal} грн");
//        Console.WriteLine($"{"Сума знижки",-30}{totalDiscount} грн");
//        Console.WriteLine("-----------------------------------------------------------");
//        Console.WriteLine($"{"Сума до оплати",-30}{total} грн");
//    }
//}



//завдання 2 замовлення в мініпіцерії
using System;

enum TypeProduct
{
    Pizza,
    Drink
}

enum Product
{
    Margherita = 1,
    Pepperoni,
    Hawaiian,
    Vegetarian,
    Cola,
    Fanta,
    Sprite
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Ціни на продукти
        decimal priceMargherita = 10.0m;
        decimal pricePepperoni = 12.0m;
        decimal priceHawaiian = 11.0m;
        decimal priceVegetarian = 13.0m;
        decimal priceCola = 2.0m;
        decimal priceFanta = 3.0m;
        decimal priceSprite = 2.5m;

        // Кількість продуктів
        int quantityMargherita = 0;
        int quantityPepperoni = 0;
        int quantityHawaiian = 0;
        int quantityVegetarian = 0;
        int quantityCola = 0;
        int quantityFanta = 0;
        int quantitySprite = 0;

        // Виведення меню на екран
        Console.WriteLine("Меню:");
        Console.WriteLine($"1. Margherita - {priceMargherita} грн");
        Console.WriteLine($"2. Pepperoni - {pricePepperoni} грн");
        Console.WriteLine($"3. Hawaiian - {priceHawaiian} грн");
        Console.WriteLine($"4. Vegetarian - {priceVegetarian} грн");
        Console.WriteLine($"5. Cola - {priceCola} грн");
        Console.WriteLine($"6. Fanta - {priceFanta} грн");
        Console.WriteLine($"7. Sprite - {priceSprite} грн");

        // Введення коду товару і кількості через цикл
        while (true)
        {
            Console.Write("Введіть код товару і кількість (через пробіл), або '=' для завершення: ");
            string input = Console.ReadLine();
            if (input == "=")
            {
                break;
            }

            string[] parts = input.Split(' ');
            if (parts.Length != 2)
            {
                Console.WriteLine("Неправильний формат вводу. Спробуйте ще раз.");
                continue;
            }

            if (!int.TryParse(parts[0], out int productCode) || !int.TryParse(parts[1], out int quantity))
            {
                Console.WriteLine("Неправильний код товару або кількість. Спробуйте ще раз.");
                continue;
            }

            switch ((Product)productCode)
            {
                case Product.Margherita:
                    quantityMargherita += quantity;
                    break;
                case Product.Pepperoni:
                    quantityPepperoni += quantity;
                    break;
                case Product.Hawaiian:
                    quantityHawaiian += quantity;
                    break;
                case Product.Vegetarian:
                    quantityVegetarian += quantity;
                    break;
                case Product.Cola:
                    quantityCola += quantity;
                    break;
                case Product.Fanta:
                    quantityFanta += quantity;
                    break;
                case Product.Sprite:
                    quantitySprite += quantity;
                    break;
                default:
                    Console.WriteLine("Неправильний код товару. Спробуйте ще раз.");
                    break;
            }
        }

        // Розрахунок початкової суми замовлення
        decimal total = 0;
        int totalPizzas = 0;
        int totalDrinks = 0;

        // Розрахунок сум і кількостей
        if (quantityMargherita > 0)
        {
            totalPizzas += quantityMargherita;
        }
        if (quantityPepperoni > 0)
        {
            totalPizzas += quantityPepperoni;
        }
        if (quantityHawaiian > 0)
        {
            totalPizzas += quantityHawaiian;
        }
        if (quantityVegetarian > 0)
        {
            totalPizzas += quantityVegetarian;
        }
        if (quantityCola > 0)
        {
            total += priceCola * quantityCola;
            totalDrinks += quantityCola;
        }
        if (quantityFanta > 0)
        {
            total += priceFanta * quantityFanta;
            totalDrinks += quantityFanta;
        }
        if (quantitySprite > 0)
        {
            total += priceSprite * quantitySprite;
            totalDrinks += quantitySprite;
        }

        // Кількості безкоштовних піц
        int freePizzas = totalPizzas / 5;

        // Чек замовлення
        Console.WriteLine("\nЧек замовлення:");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine($"{"Назва",-20}{"Кількість",-10}{"Ціна",-10}");
        Console.WriteLine("-----------------------------------------------------------");

        // Розрахунок піц з урахуванням акційних - кожна 5-та за 1 грн
        void PrintPizza(string name, int quantity, decimal price)
        {
            if (quantity > 0)
            {
                int freePizzaCount = Math.Min(quantity, freePizzas);
                freePizzas -= freePizzaCount;

                if (quantity > freePizzaCount)
                {
                    total += price * (quantity - freePizzaCount);
                    Console.WriteLine($"{name,-20}{quantity - freePizzaCount,-10}{price * (quantity - freePizzaCount),-10}");
                }

                for (int i = 0; i < freePizzaCount; i++)
                {
                    total += 1;
                    Console.WriteLine($"{name,-20}{"1",-10}{"1,0",-10}");
                }
            }
        }

        void PrintDrink(string name, int quantity, decimal price)
        {
            if (quantity > 0)
            {
                Console.WriteLine($"{name,-20}{quantity,-10}{price * quantity,-10}");
            }
        }

        PrintPizza("Margherita", quantityMargherita, priceMargherita);
        PrintPizza("Pepperoni", quantityPepperoni, pricePepperoni);
        PrintPizza("Hawaiian", quantityHawaiian, priceHawaiian);
        PrintPizza("Vegetarian", quantityVegetarian, priceVegetarian);

        PrintDrink("Cola", quantityCola, priceCola);
        PrintDrink("Fanta", quantityFanta, priceFanta);
        PrintDrink("Sprite", quantitySprite, priceSprite);

        decimal discountForDrinks = 0;

        // Акція 2: якщо кількість напоїв більше 3-х і вартість кожного напою більше 2$, то на всі напої в чеку знижка 15%
        if (totalDrinks > 3)
        {
            decimal totalDrinkPrice = 0;

            if (priceCola > 2.0m && quantityCola > 0)
            {
                totalDrinkPrice += priceCola * quantityCola;
            }
            if (priceFanta > 2.0m && quantityFanta > 0)
            {
                totalDrinkPrice += priceFanta * quantityFanta;
            }
            if (priceSprite > 2.0m && quantitySprite > 0)
            {
                totalDrinkPrice += priceSprite * quantitySprite;
            }

            if (totalDrinkPrice > 0)
            {
                discountForDrinks = totalDrinkPrice * 0.15m;
                total -= discountForDrinks;
            }
        }

        decimal discount1 = 0;

        // Акція 3: якщо сума замовлення > 50$, то знижка на всю суму замовлення 20%
        if (total > 50)
        {
            discount1 = total * 0.2m;
            total -= discount1;
        }

        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine($"{"Загальна сума",-30}{total + discountForDrinks + discount1} грн"); // Загальна сума з урахуванням піц за 1 грн
        Console.WriteLine($"{"Сума знижки на напої 15%",-30}{discountForDrinks} грн");
        Console.WriteLine($"{"Сума знижки 20%",-30}{discount1} грн");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine($"{"Сума до оплати",-30}{total} грн");
    }
}

