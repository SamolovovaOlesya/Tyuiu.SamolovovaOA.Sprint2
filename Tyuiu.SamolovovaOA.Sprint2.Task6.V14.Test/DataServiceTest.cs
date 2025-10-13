using Tyuiu.SamolovovaOA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.SamolovovaOA.Sprint2.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            var ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));    
            Assert.AreEqual("Воскресенье", ds.FindDayName(7, 1));    
            Assert.AreEqual("Понедельник", ds.FindDayName(8, 1));    
            Assert.AreEqual("Пятница", ds.FindDayName(10, 3));       
        }

        [TestMethod]
        public void InvalidFindDayName()
        {
            var ds = new DataService();
            Assert.ThrowsException<ArgumentException>(() => ds.FindDayName(0, 1));
            Assert.ThrowsException<ArgumentException>(() => ds.FindDayName(366, 1));
            Assert.ThrowsException<ArgumentException>(() => ds.FindDayName(1, 0));
            Assert.ThrowsException<ArgumentException>(() => ds.FindDayName(1, 8));
        }
    }
    
}
