using sber_framework_game_world.units;
namespace sber_framework_game_world.commands
{
    public interface ICommand
    {
        void Execute(IUnit unit);
    }
}
