// Задайте массив из 12 элементов, заполненный случайными числлами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
// элементов массива.

Console.Clear();

const int SIZE = 4;
const int LEFT_RANGE = -9;
const int RIGTH_RANGE = 9;

int[] array = new int[SIZE]; // объявляем целочисленный массив с названием arrey
                             // отрицательных элементов массива


int[] FillArreyWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random(); // заполним его случайными числами, подключаем 
                                // объект Random с названием rand c классом new Random.
    int[] arr = new int[size] ;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;

}

void SumPositiveAndNegative(int[] arr, out int sumP, out int sumN)
{
    sumN = 0;
    sumP = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumP += arr[i];
        }
        else
        {
            sumN += arr[i];
        }
    }

}


//for (int i = 0; i < array.Length; i++) // объявляем цикл присваивая
// каждому элементу массива рандомное значение
{ // ЗАПОЛНИЛИ ЕГО В ЦИКЛЕ СЛУЧАЙНЫМИ ЧИСЛАМИ 
    //array[i] = rand.Next(-9, 10); // проходим по всем элементам массива, 
    // обращаемся к объекту rand, и создаем границы от -9 до 10, десятка не 
    // включается в массив.
}
// ВЫВЕЛИ МАССИВ НА ПЕЧАТЬ, ОТФОРМАТИРОВАВ ЕГО КВАДРАТНЫМИ СКОБКАМИ И 
// РАЗДЕЛИТЕЛЕМ В ВИДЕ ЗЯПЯТОЙ
array = FillArreyWithRandomNumbers(SIZE, LEFT_RANGE, RIGTH_RANGE);
Console.WriteLine("[" + string.Join(",", array) + "]"); // выводим на
// печать полученный массив.
// Сложение отрицательных и положительных элементов массива,
// Для этого пройдемся по всем элементам массива
// Снова создаем цикл
SumPositiveAndNegative(array, out int sumP, out int sumN);
Console.WriteLine($"Сумма положительных элементов = {sumP}, отрицательных = {sumN}.");




