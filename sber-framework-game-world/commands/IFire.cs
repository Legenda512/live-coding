namespace sber_framework_game_world.commands
{
    public interface IFire
    {
        public int Cartridges { get; set; }

        public void Fire()
        {
            if (Cartridges > 0)
            {
                Cartridges--;
            }
        }
    }
}
