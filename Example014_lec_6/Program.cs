﻿// увеличить числа в строке в в 2 раза
// string text = "(1,2) (2,3) (4,5) (6,7)";

using System.Linq; //1--- делаем дополнительный модуль
string text = "(1,2) (2,3) (4,5) (6,7)"
                    .Replace("(", "")//Replace----меняем скобку на пестую строку
                    .Replace(")", "");//Replace----меняем скобку на пестую строку--на выходе строка без скобок
var data = text.Split(" ") //неявная типизация Split -делает разбивку с помощью символа разделителя - сейчас это пробел
                .Select(item => item.Split(','))//переводим числа в массив
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))//делаем из массива картеж чисел e[0]-первые элемент, e[1]-второй элемент
                .Where(e => e.x % 2 == 0)//только те числа которые остаток от деления на 2 = 0(четное число)---- %2 =0
                .Select(point => (point.x * 10, point.y + 10))//увеличиваем навсегда х на 10
                .ToArray();// переводим все в массив

for (int i = 0; i < data.Length; i++) //перебор масива
{
    Console.WriteLine(data[i]);//выводим массив координат- картежей
    Console.WriteLine();//разделяем координаты пустой строкой
}
///.Select(point => (point.x * 10, point.y + 10))  увеличиваем навсегда х на 10

// .........................................................................
// using System.Linq; //1--- делаем дополнительный модуль
// string text = "(1,2) (2,3) (4,5) (6,7)"
//                     .Replace("(", "")//Replace----меняем скобку на пестую строку
//                     .Replace(")", "");//Replace----меняем скобку на пестую строку--на выходе строка без скобок
// var data = text.Split(" ") //неявная типизация Split -делает разбивку с помощью символа разделителя - сейчас это пробел
//                 .Select(item => item.Split(','))//переводим числа в массив
//                 .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))//делаем из массива картеж чисел e[0]-первые элемент, e[1]-второй элемент
//                 .ToArray();// переводим все в массив

// for (int i = 0; i < data.Length; i++) //перебор масива
// {
//     Console.WriteLine(data[i].x * 10);//data[i]-конкретная точка, x-координата которую умножаем на 10
//     Console.WriteLine();//разделяем координаты пустой строкой

// ..........................................................................................

// using System.Linq; //1--- делаем дополнительный модуль
// string text = "(1,2) (2,3) (4,5) (6,7)"
//                     .Replace("(", "")//Replace----меняем скобку на пестую строку
//                     .Replace(")", "");//Replace----меняем скобку на пестую строку--на выходе строка без скобок
// var data = text.Split(" ") //неявная типизация Split -делает разбивку с помощью символа разделителя - сейчас это пробел
//                 .Select(item => item.Split(','))//переводим числа в массив
//                 .Select(e => (int.Parse(e[0]), int.Parse(e[1])))//делаем из массива картеж чисел e[0]-первые элемент, e[1]-второй элемент
//                 .ToArray();// переводим все в массив

// for (int i = 0; i < data.Length; i++) //перебор масива
// {
//     //Console.WriteLine(data[i]);
//     for (int k = 0; k < data[i].Length; k++)//перебираем масив иделаем его
//     {
//         Console.WriteLine(data[i][k]);
//     }
//     Console.WriteLine();//разделяем координаты пустой строкой
// }