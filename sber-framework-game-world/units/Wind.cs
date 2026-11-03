using sber_framework_game_world.commands;

namespace sber_framework_game_world.units
{
    public class Wind : IUnit, IRotatable
    {
        public Direction Direction { get; set; }

        public Wind(Direction direction)
        {
            Direction = direction;
        }
       
    }
}
