// Собрать строку с числами от a до b, a ≤ b
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10


//............................. Собрать строку с числами от a до b, a ≥ b
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1
Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1 

// ........................Сумма чисел от 1 до n
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55



// .................Факториал числа
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800


// .................Вычислить аn
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{ //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024


// ...................Перебор слов
// В некотором машинном алфавите имеются четыре
// буквы «а», «и», «с» и «в». Покажите все слова,
// состоящие из T букв, которые можно построить из букв
// этого алфавита



Решение некоторых задач
char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
    }
}
Перебор слов
Решение некоторых задач
char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}");
        }
    }
}
Перебор слов
Решение некоторых задач
char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}");
            }
        }
    }
}
Перебор слов
Решение некоторых задач
char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                for (int m = 0; m < count; m++)
                {
                    Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
                }
            }
        }
    }
}

// .......................составить возможные слова
int n = 0;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords(“аисв”, new char[5]);


// ,,,,,,,,,,,,,,,,,,,,,,,,,,,,Общее решение
// Решение некоторых задач
int n = 0;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords(“аисв”, new char[5]);


// ююююю......................поиск папки в папке
string path = "D:\!!!!!!!!GeegBrans\Знакомство с языками програмирования\lection\all_lessons\Example014_lec_6";//путь поиска
DirectoryInfo di = new DirectoryInfo(path)//DirectoryInfo -ищет папку
Console.WriteLine(di.lection);//узнать  когдабыла создана папка
FileInfo[] fi = di.GetFiles();//найти файл
for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);//вывести в консоль найденую
}

//...............рекурсия которая ходит по папкам и смотрит что внутри
void CatalogInfo(string path, string indent = "")//метод  поиска, string path- аргумент путь к папке. string indent = ""---отступы пусто
{
    DirectoryInfo catalog = new DirectoryInfo(path);//получаем инфу по директории в которую зашли 
    DirectoryInfo[] catalogs = catalog.GetDirectories();//масив всех папоп
    for (int i = 0; i < catalog.Length; i++)//пробегаем по ним и ищем
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");//рекурсивно смотрим все папки
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");//показываем файлы
    }
}
string path = @"D:\!!!!!!!!GeegBrans\Знакомство с языками програмирования\lection";
CatalogInfo(path);


//..............Игра в пирамидки....рекурсия
//ю.......рабобочая перамида..куда все ставить...промежуточная....всего блинов
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{//метод перемещения блинов с 1 на 2 ина 3
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

//.......((4 - 2) * (1 + 3)) / 10 -решить
//масив дерева
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// 0 1 2 3 4 5 6 7 8 9 10 11
//ю...метод обхода
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {//считаем левую часть
        int left = 2 * pos;
        //считаем правую часть
        int right = 2 * pos + 1;
        //если не выходим за границы и элемент не пустой то рекурсивно запускаем обход дерева с позицией
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        //выводим узел
        Console.WriteLine(tree[pos]);
        //если не выходим за границы и элемент не пустой то рекурсивно запускаем обход дерева с позицией
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();//запускаем код обхода