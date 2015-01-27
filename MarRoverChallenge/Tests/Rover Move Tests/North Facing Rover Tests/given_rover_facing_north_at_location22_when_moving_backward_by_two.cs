using Machine.Specifications;
using MarRoverChallenge.Implementation.Movers;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Tests
{
	public class given_rover_facing_north_at_location_2_2_when_moving_backward_by_two : RoverTestsBase
	{
		Establish context = () =>
		{
			Create100x100Grid_And_PlaceRoverFacingNorthAt(2, 2);
		};

		Because of = () =>
		{
			var commands = new[]
			{
				NavigationCommand.Backward, 
				NavigationCommand.Backward
			};
			Rover.Move(commands);
		};

		It should_be_at_position_2_0 = () =>
		{
			Rover.RoverPosition().ShouldEqual(Position.SepecificCoord(2, 0));
		};
	}
}