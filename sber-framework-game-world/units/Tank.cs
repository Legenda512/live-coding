using sber_framework_game_world.commands;

namespace sber_framework_game_world.units
{
    public class Tank : IUnit, IPosition, IRotatable, IFire, IMove
    {
        public Position Position { get; set; }
        public Direction Direction { get; set; }
        private int cartridges;

        public int Cartridges
        {
            get => cartridges;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));

                cartridges = value;
            }
        }

        public Tank(Position position, Direction direction, int cartridges)
        {
            Position = position;
            Direction = direction;
            Cartridges = cartridges;
        }
    }
}
