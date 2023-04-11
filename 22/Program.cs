// Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25

// 2 -> 1, 4

Console.Write("Введите число N:");
int N = int.Parse(Console.ReadLine());
int[] result = new int[N];
// n =5
// 0 1 2 3 4
// 0 0 0 0 0
// 1 2 3 4 5
// 1 4 9 16 25
for (int i = 1; i <= N; i++)
    result[i - 1] = i * i;
for (int i = 0; i < N; i++)
    Console.Write($"{result[i]} ");
