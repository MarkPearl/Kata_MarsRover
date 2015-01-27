using Machine.Specifications;
using MarRoverChallenge.Implementation.Movers;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Tests
{
	public class given_rover_facing_east_at_location_1_100_when_moving_backward_by_one : RoverTestsBase
	{
		Establish context = () =>
		{
			Create100x100Grid_And_PlaceRoverFacingEastAt(1, 100);
		};

		Because of = () =>
		{
			var commands = new[]
			{
				NavigationCommand.Backward
			};
			Rover.Move(commands);
		};

		It should_be_at_position_0_100 = () =>
		{
			Rover.RoverPosition().ShouldEqual(Position.SepecificCoord(0,100));
		};
	}
}