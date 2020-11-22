using UnityEngine;
namespace Asteroids
{
	internal sealed class WarShipFactory : IEnemyFactory
	{
		public Enemy Create(Health hp)
		{
			var enemy =
				Object.Instantiate(Resources.Load<WarShip>("Enemy/Asteroid"));

			return enemy;
		}
	}
}
