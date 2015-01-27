using Machine.Specifications;
using MarRoverChallenge.Implementation.Positions;

namespace MarRoverChallenge.Tests
{
	public class when_the_two_positions_are_not_identical : given_two_positions
	{
		Establish context = () =>
		{

		};

		Because of = () =>
		{
			Position1 = Position.SepecificCoord(1, 0);
			Position2 = Position.SepecificCoord(0, 1);
		};

		It should_not_be_considered_the_same_position = () =>
		{
			Position1.ShouldNotEqual(Position2);
		};
	}
}