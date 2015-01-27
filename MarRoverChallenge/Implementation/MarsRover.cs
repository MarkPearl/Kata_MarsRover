using System.Collections.Generic;
using MarRoverChallenge.Implementation.Movers;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Implementation
{
	public class MarsRover
	{		
		readonly FacingTracker _facingTracker;
		readonly BoundedPosition _boundedPosition;
		readonly Dictionary<Direction, IDirectionFacingMover> _movers;
			
		MarsRover(			
			Direction initialDirection, 
			BoundedPosition boundedPosition)
		{
			_facingTracker = FacingTracker.SetDirection(initialDirection);
			_boundedPosition = boundedPosition;
			
			_movers = new Dictionary<Direction, IDirectionFacingMover>
			{
				{Direction.N, new NorthFacingMover(_boundedPosition, _facingTracker)},
				{Direction.S, new SouthFacingMover(_boundedPosition, _facingTracker)},
				{Direction.E, new EastFacingMover(_boundedPosition, _facingTracker)},
				{Direction.W, new WestFacingMover(_boundedPosition, _facingTracker)},
			};
		}

		public void Move(IEnumerable<char> commands)
		{
			foreach (var command in commands)
			{
				_movers[_facingTracker.CurrentlyFacing].Move(command);							
			}
		}

		public Position RoverPosition()
		{
			return _boundedPosition.Position;
		}

		public static MarsRover Place(
			Direction initialDirection,
			BoundedPosition boundedPosition)
		{
			return new MarsRover(initialDirection, boundedPosition);
		}

		public Direction RoverDirection()
		{
			return _facingTracker.CurrentlyFacing;
		}
	}
}