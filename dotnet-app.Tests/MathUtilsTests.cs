using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class MathUtilsTests
{
    [TestMethod]
    public void TestFactorial5()
    {
        Assert.AreEqual(120, MathUtils.Factorial(5));
    }

    [TestMethod]
    public void TestFactorial0()
    {
        Assert.AreEqual(0, MathUtils.Factorial(0));
    }
}
