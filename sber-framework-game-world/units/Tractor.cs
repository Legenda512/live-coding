using sber_framework_game_world.commands;
namespace sber_framework_game_world.units
{
    public class Tractor : IUnit, IRotatable, IMove
    {
        public Direction Direction { get; set; }
        public Position Position { get; set; }

        public Tractor(Direction direction, Position position)
        {
            Direction = direction;
            Position = position;
        }
    }
}
