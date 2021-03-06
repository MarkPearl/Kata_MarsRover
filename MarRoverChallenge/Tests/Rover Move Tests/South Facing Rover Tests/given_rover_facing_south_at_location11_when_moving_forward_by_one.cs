using Machine.Specifications;
using MarRoverChallenge.Implementation.Movers;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Tests
{
	public class given_rover_facing_south_at_location_1_1_when_moving_forward_by_one : RoverTestsBase
	{
		Establish context = () =>
		{
			Create100x100Grid_And_PlaceRoverFacingSouthAt(1, 1);
		};

		Because of = () =>
		{
			var commands = new[]
			{
				NavigationCommand.Forward
			};
			Rover.Move(commands);
		};

		It should_be_at_position_1_0 = () =>
		{
			Rover.RoverPosition().ShouldEqual(Position.SepecificCoord(1,0));
		};
	}
}