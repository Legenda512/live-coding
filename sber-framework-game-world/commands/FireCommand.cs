using sber_framework_game_world.units;

namespace sber_framework_game_world.commands
{
    public class FireCommand: ICommand
    {
        public void Execute(IUnit unit)
        {
            if (unit is IFire fireUnit)
            {
                fireUnit.Fire();
            }
            else
            {
                Console.WriteLine($"Unit: {unit.GetType().Name}, не стреляет");
            }
        }
    }
}
