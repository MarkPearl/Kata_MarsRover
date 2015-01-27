namespace MarRoverChallenge.Implementation.Positions
{
	public class Bounds
	{
		Bounds(int maxX, int maxY)
		{
			X = maxX;
			Y = maxY;
		}

		public int X { get; private set; }
		public int Y { get; private set; }

		public static Bounds Create(int maxX, int maxY)
		{
			return new Bounds(maxX, maxY);
		}
	}
}