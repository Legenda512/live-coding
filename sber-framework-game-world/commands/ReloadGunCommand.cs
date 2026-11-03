using sber_framework_game_world.units;

namespace sber_framework_game_world.commands
{
    public class ReloadGunCommand : ICommand
    {
        private int cartridgesReload;

        public int CartridgesReload
        {
            get => cartridgesReload;
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));

                cartridgesReload = value;
            }
        }

        public ReloadGunCommand(int cartridgesReload)
        {
            CartridgesReload = cartridgesReload;
        }

        public void Execute(IUnit unit)
        {
            if (unit is IFire fireUnit)
            {
                fireUnit.Cartridges += CartridgesReload;
                Console.WriteLine($"Unit: {unit.GetType().Name}, Боеприпасы: {fireUnit.Cartridges}");
            }
            else
            {
                Console.WriteLine($"Unit: {unit.GetType().Name}, не поддерживает перезарядку");
            }
        }
    }
}
