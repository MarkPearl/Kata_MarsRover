using Machine.Specifications;
using MarRoverChallenge.Implementation.Movers;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Tests
{
	public class given_rover_facing_east_at_location_1_100_when_moving_forward_by_one : RoverTestsBase
	{
		Establish context = () =>
		{
			Create100x100Grid_And_PlaceRoverFacingEastAt(1, 100);
		};

		Because of = () =>
		{
			var commands = new[] {NavigationCommand.Forward};
			Rover.Move(commands);
		};

		It should_be_at_position_2_100 = () =>
		{
			Rover.RoverPosition().ShouldEqual(Position.SepecificCoord(2,100));
		};
	}
}