using UnityEngine;
namespace Asteroids
{
	internal sealed class WarShip:Enemy
	{
		[SerializeField]
		private Transform _player;
		private float _speed;
		private void Update()
		{
			transform.position = Vector3.MoveTowards(transform.position, _player.position, _speed * Time.deltaTime);
			transform.LookAt(_player);
		}
	}
}
