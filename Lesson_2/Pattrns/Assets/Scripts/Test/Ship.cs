

using System;
using UnityEngine;

namespace Asteroids.Test
{
    internal class Ship : IShip
    {
        public float Speed { get; }
        public void Move(float horizontal, float vertical, float deltaTime)
        {
            throw new System.NotImplementedException();
        }

        public void Rotation(Vector3 direction)
        {
            throw new System.NotImplementedException();
        }
    }

    internal interface IShip : IMove, IRotation
    {
    }

    class OldShip : IMove
    {
        public void Move()
        {
            // good
        }

        [Obsolete]
        public void Rotate()
        {
            throw new System.NotImplementedException();
        }

        public float Speed { get; }
        public void Move(float horizontal, float vertical, float deltaTime)
        {
        }
    }
}
