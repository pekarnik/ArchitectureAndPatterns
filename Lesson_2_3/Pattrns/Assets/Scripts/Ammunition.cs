using UnityEngine;

namespace Assets.Scripts
{
	internal sealed class Ammunition
	{
		private Rigidbody2D _bullet;
		private Transform _barrel;
		private float _force;
		private Rigidbody2D[] _ammo;
		private int _index = 0;
		private bool[] _indexes;
		public Ammunition(Rigidbody2D bullet, Transform barrel, float force)
		{
			_bullet = bullet;
			_barrel = barrel;
			_force = force;
			_ammo = new Rigidbody2D[10];
			_indexes = new bool[10];
			for(int i = 0;i<10;i++)
			{
				_ammo[i] = Object.Instantiate(_bullet, _barrel.position, _barrel.rotation);
				_ammo[i].gameObject.SetActive(false);
			}
		}
		public void Fire()
		{
			if(_indexes[_index])
			{
				_ammo[_index].transform.position = _barrel.position;
			}
			_ammo[_index].gameObject.SetActive(true);
			_ammo[_index].AddForce(_barrel.up * _force);
			_indexes[_index] = true;
			_index++;
			if(_index > 9)
			{
				_index = 0;
			}

		}
	}
}
