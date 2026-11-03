namespace sber_framework_game_world.commands
{
    public interface IPosition
    {
        Position Position { get; set; }
    }

    public struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
