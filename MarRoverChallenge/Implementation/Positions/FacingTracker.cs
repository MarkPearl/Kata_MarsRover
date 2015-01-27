using MarRoverChallenge.Implementation.Movers;

namespace MarRoverChallenge.Implementation.Positions
{
	public class FacingTracker
	{
		Direction _currentlyCurrentlyFacing;

		private FacingTracker(Direction direction)
		{
			_currentlyCurrentlyFacing = direction;
		}

		public Direction CurrentlyFacing
		{
			get { return _currentlyCurrentlyFacing; }
		}


		public static FacingTracker SetDirection(Direction direction)
		{
			return new FacingTracker(direction);
		}

		public void TurnRight()
		{
			switch (_currentlyCurrentlyFacing)
			{
				case Direction.N:
					_currentlyCurrentlyFacing = Direction.E;
					break;

				case Direction.S:
					_currentlyCurrentlyFacing = Direction.W;
					break;

				case Direction.E:
					_currentlyCurrentlyFacing = Direction.S;
					break;

				case Direction.W:
					_currentlyCurrentlyFacing = Direction.N;
					break;
			}
		}

		public void TurnLeft()
		{
			switch (_currentlyCurrentlyFacing)
			{
				case Direction.N:
					_currentlyCurrentlyFacing = Direction.W;
					break;

				case Direction.S:
					_currentlyCurrentlyFacing = Direction.E;
					break;

				case Direction.E:
					_currentlyCurrentlyFacing = Direction.N;
					break;

				case Direction.W:
					_currentlyCurrentlyFacing = Direction.S;
					break;
			}

		}
	}
}