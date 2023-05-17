

public class Account
{
    private int _number;
    //example of constructer
    public Account(int number)
    {
        SetNumber(number);
    }
    // setter example
    public void SetNumber(int number)
    {
        if (number < 0){
            throw new ArgumentException("Account number must be positive.");
        }
        _number = number;
    }
    //getter example
    public int GetNumber()
    {
        return _number;
    }
}