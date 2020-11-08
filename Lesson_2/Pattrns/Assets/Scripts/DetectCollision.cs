using System;
using UnityEngine;

namespace Asteroids
{
	internal class DetectCollision:MonoBehaviour
	{
		public Action<Collider> CollisionHandler;
		public event Action Collision;
		private void OnCollisionEnter2D(Collider2D other)
		{
			Collision?.Invoke();
		}
	}
}
