using NUnit.Framework;
using ProblemSolving;

namespace ProblemSlovingTest
{
    [TestFixture]
    class StringNumbersComparisonTest
    {
        [Test]
        [TestCase("0","0",false)]
        [TestCase("2","1",true)]
        [TestCase("1","2",false)]
        [TestCase("02","01",true)]
        [TestCase("01","02",false)]
        [TestCase("01","30",false)]
        [TestCase("01","02",false)]
        [TestCase("f","k",false)]
        [TestCase("0","0",false)]
        [TestCase("k","0f",false)]
        [TestCase("k","f",false)]
        public void GreaterStringNumber_PassStringNumbers_ReturnTrueIfFirstIsGreaterOtherFalse(string num1,string num2, bool expectedResult)
        {
           var stringNumbersComparison = new StringNumbersComparison();

           var result = stringNumbersComparison.GreaterStringNumber(num1, num2);

           Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
