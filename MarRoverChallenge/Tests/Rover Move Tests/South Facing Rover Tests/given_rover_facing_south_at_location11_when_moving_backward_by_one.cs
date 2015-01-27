using Machine.Specifications;
using MarRoverChallenge.Implementation.Movers;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Tests
{
	public class given_rover_facing_south_at_location_0_0_when_moving_backward_by_one : RoverTestsBase
	{
		Establish context = () =>
		{
			Create100x100Grid_And_PlaceRoverFacingSouthAt(0, 0);
		};

		Because of = () =>
		{
			var commands = new[]
			{
				NavigationCommand.Backward
			};
			Rover.Move(commands);
		};

		It should_be_at_position_0_1 = () =>
		{
			Rover.RoverPosition().ShouldEqual(Position.SepecificCoord(0,1));
		};
	}
}