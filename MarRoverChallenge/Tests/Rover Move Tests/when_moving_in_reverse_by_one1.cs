using Machine.Specifications;
using MarRoverChallenge.Implementation.Movers;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Tests
{	   
	public class given_rover_facing_north_at_location_1_1_when_moving_in_backward_by_one : RoverTestsBase
	{
		Establish context = () =>
		{
			Create100x100Grid_And_PlaceRoverFacingNorthAt(1, 1);
		};

		Because of = () =>
		{
			var commands = new[]
			{
				NavigationCommand.Backward
			};
			Rover.Move(commands);
		};

		It should_be_at_position_1_0 = () =>
		{
			Rover.RoverPosition().ShouldEqual(Position.SepecificCoord(1,0));
		};
	}
}