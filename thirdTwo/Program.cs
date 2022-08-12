int[] array = { 1, 12, 31, 4, 5, 18, 17, 18 };
int n = array.Length; // array.Length - возвращает количество (длину) элементов массива
int find = 18;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);  
        break; // прервать - применяем данный оператор, чтобы не выводились одинаковые значения
              // условие выполнилось и на этом прерываем     
    }
           index++; // index = index + 1;
}
