using Lib;
using NUnit.Framework;
using TimeOnly = Lib.TimeOnly;

namespace Error
{
	[TestFixture]
	public class RangeTests
	{
		[Test]
		public void TestFail()
		{
			var expected = new Range<TimeOnly>(new TimeOnly(12, 0, 0), new TimeOnly(12, 3, 1));
			var actual = new Range<TimeOnly>(new TimeOnly(12, 0, 0), new TimeOnly(12, 3, 1));

			Assert.AreEqual(expected, actual);
		}
	}
}
