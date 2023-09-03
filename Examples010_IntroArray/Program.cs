// Поиск максимума из трех чисел
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

// Входные данные
// int a1 = 15;
// int b1 = 21;
// int c1 = 399;
// int a2 = 12;
// int b2 = 23;
// int c2 = 3333;
// int a3 = 13;
// int b3 = 23;
// int c3 = 33333;
int[] array = {11, 21, 14, 88, 45, 6, 99, 0, 3};

//Заменяем первый элемент массива на 220.
array[0] = 220;

// Сравнение трех переменных
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
);

Console.WriteLine(max);