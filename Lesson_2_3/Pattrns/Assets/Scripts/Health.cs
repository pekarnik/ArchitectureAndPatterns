namespace Asteroids
{
    internal sealed class Health : IHealth
    {
        private readonly int _maxHp;

        public int MAXHp => _maxHp;
        public float CurrentHp { get; private set; }

        public Health(int maxHp)
        {
            _maxHp = maxHp;
            CurrentHp = _maxHp;
        }

        public void ApplyDamage(float value)
        {
            CurrentHp -= value;
        }
    }

    internal interface IHealth
    { 
        int MAXHp { get; }
       float CurrentHp { get; }
       void ApplyDamage(float value);
    }
}
