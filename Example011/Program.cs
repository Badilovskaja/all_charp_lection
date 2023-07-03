// ............из массива чисел найти нужное

// 1 метод создаем массив чисел
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}
// 2 метод  массив чисел выводит в консоль
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}
// 3 метод из массива чисел найти нужное
int IndexOf(int[] colection, int find)
{
    int count = colection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (colection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

// //......... выводим
int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);
