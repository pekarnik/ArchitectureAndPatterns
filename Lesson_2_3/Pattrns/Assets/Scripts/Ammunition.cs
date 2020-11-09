using UnityEngine;

namespace Assets.Scripts
{
	internal sealed class Ammunition
	{
		private Rigidbody2D _bullet;
		private Transform _barrel;
		private float _force;
		public Ammunition(Rigidbody2D bullet, Transform barrel, float force)
		{
			_bullet = bullet;
			_barrel = barrel;
			_force = force;

		}
		public void Fire()
		{
			var temAmmunition = Object.Instantiate(_bullet, _barrel.position, _barrel.rotation);
			temAmmunition.AddForce(_barrel.up * _force);
			Object.Destroy(temAmmunition, 3);
		}
	}
}
