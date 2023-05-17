
public class Fraction{

    private int _topInt = 1;
    private int _botInt = 1;

    public Fraction(){

    }
    public Fraction(int wholeNumber){
        _topInt = wholeNumber;
        _botInt = 1;
    }
    public Fraction(int top, int bot){
        _topInt = top;
        _botInt = bot;
    }
    public string GetFractionString(){
        return($"{_topInt}/{_botInt}");
    }
    public string GetDecimalValue(){
        float quoent = (float)_topInt / _botInt;
        return $"{quoent}";
    }
    public int GetTopInt(){
        return _topInt;
    }
    public void SetTopInt(int topInt){
        _topInt = topInt;
    }
    public int GetBotInt(){
        return _botInt;
    }
    public void SetBotInt(int botInt){
        _botInt = botInt;
    }
}
// Fraction()
// Fraction(wholeNumber: int)
// Fraction(top : int, bottom: int)
// GetTop()
// SetTop(top : int)
// GetBottom.
// SetBottom(bottom : int) 
//GetFractionString() : string
// GetDecimalValue): double
// }