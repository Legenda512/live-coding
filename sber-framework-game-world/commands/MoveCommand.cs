
using sber_framework_game_world.units;

namespace sber_framework_game_world.commands
{
    public class MoveCommand : ICommand
    {
        public void Execute(IUnit unit)
        {
            if (unit is IMove moveUnit)
            {
                moveUnit.Move();
                Console.WriteLine($"Unit: {unit.GetType().Name}, сделал движение {moveUnit.Position.X}, {moveUnit.Position.Y}");
            }
            else
            {
                Console.WriteLine($"Unit: {unit.GetType().Name}, не двигается");
            }
        }
    }
}


