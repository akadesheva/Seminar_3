// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int [] array = {1212};
int n = array.Length;
int index = 0;
for (index = 0; index < n; index++){
    if (array[index] == array[n-1]) {
          Console.WriteLine("Является палиндромом");
    } else{
        Console.WriteLine("Не является палиндромом");
    } 
}



