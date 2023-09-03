// Заполнение массива рандомными числами от 1 до 9.
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

// Вывод элементов массива.
void PrintArray(int[] collec)
{
    int count = collec.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collec[position]);
        position++;
    }
}

// Поиск индекса элемента массива.
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;     // -1 будет, если элемента 
    while (index < count)  // нет в массиве.
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

// Создаем массив.
FillArray(array);
array[4] = 4;
array[8] = 4;

// Печатаем массив.
PrintArray(array);
Console.WriteLine();

// Ищем индекс элемента.
int pos = IndexOf(array, 444);
Console.WriteLine(pos);