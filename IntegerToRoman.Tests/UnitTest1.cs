namespace IntegerToRoman.Tests;

[TestClass]
public class IntRom
{
    private readonly IntegerToRoman _integerToRoman;

    public IntRom() 
    {
        _integerToRoman = new IntegerToRoman();
    }

    [TestMethod]
    public void TestMethod1()
    {
        string result = _integerToRoman.IntToRoman(3);

        Assert.AreEqual("III", result);
    }

    [TestMethod]
    public void TestMethod2()
    {
        string result = _integerToRoman.IntToRoman(58);

        Assert.AreEqual("LVIII", result);
    }

    [TestMethod]
    public void TestMethod3()
    {
        string result = _integerToRoman.IntToRoman(1994);

        Assert.AreEqual("MCMXCIV", result);
    }
}