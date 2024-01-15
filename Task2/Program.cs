Console.WriteLine("Введите координаты X отличные от нуля");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Y отличные от нуля");
int Y = int.Parse(Console.ReadLine());
if (X > 0 && Y > 0)
{
    Console.WriteLine("Вы указали координаты первой четверти");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Вы указали координаты второй четверти");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Вы указали координаты третьей четверти");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Вы указали координаты четвертой четверти");
}
else if (X == 0 || Y == 0)
{
    Console.WriteLine("Введите координаты отличные от нуля!");
}