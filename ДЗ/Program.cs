//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// System.Console.WriteLine("Введите число ->");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num >= 100 && num <= 999)
// {
//     System.Console.WriteLine($"Вторая цифра вашего числа {num} -> {(num / 10) % 10}");
// }
// else
// {
//     System.Console.WriteLine("Вы ввели не трёхзначное число!");
// }

//---------------------------------------

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int MakeArray(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("В данном числе нет третьей цифры, поэтому держи вот это ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }

//-----------------------------------

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// System.Console.WriteLine("Введите первое число - >");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if (num1 < 1 || num1 > 7)
// {
//     System.Console.WriteLine($"Серьезно, {num1}, это где у тебя в неделе {num1} дней?");
// }
// else if (num1 > 5)
// {
//     System.Console.WriteLine($"Все путем, сегодня выходной");
// }
// else
// {
//     System.Console.WriteLine($"К сожалению, сегодня придется поработать");
// }
