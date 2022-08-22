public class Vector
{
    public Coordinate PointA = new Coordinate();
    public Coordinate PointB = new Coordinate();


    public override string ToString()
    {
        return $"A:{{{PointA.ToString()}}} B:{{{PointB.ToString()}}}";
    }
    public static Vector operator +(Vector obj1, Vector obj2)
    {
        Vector newVector = new Vector();
        newVector.PointA.x = obj1.PointA.x;
        newVector.PointA.y = obj1.PointA.y;
        newVector.PointB.x = obj1.PointB.x-(obj2.PointA.x-obj2.PointB.x);
        newVector.PointB.y = obj1.PointB.y-(obj2.PointA.y-obj2.PointB.y);
        return newVector;
    }
    public static Vector operator *(Vector obj1, int Number)
    {
        Vector newVector = new Vector();
        newVector.PointB.x = obj1.PointA.x-(obj1.PointA.x-obj1.PointB.x)*Number;
        newVector.PointB.y = obj1.PointA.y-(obj1.PointA.y-obj1.PointB.y)*Number;
        newVector.PointA.x = obj1.PointA.x;
        newVector.PointA.y = obj1.PointA.y;
        return newVector;
    }
}