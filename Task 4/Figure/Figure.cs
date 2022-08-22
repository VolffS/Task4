abstract class Figure
{
    protected double S;
    protected double P;
    protected const double epsilon = 0.001;
    public abstract double Square();
    public abstract bool FigureExists();
    public abstract void Move(double i, double j);
    
    
}