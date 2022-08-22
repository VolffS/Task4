public class Coordinate
{
    public double x;
    public double y;
    private const double epsilon = 0.09;
    public override string ToString()
    {
        return $"{x};{y}";
    }
    public double DistanceCalculation(Coordinate secondCoordinates)
    {
        var result = Math.Sqrt(Math.Pow(secondCoordinates.x - x, 2) + Math.Pow(secondCoordinates.y - y, 2));
        return result;
    }
    
    public static bool operator ==(Coordinate obj1,Coordinate obj2)
    {
        if (Math.Abs(obj1.x-obj2.x)<epsilon && Math.Abs(obj1.x-obj2.x)<epsilon)
        {
            return true;
        }
        return false; 
    }
    public static bool operator !=(Coordinate obj1,Coordinate obj2)
    {
        if (Math.Abs(obj1.x-obj2.x)>epsilon && Math.Abs(obj1.x-obj2.x)>epsilon)
        {
            return true;
        }
        return false;
    }
    public static Coordinate operator +(Coordinate obj1, Coordinate obj2)
    {
        Coordinate Point = new Coordinate(){x=0,y=0};
        Point.x = obj1.x + obj2.x;
        Point.y = obj1.y + obj2.y;
        return Point;
    }
}