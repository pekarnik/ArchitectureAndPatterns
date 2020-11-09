using Assets.Scripts;
using UnityEngine;

namespace Asteroids
{
	internal sealed class InputController
	{
        private Camera _camera;
        private Transform _transform;
        private Ship _ship;
        private Ammunition _ammunition;
        public InputController(Camera camera, Transform transform, Ship ship, Transform barrel, float force, Rigidbody2D bullet)
		{
            _camera = camera;
            _transform = transform;
            _ship = ship;
            _ammunition = new Ammunition(bullet, barrel,force);
		}
        public void Execute()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(_transform.position);
            _ship.Rotation(direction);

            _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();
            }

            if (Input.GetButtonDown("Fire1"))
            {
                _ammunition.Fire();
            }
        }
    }
}
