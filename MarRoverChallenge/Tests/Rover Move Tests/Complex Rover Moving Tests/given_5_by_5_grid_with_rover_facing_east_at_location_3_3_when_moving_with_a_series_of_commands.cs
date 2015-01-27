using Machine.Specifications;
using MarRoverChallenge.Implementation.Movers;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Tests
{
	public class given_5_by_5_grid_with_rover_facing_east_at_location_3_3_when_moving_with_a_series_of_commands : RoverTestsBase
	{

		Establish context = () =>
		{
			Create5x5Grid_And_PlaceRoverFacingEastAt(3, 3);
		};

		Because of = () =>
		{
			var commands = new[] { 'f', 'f', 'r', 'f' ,'f', 'r' ,'f' ,'r', 'r', 'f' };
			Rover.Move(commands);
		};

		It should_end_up_at_positon_0_1 = () =>
		{
			Rover.RoverPosition().ShouldEqual(Position.SepecificCoord(5, 1));
		};

		It should_be_facing_east = () =>
		{
			Rover.RoverDirection().ShouldEqual(Direction.E);
		};
	}
}