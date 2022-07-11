namespace CodingKata.Algo
{
    public class Tests
    {
        public int[] SortSocks(int[] arr)
        {
            return arr;
        }

        [Test]
        [TestCase(new int[0] { }, 0)]
        [TestCase(new int[4] { 1, 1, 2, 2 }, 0)]
        [TestCase(new int[4] { 1, 1, 2, 2 }, 0)]
        [TestCase(new int[4] { 1, 1, 1, 2 }, 2)]
        [TestCase(new int[4] { 1, 1, 1, 1 }, 0)]
        [TestCase(new int[5] { 1, 1, 2, 2, 3 }, 1)]
        [TestCase(new int[5] { 1, 1, 1, 1, 0 }, 1)]
        [TestCase(new int[5] { 1, 4, 2, 1, 0 }, 3)]
        [TestCase(new int[6] { 1, 1, 1, 2, 2, 2 }, 2)]
        [TestCase(new int[8] { 1, 1, 2, 2, 2, 2, 1, 1 }, 0)]
        [TestCase(new int[8] { 1, 2, 3, 5, 6, 7, 8, 3 }, 6)]
        [TestCase(new int[8] { 1, 2, 3, 5, 6, 7, 8, 9 }, 8)]

        public void ShouldReturnOnlySadAndLonelySocks(int[] arr, int expected)
        {
            var result = SortSocks(arr);

            Assert.That(result.Length, Is.EqualTo(expected));
            Assert.That(result.Distinct().Count(), Is.EqualTo(result.Length));
        }
    }
}