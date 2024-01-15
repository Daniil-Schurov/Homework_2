int num = new Random().Next(10, 100);
int num1 = num / 10;
int num2 = num % 10;
int max = 0;

if (num1 >= num2)
{
    max = num1;
}
else
{
    max = num2;
}
Console.WriteLine("При анализе числа " + num + " Выявлена наибольшая цифра: " + max);
