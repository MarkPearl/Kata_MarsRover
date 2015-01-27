using Machine.Specifications;
using MarRoverChallenge.Implementation.Movers;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Tests
{
	public class given_5_by_5_grid_with_rover_facing_east_at_location_0_0_when_moving_with_a_series_of_commands : RoverTestsBase
	{

		Establish context = () =>
		{
			Create5x5Grid_And_PlaceRoverFacingEastAt(0, 0);
		};

		Because of = () =>
		{
			var commands = new[] { 'b', 'r', 'b', 'r' };
			Rover.Move(commands);
		};

		It should_end_up_at_positon_0_1 = () =>
		{
			Rover.RoverPosition().ShouldEqual(Position.SepecificCoord(5, 1));
		};

		It should_be_facing_west = () =>
		{
			Rover.RoverDirection().ShouldEqual(Direction.W);
		};
	}
}