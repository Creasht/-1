// Задача 1
System.Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    System.Console.WriteLine("Наибольшее число " + numberA);
}
else 
{
    System.Console.WriteLine("Наибольшее число " + numberB);
}
//Задача 2
System.Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число:");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (numberA > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}
if (max > numberC)
{
    System.Console.WriteLine("Наибольшее число: " + max);
}
else 
{
   System.Console.WriteLine("Наибольшее число: " + numberC); 
}
//Задача 3
System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int numberA = 2;
if(number % numberA == 0)

{
    System.Console.WriteLine(number + " Число является четным");
}
else
{
System.Console.WriteLine(number + "  Число не является четным");
}
//Задача 4
System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
if(i % 2 == 0)
{
    System.Console.Write(i + " ");
}