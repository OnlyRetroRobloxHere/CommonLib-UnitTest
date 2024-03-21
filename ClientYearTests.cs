using OnlyRetroRobloxHere.Common.Enums;
using OnlyRetroRobloxHere.Common.Models;

namespace Common.UnitTest
{
    [TestClass]
    public class ClientYearTests
    {
        [TestMethod]
        public void Parse()
        {
            var y = new ClientYear("2007E");
            Assert.AreEqual(y.Year, 2007);
            Assert.AreEqual(y.Era, YearQuarter.Early);

            y = new ClientYear("2010M");
            Assert.AreEqual(y.Year, 2010);
            Assert.AreEqual(y.Era, YearQuarter.Mid);

            y = new ClientYear("2013L");
            Assert.AreEqual(y.Year, 2013);
            Assert.AreEqual(y.Era, YearQuarter.Late);

            y = new ClientYear("2013l");
            Assert.AreEqual(y.Year, 2013);
            Assert.AreEqual(y.Era, YearQuarter.Late);

            y = new ClientYear(2007, YearQuarter.Early);
            Assert.AreEqual(y.Year, 2007);
            Assert.AreEqual(y.Era, YearQuarter.Early);

            y = new ClientYear(2010, YearQuarter.Mid);
            Assert.AreEqual(y.Year, 2010);
            Assert.AreEqual(y.Era, YearQuarter.Mid);

            y = new ClientYear(2013, YearQuarter.Late);
            Assert.AreEqual(y.Year, 2013);
            Assert.AreEqual(y.Era, YearQuarter.Late);
        }

        [TestMethod]
        public void Comparisons()
        {
            Assert.AreEqual(new ClientYear("2007E"), new ClientYear("2007E"));
            Assert.AreEqual(new ClientYear("2010M"), new ClientYear("2010M"));
            Assert.AreEqual(new ClientYear("2013L"), new ClientYear("2013L"));

            Assert.IsTrue(new ClientYear("2007E") == new ClientYear("2007E"));
            Assert.IsTrue(new ClientYear("2010M") == new ClientYear("2010M"));
            Assert.IsTrue(new ClientYear("2013L") == new ClientYear("2013L"));

            Assert.AreEqual(new ClientYear("2007E"), new ClientYear(2007, YearQuarter.Early));
            Assert.AreEqual(new ClientYear("2010M"), new ClientYear(2010, YearQuarter.Mid));
            Assert.AreEqual(new ClientYear("2013L"), new ClientYear(2013, YearQuarter.Late));

            Assert.AreNotEqual(new ClientYear("2007E"), new ClientYear("2010M"));
            Assert.IsTrue(new ClientYear("2007E") != new ClientYear("2010M"));

            Assert.IsTrue(new ClientYear("2013L") > new ClientYear("2012L"));
            Assert.IsTrue(new ClientYear("2013L") > new ClientYear("2013E"));
            Assert.IsTrue(new ClientYear("2013L") > new ClientYear("2012M"));
            Assert.IsFalse(new ClientYear("2012L") > new ClientYear("2013L"));
            Assert.IsFalse(new ClientYear("2013L") > new ClientYear("2013L"));

            Assert.IsTrue(new ClientYear("2013L") >= new ClientYear("2013L"));
            Assert.IsTrue(new ClientYear("2014E") >= new ClientYear("2013L"));
            Assert.IsFalse(new ClientYear("2013M") >= new ClientYear("2013L"));

            Assert.IsTrue(new ClientYear("2012L") < new ClientYear("2013L"));
            Assert.IsTrue(new ClientYear("2013E") < new ClientYear("2013L"));
            Assert.IsTrue(new ClientYear("2012M") < new ClientYear("2013L"));
            Assert.IsFalse(new ClientYear("2013L") < new ClientYear("2012L"));
            Assert.IsFalse(new ClientYear("2013L") < new ClientYear("2013L"));

            Assert.IsTrue(new ClientYear("2013L") <= new ClientYear("2013L"));
            Assert.IsTrue(new ClientYear("2013L") <= new ClientYear("2014E"));
            Assert.IsFalse(new ClientYear("2013L") <= new ClientYear("2013M"));
        }
    }
}