﻿using System;
using UnityEngine;
namespace Asteroids.AbstractFactory
{
	internal sealed class InputFactory
	{
		[Obsolete]
		public IInput CreateInput(RuntimePlatform platform)
		{
			switch (platform)
			{
				case RuntimePlatform.WindowsPlayer:
				case RuntimePlatform.WindowsEditor:
					return new PCInput();
				case RuntimePlatform.XBOX360:
				case RuntimePlatform.PS3:
					return new ConsoleInput();
				default:
					throw new ArgumentOutOfRangeException(nameof(platform),
				   platform, null);
			}
		}
	}
}
