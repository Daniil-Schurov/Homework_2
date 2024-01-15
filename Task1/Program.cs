Console.WriteLine("Введите число");
int input = int.Parse (Console.ReadLine());

if (input % 7 == 0 && input % 23 == 0)
{
    Console.WriteLine("Число одновременно кратно 7 и 23");
}
else 
{
    Console.WriteLine("Число не кратно одновременно 7 и 23");
}