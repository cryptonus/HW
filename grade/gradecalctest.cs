
using Grades;
using NUnit.Framework.Legacy;

namespace grades;

public class Gradcalcu
{
    private Gradecalc _Gradecalc { get; set; } = null!; 
    [SetUp]
    public void Setup()
    {
        _Gradecalc = new Gradecalc();
    }

    [Test]
    public void Getgradebypercent_EqualTest()
        {
            double percent = 95;
            string expected = "A";
            var grades = _Gradecalc.GetGradePercentage(percent);
            ClassicAssert.AreEqual(expected, grades);
        }

        [Test]
        public void GetgradebypercentTest2()
        {
            double percent = 85;
            string expected = "B";
            string grades = _Gradecalc.GetGradePercentage(percent);
            ClassicAssert.AreEqual(expected, grades);
        }

        [Test]
        public void GetgradebypercentTest3()
        {
            double percent = 75;
            string expected = "C";
            string grades = _Gradecalc.GetGradePercentage(percent);
            ClassicAssert.AreEqual(expected, grades);
        }

        [Test]
        public void GetgradebypercentTest4()
        {
            double percent = 65;
            string expected = "D";
            string grades = _Gradecalc.GetGradePercentage(percent);
            ClassicAssert.AreEqual(expected, grades);
        }

        [Test]
        public void GetgradebypercentTest5()
        {
            double percent = 55;
            string expected = "invalid";
            string grades = _Gradecalc.GetGradePercentage(percent);
            ClassicAssert.AreEqual(expected, grades);
        }
    
}