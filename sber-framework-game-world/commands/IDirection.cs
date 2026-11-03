namespace sber_framework_game_world.commands
{
    public interface IDirection
    {
        Direction Direction { get; set; }
    }

    public enum Direction
    {
        North,
        East,
        South,
        West
    }
}
