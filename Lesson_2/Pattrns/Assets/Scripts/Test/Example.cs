namespace Asteroids.Test
{
    internal sealed class Example
    {
        private float _hp;
        private void NameMethod()
        {
            if (_hp > 0)
            {
                ApplyDamage();
            }
        }

        private void ApplyDamage()
        {
            if (_hp > 0)
            {
                _hp -= 10;
            }
        }
    }
}
