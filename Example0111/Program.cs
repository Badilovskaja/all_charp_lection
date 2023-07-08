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
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "a");
Console.WriteLine(res);