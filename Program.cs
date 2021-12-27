// Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом
// При решении не рекомендуется пользоваться коллекциям, лучше обойтись исключительно массивами.

int[] arr = new int[8];
Random A = new Random();
int i;

for(i = 0; i < arr.Length; i++)
{
    int j = A.Next(1, 20);
    arr[i] = j;
    Console.Write(arr[i]);
    Console.Write(" ");
}

Console.Write("-> ");

for(i = 0; i < arr.Length; i++)
{
    if(arr[i] > 8)
    {
        Console.Write(arr[i]);
        Console.Write(" ");
    }
    else Console.Write("");
}