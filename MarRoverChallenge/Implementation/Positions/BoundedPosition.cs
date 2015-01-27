namespace MarRoverChallenge.Implementation.Positions
{
	public class BoundedPosition
	{
		readonly Bounds _bounds;
		readonly Position _position;

		public static BoundedPosition Create(
			Bounds bounds, 
			Position position)
		{
			return new BoundedPosition(bounds, position);
		}

		private BoundedPosition(
			Bounds bounds,
			Position position)
		{
			_bounds = bounds;
			_position = position;
		}

		public void MoveUp()
		{
			_position.MoveUp();
			HandleGoingOverTopBounds();
		}

		public void MoveDown()
		{
			_position.MoveDown();
			HandleGoingOverBottomBounds();
		}

		public void MoveRight()
		{
			_position.MoveRight();
			HandleGoingOverRightBounds();
		}

		public void MoveLeft()
		{
			_position.MoveLeft();
			HandleGoingOverLeftBounds();
		}

		void HandleGoingOverBottomBounds()
		{
			if (!AtBottomOfMap()) return;
			MoveToTopOfMap();
		}

		void HandleGoingOverRightBounds()
		{
			if (!AtRightOfMap()) return;
			MoveToTopOfMap();
		}

		void HandleGoingOverLeftBounds()
		{
			if (!AtLeftOfMap()) return;
			MoveToRightOfMap();
		}

		void HandleGoingOverTopBounds()
		{
			if (!AtTopOfMap()) return;
			MoveToBottomOfMap();
		}

		void MoveToTopOfMap()
		{
			_position.Y = 1;
		}

		void MoveToBottomOfMap()
		{
			_position.Y = _bounds.Y;
		}

		void MoveToRightOfMap()
		{
			_position.X = _bounds.X;
		}

		bool AtLeftOfMap()
		{
			return _position.X < 0;
		}

		bool AtTopOfMap()
		{
			return _position.Y < 0;
		}

		bool AtBottomOfMap()
		{
			return _position.Y > _bounds.Y;
		}

		bool AtRightOfMap()
		{
			return _position.X > _bounds.X;
		}

		public Position Position
		{
			get { return _position; }
		}
	}
}