using System;
int qnt;
int y = 0;
int x = 0;
Console.WriteLine($"Введите размер одномерного массива: ");
qnt = int.Parse(System.Console.ReadLine());
int[] array = new int[qnt];
while(x<qnt){
    array[x] = new Random().Next(100,1000);
    Console.Write($"{array[x]} \t");
    if(array[x] %2 == 0){
        y++;
    }
    x++;
}Console.Write($"Количество четных числе в массиве: {y}");