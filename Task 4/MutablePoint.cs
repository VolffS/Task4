class MutablePoint
{
    public Coordinate Point = new Coordinate(){x=0,y=0};
    public void Move(double i, double j)
    {
        Point.x += i;
        Point.y += j;
        Console.WriteLine($"Точка переместилась на кординату {Point}");
    }
}