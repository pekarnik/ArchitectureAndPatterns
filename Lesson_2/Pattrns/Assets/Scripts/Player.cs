using UnityEngine;
namespace Asteroids
{
	internal sealed class Player
	{
		private float _speed;
		private float _acceleration;
		private float _hp;
		private Rigidbody2D _bullet;
		private Transform _barrel;
		private float _force;
		private Camera _camera;
		private Ship _ship;
		private GameObject _gameObject;
		private Transform _transform;
		private DetectCollision _detectCollision;
		public Player(GameObject gameObject, DetectCollision detectCollision, float speed, float acceleration, float hp, Rigidbody2D bullet, Transform barrel, float force)
		{
			_speed = speed;
			_acceleration = acceleration;
			_hp = hp;
			_bullet = bullet;
			_barrel = barrel;
			_force = force;
			_gameObject = gameObject;
			_transform = _gameObject.transform;
			_camera = Camera.main;
			var moveTransform = new AccelerationMove(_transform, _speed,
		   _acceleration);
			var rotation = new RotationShip(_transform);
			_ship = new Ship(moveTransform, rotation);
			_detectCollision = detectCollision;
			_detectCollision.Collision += OnCollision;
		}
		public void AddShipAcceleration()
		{
			_ship.AddAcceleration();
		}
		public void RemoveShipAcceleration()
		{
			_ship.RemoveAcceleration();
		}
		public void MoveShip(float axisHor, float axisVer)
		{
			_ship.Move(axisHor, axisVer,
		   Time.deltaTime);
		}
		public void OnFire()
		{
			var temAmmunition = Object.Instantiate(_bullet, _barrel.position,
					_barrel.rotation);
			temAmmunition.AddForce(_barrel.up * _force);
		}
		public void Rotate(Vector3 posToRotate)
		{
			var direction = posToRotate -
		   _camera.WorldToScreenPoint(_transform.position);
			_ship.Rotation(direction);
		}
		private void OnCollision(Collider other)
		{
			if (_hp <= 0)
			{
				Object.Destroy(_gameObject);
			}
			else
			{
				_hp--;
			}
		}
	}
}