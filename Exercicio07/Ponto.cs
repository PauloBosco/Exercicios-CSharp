class Ponto
{
    private int _x;
    private int _y;

    public int X
    {
        get{ return _x; }
        set{ _x = value; }
    }

    public int Y
    {
        get{ return _y; }
        set{ _y = value; }
    }

    public double distancia(Ponto outro)
    {
        return Math.Sqrt(Math.Pow(this.X - outro.X,2) + Math.Pow(this.Y - outro.Y,2));
    }
}