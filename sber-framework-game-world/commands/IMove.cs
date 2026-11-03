namespace sber_framework_game_world.commands
{
    public interface IMove : IPosition, IDirection
    {
        public void Move()
        {
            var position = Position;
            switch (Direction)
            {
                case Direction.East:
                    position.X++;
                    break;
                case Direction.West:
                    position.X--;
                    break;
                case Direction.North:
                    position.Y++;
                    break;
                case Direction.South:
                    position.Y--;
                    break;
            }
            Position = position;
        }
    }

}
