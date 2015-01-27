using MarRoverChallenge.Implementation.Exceptions;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Implementation.Movers
{
	public class NorthFacingMover : IDirectionFacingMover
	{
		readonly BoundedPosition _boundedPosition;
		readonly FacingTracker _facingTracker;

		public NorthFacingMover(
			BoundedPosition boundedPosition,
			FacingTracker facingTracker)
		{
			_boundedPosition = boundedPosition;
			_facingTracker = facingTracker;
		}

		public void Move(char command)
		{
			switch (command)
			{
				case NavigationCommand.Forward:
					_boundedPosition.MoveDown();
					break;

				case NavigationCommand.Backward:
					_boundedPosition.MoveUp();
					break;

				case NavigationCommand.TurnRight:
					_facingTracker.TurnRight();
					break;

				case NavigationCommand.TurnLeft:
					_facingTracker.TurnLeft();
					break;

				default:
					throw new CommandNotRecognizedException(command);
			}
		}
	}
}