using System;
string ex;
int exit = 1;
int rank;
int num;
int sum;
while(exit != 0){
    Console.WriteLine($"Введите число или 'q' для выхода:");
    num = int.Parse(System.Console.ReadLine());
    string myq = num.ToString();
    if(myq == "q"){
        exit = 0;
        num = 0;
    }
    sum = 0;
while(num !=0){
    rank = num % 10;
    sum = sum + rank;
    num = num / 10;
}
Console.WriteLine($"{sum}");
if (sum % 2 ==0){
    System.Console.WriteLine($"Сумма цифр числа чётная.");
    exit = 0;
}
}