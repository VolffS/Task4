class UnmutablePoint
{
    public Coordinate Point = new Coordinate();

    public void Move(double i, double j)
    {
        var TempPoint = new Coordinate();
        Console.WriteLine($"Не изменяемая точка находится на кординате {Point}");
        TempPoint.x = Point.x + i;
        TempPoint.y = Point.y + j;
        Console.WriteLine($"Точка создалась на кординате {TempPoint}");
    }
}