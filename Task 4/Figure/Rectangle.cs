class Rectangle : Figure
{
    private Coordinate PointA = new Coordinate();
    private Coordinate PointB = new Coordinate();
    private Coordinate PointC = new Coordinate();
    private Coordinate PointD = new Coordinate();
    private double sideAB,sideBC,sideCD,sideDA;

    

    public Rectangle(Coordinate pointA, Coordinate pointB, Coordinate pointC , Coordinate pointD)
    {
        PointA = pointA;
        PointB = pointB;
        PointC = pointC;
        PointD = pointD;
    }
    public override double Square()
    {
        if (S==0)
        {
            S = sideAB * sideDA;  
        }
        return S;
    }
    public override void Move(double i, double j)
    {
        var point = new Coordinate() { x = i, y = j };
        PointA += point;
        PointB += point;
        PointC += point;
        PointD += point;
    }
    public override string ToString()
    {
        return $"A:{{{PointA.ToString()}}} B:{{{PointB.ToString()}}} C:{{{PointC.ToString()}}} D:{{{PointD.ToString()}}}";
    }
    public override bool FigureExists()
    {
        sideAB = PointA.DistanceCalculation(PointB);
        sideCD = PointC.DistanceCalculation(PointD);
        sideBC = PointB.DistanceCalculation(PointC);
        sideDA = PointD.DistanceCalculation(PointA);
        if ((Math.Abs(sideAB-sideCD)<epsilon)  && (Math.Abs(sideBC-sideDA)<epsilon) && (Math.Abs(sideAB-sideDA)>epsilon) && ( sideAB!=0 && sideDA!=0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}