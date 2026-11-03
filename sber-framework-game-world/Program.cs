using sber_framework_game_world.commands;
using sber_framework_game_world.units;

namespace sber_framework_game_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IUnit> units = new List<IUnit>
            {
                new Wind(Direction.North),
                new Stone(new Position(5, 5)),
                new Tractor(Direction.East, new Position(0, 0)),
                new Tank(new Position(10, 10),Direction.South, 10),
                new Tower(new Position(15, 15), Direction.West, 5)
            };

            var rotateCommand = new RotateCommand();
            var moveCommand = new MoveCommand();
            var fireCommand = new FireCommand();
            var reloadCommand = new ReloadGunCommand(10);

            foreach (var unit in units)
            {
                rotateCommand.Execute(unit);
                moveCommand.Execute(unit);
                fireCommand.Execute(unit);
                reloadCommand.Execute(unit);

                rotateCommand.Execute(unit);
                moveCommand.Execute(unit);
                fireCommand.Execute(unit);
                reloadCommand.Execute(unit);

            }

            Console.ReadKey();
        }
    }
}
