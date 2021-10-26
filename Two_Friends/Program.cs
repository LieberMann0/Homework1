int SpdFirst, SpdSecond, SpdDog, Dist, count = 0, Friend = 2, Time;

Console.Write("Введите скорость первого человека: ");
SpdFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите скорость второго человека: ");
SpdSecond = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите скорость собаки: ");
SpdDog = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите расстояние: ");
Dist = Convert.ToInt32(Console.ReadLine());

while (Dist >= 10)
{
    if (Friend == 1)
    {
        Time = Dist / (SpdDog + SpdFirst);
        Friend = 2;
    }
    else
    {
        Time = Dist / (SpdDog + SpdSecond);
        Friend = 1;
    }
    Dist = Dist - (SpdFirst + SpdSecond) * Time;
    count++;
}
Console.WriteLine("Собака пробежала "+count+" раз.");