class Triangle : Figure
{
    private Coordinate PointA = new Coordinate();
    private Coordinate PointB = new Coordinate();
    private Coordinate PointC = new Coordinate();
    private double sideAB,sideBC,sideCA;
    

    public Triangle( Coordinate pointA, Coordinate pointB, Coordinate pointC)
    {
        PointA = pointA;
        PointB = pointB;
        PointC = pointC;
    }

    public override bool FigureExists()
    {
        sideAB = PointA.DistanceCalculation(PointB);
        sideBC = PointB.DistanceCalculation(PointC);
        sideCA = PointC.DistanceCalculation(PointA);
        if ((sideAB+sideBC>sideCA)&&(sideAB+sideCA>sideBC)&&(sideBC+sideCA>sideAB))
        {
            return true;
        }

        return false;
    }

    public override void Move(double i, double j)
    {
        var point = new Coordinate() { x = i, y = j };
        PointA += point;
        PointB += point;
        PointC += point;
    }

    public override string ToString()
    {
        return $"A:{{{PointA.ToString()}}} B:{{{PointB.ToString()}}} C:{{{PointC.ToString()}}}";
    }
    public override double Square()
    {
        if (S==0)
        {
            Perimeter();
            S = Math.Sqrt(P * (P - sideAB) * (P - sideBC) * (P - sideCA));
        }
        return S;
    }
    public double Perimeter()
    {
        if (P==0)
        {
            P = sideAB + sideBC + sideCA;
        }
        return P;
    }
}