
class Circle : Figure
{
    private Coordinate circleCenterO = new Coordinate();
    private Coordinate circlePointA = new Coordinate();
    
    public Circle(Coordinate pointCenterO, Coordinate pointA)
    {
        circleCenterO = pointCenterO;
        circlePointA = pointA;
    }
    public override bool FigureExists()
    {
        if (circleCenterO != circlePointA)
        {
            return true;
        }
        return false;
    }
    public override void Move(double i, double j)
    {
        var point = new Coordinate() { x = i, y = j };
        circleCenterO += point;
        circlePointA += point;
    }

    public override string ToString()
    {
        return $"O:{{{circleCenterO.ToString()}}} A:{{{circlePointA.ToString()}}}";
    }
    public override double Square()
    {
        if (S==0)
        {
            var radius = circleCenterO.DistanceCalculation(circlePointA);
            S = Math.PI * Math.Pow(radius,2);  
        }
        return S;
    }
}