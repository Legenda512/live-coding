using sber_framework_game_world.commands;

namespace sber_framework_game_world.units
{
    public class Stone : IUnit, IPosition
    {
        public Position Position { get ; set; }
        public Stone(Position position)
        {
            Position = position;
        }
    }
}
