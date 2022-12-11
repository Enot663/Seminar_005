// Напишите программу, замена элементов массива положительные заменить на
// отрицательные и соответственно наоборот.
Console.Clear();


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

