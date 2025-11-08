using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class MathUtilsTests
{
    [TestMethod]
    public void TestFactorial5()
    {
        Assert.AreEqual(120, MathUtils.Factorial(5));
    }
}
