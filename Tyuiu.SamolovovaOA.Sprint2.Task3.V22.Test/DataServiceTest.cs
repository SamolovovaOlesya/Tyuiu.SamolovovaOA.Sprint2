using Tyuiu.SamolovovaOA.Sprint2.Task3.V22.Lib;

namespace Tyuiu.SamolovovaOA.Sprint2.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            var ds = new DataService();
            double x = 2;
            double expected = Math.Round(2 + Math.Pow((2 + 3) / (2 - 1), 2), 3);
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }
        public void ValidCondition2()
        {
            var ds = new DataService();
            double x = 0;
            double expected = Math.Round(Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10, 3);
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }
        public void ValidCondition3()
        {
            var ds = new DataService();
            double x = 1.5;
            double expected = Math.Round(Math.Pow(3 + (2 / Math.Pow(x, 2)), x), 3);
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }
        public void ValidCondition4()
        {
            var ds = new DataService();
            double x = -30;
            double expected = Math.Round(x + 10 * x - (1 / x), 3);
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }
    }
}
