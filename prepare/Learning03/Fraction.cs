public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructors
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumer){
        _top = wholeNumer;
        _bottom = 1;
    }

    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters
    public int GetTop(){
        return _top;
    }

    public void SetTop(int top){
        _top = top;
    }

    public int GetBottom(){
        return _bottom;
    }

    public void SetBottom(int bottom){
        _bottom = bottom;
    }

    // Methods
    public string GetFractionString(){
        string topString = Convert.ToString(_top);
        string bottomString = Convert.ToString(_bottom);
        string fractionString = $"{topString}/{bottomString}";
        return fractionString;
    }

    public double GetDecimalValue(){
        double topDouble = Convert.ToDouble(_top);
        double bottomDouble = Convert.ToDouble(_bottom);
        double valueDouble = topDouble/bottomDouble;
        return valueDouble;
    }
}