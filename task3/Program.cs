using System;
int qnt;
int y = 0;
int x = 0;
Console.WriteLine($"Введите размер одномерного массива: ");
qnt = int.Parse(System.Console.ReadLine());
int[] array = new int[qnt];
while(x<qnt){
    array[x] = new Random().Next(1,10);
    Console.Write($"{array[x]} \t");
    x++;
}
int[] array1 = new int[qnt];
y = qnt-1;
Console.WriteLine($"");

for(int i= 0; i<qnt; i++){
    int num = array[y];
    array1[i] = num;
    Console.Write($"{array1[i]} \t");
    y--;
}