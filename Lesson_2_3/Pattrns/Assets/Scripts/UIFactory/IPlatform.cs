﻿namespace Asteroids.AbstractFactory
{
	public interface IPlatform
	{
		IInput Input { get; }
		IWindow Window { get; }
	}
}
