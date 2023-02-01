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