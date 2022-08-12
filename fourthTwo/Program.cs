void FillArray(int[] collection) // метод, чтобы заполнить массив случайными другими значениями
{
    int length = collection.Length; // Length возвращает длину массива
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++; // index = index +1

    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; // new int[10] - создать новый массив, в котором будет 10 элементов. По умолчанию заполнен 0
FillArray(array); // FillArray - метод, который заполнил массив
array[4] = 4;
array[6] = 4;
PrintArray(array); // PrintArray - метод, который распечатал массив
Console.WriteLine();
int pos = IndexOf(array, 444);
Console.WriteLine(pos);

// void - метод, который не возвращает значения. Тогда в коде можно не использовать оператор return