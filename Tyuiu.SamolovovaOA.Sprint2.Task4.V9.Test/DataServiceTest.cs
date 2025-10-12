using Tyuiu.SamolovovaOA.Sprint2.Task4.V9.Lib;

namespace Tyuiu.SamolovovaOA.Sprint2.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = -0.5;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = -6;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}
