using Machine.Specifications;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Tests
{
	public class given_100_by_100_grid_with_rover_facing_north_at_location_0_0_when_moving_with_a_series_of_commands : RoverTestsBase
	{

		Establish context = () =>
		{
			Create100x100Grid_And_PlaceRoverFacingNorthAt(0,0);
		};

		Because of = () =>
		{
			var commands = new[] { 'f', 'f', 'r', 'f', 'f' };
			Rover.Move(commands);
		};

		It should_end_up_at_positon_2_2 = () =>
		{
			Rover.RoverPosition().ShouldEqual(Position.SepecificCoord(2,2));
		};
	}
}