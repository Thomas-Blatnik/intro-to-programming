
namespace CSharpSyntax
{
    public class NumberFilterTests
    {
        [Fact]
        public void CanFilterOutEvenNumbers()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var expected = new List<int> { 1, 3, 5, 7, 9 };
            var numberFilter = new NumberFilter();

            List<int> results = numberFilter.Filter(numbers, n => n % 2 == 1);

            Assert.Equal(expected, results);
        }
    }
}
