// Виды Функций
//............вид 1 - ничего не принимает и не возвращает
// void Method1()
// {
//     Console.Write("autor King wall");
// }
// Method1();

//............вид 2 - принимает и не возвращает
// void Method2(string msg)
// {
//     Console.Write(msg);
// }
// Method2("Текстовое сообщение");



// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(count: 4, msg: "Новый текст");

//............вид 3 -  не принимает и  возвращает
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

//............вид 3 - принимает и  возвращает
// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "a");
// Console.WriteLine(res);

// ............for цикл
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "u");
// Console.WriteLine(res);


// ............for цикл в цикле
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// ..............4 вид функции с for
// ..........заменить в тексте пробелы на тире, маленькие буквы "к" 
// на "К"большие, а большие "С" на маленькие "с"


// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";

//  string s = "ryuio"
//              01234
// s[3] //i
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '-');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);


// ..............АЛГОРИТМ СОРТИРОВКИ МЕТОДОМ ВЫБОРА MIN i MAX ЧИСЛА
// ...метод перебора массива
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
// .......... метод упорядочивание нахождение меньшей и ставим ее вперед
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);