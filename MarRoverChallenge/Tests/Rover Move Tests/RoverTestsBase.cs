using MarRoverChallenge.Implementation;
using MarRoverChallenge.Implementation.Movers;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Tests
{
	public class RoverTestsBase
	{
		private static void CreateNxMGrid_And_PlaceRover(Direction direction, int positionX, int positionY, int sizeX, int sizeY)
		{
			Rover = MarsRover.Place(
				direction,
				BoundedPosition.Create(
					Bounds.Create(sizeX, sizeY),
					Position.SepecificCoord(positionX, positionY)));
		}

		private static void Create100x100Grid_And_PlaceRover(Direction direction, int positionX, int positionY)
		{
			CreateNxMGrid_And_PlaceRover(direction, positionX, positionY, 100, 100);
		}

		protected static void Create5x5Grid_And_PlaceRoverFacingNorthAt(int positionX, int positionY)
		{
			CreateNxMGrid_And_PlaceRover(Direction.N, positionX, positionY, 5, 5);
		}
		
		protected static void Create5x5Grid_And_PlaceRoverFacingEastAt(int positionX, int positionY)
		{
			CreateNxMGrid_And_PlaceRover(Direction.E, positionX, positionY, 5, 5);
		}

		protected static void Create100x100Grid_And_PlaceRoverFacingNorthAt(int positionX, int positionY)
		{
			Create100x100Grid_And_PlaceRover(Direction.N, positionX, positionY);
		}

		protected static void Create100x100Grid_And_PlaceRoverFacingSouthAt(int positionX, int positionY)
		{
			Create100x100Grid_And_PlaceRover(Direction.S, positionX, positionY);
		}

		protected static void Create100x100Grid_And_PlaceRoverFacingEastAt(int positionX, int positionY)
		{
			Create100x100Grid_And_PlaceRover(Direction.E, positionX, positionY);
		}

		protected static void Create100x100Grid_And_PlaceRoverFacingWestAt(int positionX, int positionY)
		{
			Create100x100Grid_And_PlaceRover(Direction.W, positionX, positionY);
		}

		protected static MarsRover Rover;
	}
}