namespace MarRoverChallenge.Implementation.Positions
{
	public class Position
	{		
		int _x;
		int _y;

		Position(int x, int y)
		{			
			X = x;
			Y = y;
		}

		public int X
		{
			get { return _x; }
			set { _x = value; }
		}

		public int Y
		{
			get { return _y; }
			set { _y = value; }
		}

		public void MoveDown()
		{
			Y = Y + 1;
		}

		public void MoveUp()
		{
			Y = Y - 1;
		}

		public void MoveRight()
		{
			X = X + 1;
		}

		public void MoveLeft()
		{
			X = X - 1;
		}

		public static Position SepecificCoord(int x, int y)
		{
			return new Position(x, y);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != GetType()) return false;
			return Equals((Position) obj);
		}

		bool Equals(Position other)
		{
			return _x == other._x && _y == other._y;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (_x*397) ^ _y;
			}
		}

		public override string ToString()
		{
			return string.Format("({0}:{1})", X, Y);
		}
	}
}