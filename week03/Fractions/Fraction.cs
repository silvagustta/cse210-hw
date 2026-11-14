public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    } 

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}