using System;
using UnityEngine;

namespace Asteroids
{
    [RequireComponent(typeof(Collider2D))]
    internal sealed class DetectCollision : MonoBehaviour
    {
        private IHealth _health;

        public void InjectDependencies(IHealth health)
        {
            _health = health;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            _health.ApplyDamage(10.0f);
        }
    }
}
