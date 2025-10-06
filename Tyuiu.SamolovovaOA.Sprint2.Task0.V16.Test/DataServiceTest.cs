using Tyuiu.SamolovovaOA.Sprint2.Task0.V16.Lib;

namespace Tyuiu.SamolovovaOA.Sprint2.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1025, y = 275;
            bool[] wait = { true, false, true, false, true, false };
            var ds = new DataService();
            var res = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
