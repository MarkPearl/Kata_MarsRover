using Machine.Specifications;
using MarRoverChallenge.Implementation.Movers;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Tests
{
	public class given_5_by_5_grid_with_rover_facing_north_at_location_1_2_when_moving_with_a_series_of_commands : RoverTestsBase
	{

		Establish context = () =>
		{
			Create5x5Grid_And_PlaceRoverFacingNorthAt(1, 2);
		};

		Because of = () =>
		{
			var commands = new[] { 'l', 'f', 'l', 'f', 'l', 'f', 'l', 'f', 'f' };
			Rover.Move(commands);
		};

		It should_end_up_at_positon_2_2 = () =>
		{
			Rover.RoverPosition().ShouldEqual(Position.SepecificCoord(1, 3));
		};

		It should_be_facing_north = () =>
		{
			Rover.RoverDirection().ShouldEqual(Direction.N);
		};
	}
}