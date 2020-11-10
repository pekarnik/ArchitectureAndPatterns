namespace Asteroids.AbstractFactory
{
	internal sealed class ConsoleWindow : IWindow
	{
		public string Name => nameof(ConsoleWindow);
	}
}