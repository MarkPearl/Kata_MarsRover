using System;

namespace MarRoverChallenge.Implementation.Exceptions
{
	public class CommandNotRecognizedException : Exception
	{
		public CommandNotRecognizedException(char notRecognizedCommand) : base(notRecognizedCommand.ToString())
		{
			
		}
	}
}