using Machine.Specifications;
using MarRoverChallenge.Implementation.Movers;

namespace MarRoverChallenge.Tests
{
	public class given_rover_facing_north_and_turning_right_once : RoverTestsBase
	{
		Establish context = () =>
		{
			Create100x100Grid_And_PlaceRoverFacingNorthAt(1, 1);
		};

		Because of = () =>
		{
			Rover.Move(new char[] {NavigationCommand.TurnRight});
		};

		It should_be_facing = () =>
		{
			Rover.RoverDirection().ShouldEqual(Direction.E);
		};
		 
	}
}