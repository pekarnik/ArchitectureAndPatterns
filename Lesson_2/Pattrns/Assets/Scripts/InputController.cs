using UnityEngine;

namespace Asteroids
{
	internal sealed class InputController : IExecute
	{
		private Player _player; 
		public InputController(Player player)
		{
			_player = player;
		}
		public void Execute()
		{
			if (Input.GetKeyDown(KeyCode.LeftShift))
			{
				_player.AddShipAcceleration();
			}
			if (Input.GetKeyUp(KeyCode.LeftShift))
			{
				_player.RemoveShipAcceleration();
			}
			if (Input.GetButtonDown("Fire1"))
			{
				_player.OnFire();
			}
			_player.MoveShip(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
			_player.Rotate(Input.mousePosition);
		}
	}
}
