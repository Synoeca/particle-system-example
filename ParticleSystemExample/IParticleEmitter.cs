﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystemExample
{
	public interface IParticleEmitter
	{
		public Vector2 Position { get;  }

		public Vector2 Velocity { get;  }
	}
}
