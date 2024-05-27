//1.Необхідно створити число, яке містить ці цифри. Наприклад, якщо з клавіатури введено 1, 5, 7, 8, тоді потрібно сформувати число 1578.
//Варіант1
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введіть 4 цифри:");

int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = Convert.ToInt32(Console.ReadLine());

int num3 = Convert.ToInt32(Console.ReadLine());

int num4 = Convert.ToInt32(Console.ReadLine());

int result_1 = num1 * 1000 + num2 * 100 + num3 * 10 + num4;

Console.WriteLine($"n1 {num1 * 1000} n2 {num2 * 100} n3 {num3 * 10} n4 {num4}");

Console.WriteLine($"Сформоване число: {result_1}");

//Варіант2
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введіть 4 цифри:");

string input1 = Console.ReadLine();
int num_1 = int.Parse(input1);

string input2 = Console.ReadLine();
int num_2 = int.Parse(input2);

string input3 = Console.ReadLine();
int num_3 = int.Parse(input3);

string input4 = Console.ReadLine();
int num_4 = int.Parse(input4);

int result_2 = num_1 * 1000 + num_2 * 100 + num_3 * 10 + num_4;

Console.WriteLine($"n1 {num1 * 1000} n2 {num2 * 100} n3 {num3 * 10} n4 {num4}");

Console.WriteLine($"Сформоване число: {result_2}");


// 2.Необхідно перевернути число та відобразити результат. Наприклад, якщо введено 341256, результат 652143.
//Варіант 1
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введіть число 341256:");
int number = Convert.ToInt32(Console.ReadLine());
var numb1 = 3 + 3;
var numb2 = 4 + 1;
var numb3 = 1 + 1;
var numb4 = 2 - 1;
var numb5 = 5 - 1;
var numb6 = 6 - 3;
string number_1 = string.Join("", numb1, numb2, numb3, numb4, numb5, numb6);

Console.WriteLine($"Перевернуті цифри: {number_1}");

//Варіант2
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введіть число 341256:");
var number = Convert.ToInt32(Console.ReadLine());
var n1 = 6 * 100000;
var n2 = 5 * 10000;
var n3 = 2 * 1000;
var n4 = 1 * 100;
var n5 = 4 * 10;
var n6 = 3;
var result = n1 + n2 + n3 + n4 + n5 + n6;
Console.WriteLine($"Перевернуті цифри: {result}");




