namespace Lib
{
	public struct TimeOnly
	{
		public TimeOnly(int hour, int minute, int second) => underlying = new DateTime(1, 1, 1, hour, minute, second);

		public int Hour => underlying.Hour;
		public int Minute => underlying.Minute;
		public int Second => underlying.Second;

		DateTime underlying;
	}

	public struct Range<T> where T : struct
	{
		// this static property is the bug - comment this out and nUnit loads this type correctly
		public static readonly Range<TimeOnly> NineToFive = new(new TimeOnly(9, 0, 0), new TimeOnly(17, 0, 0));

		public T Start { get; private set; }

		public T End { get; private set; }

		public Range(T start, T end)
		{
			Start = start;
			End = end;
		}
	}
}
