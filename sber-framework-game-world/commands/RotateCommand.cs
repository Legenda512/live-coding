using sber_framework_game_world.units;
namespace sber_framework_game_world.commands
{
    public class RotateCommand: ICommand
    {
        public void Execute(IUnit unit)
        {
            if (unit is IRotatable rotatableUnit)
            {
                rotatableUnit.RotateClockwise();
                Console.WriteLine($"Unit: {unit.GetType().Name}, Направление: {rotatableUnit.Direction}");
            }
            else
            {
                Console.WriteLine($"Unit: {unit.GetType().Name}, не поворачивается");
            }
        }
    }
}
