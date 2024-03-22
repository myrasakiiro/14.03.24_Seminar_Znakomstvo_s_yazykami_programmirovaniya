// 1 \\ 23.45 \\ "text" \\ 'c'
// int num = 7;
// double d = 7.34;
// string str = "gaar";
// char c '1'; только один симвл
// bool b = true;//false
// сравнение (==)
//while цикл
/*
Напишите программу, которая на вход
принимает два целых числа и проверяет,
является ли первое число квадратом второго.
a = 25, b = 5 => да
a = 2, b = 10 => нет
a = 9, b = -3 => да
a = -3, b = 9 => нет
*/

// Console.Write("Введите первое число: ");

// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");

// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber == secondNumber * secondNumber)
// {
// System.Console.WriteLine("a = " + firstNumber + ", b = " + secondNumber + " => да");
// }
// else
// {
//     System.Console.WriteLine($"a = {firstNumber}, b = {secondNumber} => нет");
// }


// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2


// System.Console.Write("Введите число: ");
// int N = Convert.ToInt32(System.Console.ReadLine());
// int i = -N;

// while(i <= N)
// {
//     System.Console.Write(i + " ");
//     i ++; // i = i + 1; i += 1;

// }

// System.Console.Write("Введите число: ");
// int N = Convert.ToInt32(System.Console.ReadLine());

// for(int i = -N; i <= N; i++)
// {
//     System.Console.Write(i + " ");
// }

// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

//Целочисленное деление и деление по модулю
// int a = 7;
// int b = 2;
// System.Console.Write(a / b);
// // "/" - целочисленное деление

// System.Console.Write(a % b);
// // "%" - деление по модулю




 System.Console.Write("Введите трехзначное число: ");
 int number = Convert.ToInt32(Console.ReadLine());

 if(number > 99 && number < 1000)  //двойной знак амперстанта (&&) - логическое "и"
 {
    int leftDigit = number / 100;
    int rigtDigit = number % 10;
    int result = leftDigit + rigtDigit;
    System.Console.Write(number + " => " + result);
 }
 else
 {
    System.Console.Write("Вы вели не трехзначное число!");
 }