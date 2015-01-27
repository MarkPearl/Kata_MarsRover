using Machine.Specifications;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Tests
{
	public class when_the_two_positions_are_identical : given_two_positions
	{
		Establish context = () =>
		{

		};

		Because of = () =>
		{
			Position1 = Position.SepecificCoord(0, 0);
			Position2 = Position.SepecificCoord(0, 0);
		};

		It should_be_considered_the_same_position = () =>
		{
			Position1.ShouldEqual(Position2);
		};	
	}
}