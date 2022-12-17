//Задача 1
Console.WriteLine("Ведите число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ведите число");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 > num2){
    Console.WriteLine($"max={num1}");
}
if (num2 > num1){
    Console.WriteLine($"max={num2}");
}

//Задача 2
Console.WriteLine("Ведите число");
int num3 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ведите число");
int num4 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ведите число");
int num5 = int.Parse(Console.ReadLine()!);
if (num3>num4 && num3>num5){              //еле как нашел && вроде как не проходили
    Console.WriteLine($"{num3}");
}
if (num4 > num3 && num3 > num5){
    Console.WriteLine($"{num4}");
}    
if (num5 > num3 && num5 > num4){
    Console.WriteLine($"{num5}");
}

//Задача 3
Console.WriteLine("Ведите число");
int num6 = int.Parse(Console.ReadLine()!);
if(num6%2==0 && num6!>0){
    Console.WriteLine($"да");
}
else{
    Console.WriteLine($"нет");
}


//Задача 4
Console.WriteLine("Ведите число");
int num7 = int.Parse(Console.ReadLine()!);
int number = 0;
while(number<=num7 ){
    if (number%2==0)
    Console.WriteLine($"{number}");
    number++;

}
