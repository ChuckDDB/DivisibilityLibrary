using DivisibilityLibrary;
namespace DivisibilityLibrary.UnitTests
{
    public class NumberCheckerTests
    {
        [Fact]
        public void CheckNumbers_ReturnsCorrectNumberOfResults()
        {
            var checker = new NumberChecker();
            int maxNumber = 100;

            string[] results = checker.CheckNumbers(maxNumber);

            Assert.Equal(results.Length, maxNumber);
        }

        [Fact]
        public void CheckNumbers_ReturnsCorrectResults()
        {
            var checker = new NumberChecker();
            int maxNumber = 15;

            string[] results = checker.CheckNumbers(maxNumber);

            Assert.Equal("1", results[0]);
            Assert.Equal("2", results[1]);
            Assert.Equal("Chuck", results[2]);
            Assert.Equal("4", results[3]);
            Assert.Equal("Breedlove", results[4]);
            Assert.Equal("Chuck", results[5]);
            Assert.Equal("7", results[6]);
            Assert.Equal("8", results[7]);
            Assert.Equal("Chuck", results[8]);
            Assert.Equal("Breedlove", results[9]);
            Assert.Equal("11", results[10]);
            Assert.Equal("Chuck", results[11]);
            Assert.Equal("13", results[12]);
            Assert.Equal("14", results[13]);
            Assert.Equal("Chuck Breedlove", results[14]);
        }

        [Theory]
        [InlineData(3, "Chuck")]
        [InlineData(5, "Breedlove")]
        [InlineData(15, "Chuck Breedlove")]
        [InlineData(1, "1")]
        public void CheckNumbers_ReturnsCorrectResultForNumber(int number, string expected)
        {
            var checker = new NumberChecker();

            string[] results = checker.CheckNumbers(number);

            Assert.Equal(expected, results[number - 1]);
        }
    }
}