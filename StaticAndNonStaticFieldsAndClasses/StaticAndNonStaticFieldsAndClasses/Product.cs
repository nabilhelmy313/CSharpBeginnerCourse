
public  static class Product
{
    //Static Value Not Changeble
    static internal double Tax { get; } = 0.14;
    //extension Method
    public static bool IsVaildPrice(this double input)
    {
        return (input > 0);
    }

}


