using NUnit.Framework;

namespace ShortestWinterTests
{
    /*
        John was sitting near to a fireplace in his house, trying to get some warmth from the fire. 
        Fighting his cold at the end of a freezing, short, dark winter day, he started wondering why
        it always had to be so cold during this season. 
        That was when he came up with an idea.

        John stated that winter is the initial part of the year in which it is always colder than in the remaining part. 
        This latter part is called 'summer'. 
        Then he assumed that summer is always warmer than the winter, that is, any temperature measure in winter, is
        colder than every temperature measured in summer.

        Then he searched the Internet and found the previous year's meteorological data, which container the year's
        temperature measurements. 
        He began to wonder if it might be possible to divide the year into winter and summer so that winter comes
        before summer and each year winter's temperature measurement is smaller than any temperature measured in summer.
        In case there are many such possible partitions, find the one in which the winter period is as short as possible.
        (It is quite cold now; there is really no reason for winter to be longer than necessary...)

        Write a function:

        func Solution(T []int) int

        that, given a sequence T of temperature measurements (specified as integer numbers), finds the partition of the
        year into winter and summer that meets the conditions above and makes winter as short as possible, then returns
        the length of the winter. You can assume that there exists a partition in which summer has at least one day.

        For example, given:

        T = [5, -2, 3, 8, 6]

        the function should return 3, as after partitioning the year into winter: [5, -2, 3] and summer: [8, 6], 
        each winter's measurement is smaller than each summer's temperature.

        On the other hand, for the following array:

        T = [-5, -5, -5, -42, 6, 12]

        the function should return 4. The partition that minimizes the length of the winter is [ -5, -5, -5, -42] and [6, 12].
        Winter could also have length 5, but the function should return the shortest possible winter.

        Assume that:

        N is an integer within the range [2..300,000]
        Each element of array T is an integer within the range [-1,000,000,000..1,000,000,000]
        There will be at least one correct way to divide the year into winter and summer
        Complexity:

        Expected worst-case time complexity is 0(N)
        Expected worst-case space complexity is 0(N), beyone input storage (not counting the storage required for input arguments)
        Elements of input arrays can be modified.    
    */

    [TestFixture]
    public class UnitTests
    {
        [Test]
        [TestCase(new[] { 5, -2, 3, 8, 6 }, 3, TestName = "1" )]
        [TestCase(new[] { -5, -5, -5, -42, 6, 12 }, 4, TestName = "2")]
        [TestCase(new[] { 1, -10, -3, -1, 0, 20, 25, 18 }, 5, TestName = "3")]
        public void TestMethod(int[] temperatures, int expectedResult)
        {
            var result = ShortestWinter.Program.Solution(temperatures);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
