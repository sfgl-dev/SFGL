//-----------------------------------------------------------------------------
// GameComponent.cs
//
// Spooker Open Source Game Framework
// Copyright (C) Indie Armory. All rights reserved.
// Website: http://indiearmory.com
// Other Contributors: None
// License: MIT
//-----------------------------------------------------------------------------

using SFML.Graphics;
using Spooker.Audio;
using Spooker.Content;
using Spooker.Input;

namespace Spooker.Core
{
	////////////////////////////////////////////////////////////
	/// <summary>
	/// Abstract class what will enable you to use all Game 
	/// functions in derived classes.
	/// </summary>
	////////////////////////////////////////////////////////////
	public abstract class GameComponent
	{
		/// <summary>Heart of Spooker. All important operations are done here.</summary>
        protected GameWindow Game;

		/// <summary>Core rendering device what controls everything drawn to screen.</summary>
		protected RenderWindow GraphicsDevice
		{
			get { return Game.GraphicsDevice; }
		}

		/// <summary>Manages various game content (audio, textures, fonts....).</summary>
		protected ContentManager Content
		{ 
			get { return Game.Content; }
		}

		/// <summary>Can play various audio files.</summary>
		protected AudioManager Audio
		{ 
			get { return Game.Audio; }
		}

		/// <summary>Handles user input from keyboard and mouse.</summary>
		protected GameInput GameInput
		{ 
			get { return Game.GameInput; }
		}

		////////////////////////////////////////////////////////////
		/// <summary>
		/// Creates new instance of GameComponent class.
		/// </summary>
		/// <param name="game">Parent game window.</param>
		////////////////////////////////////////////////////////////
		protected GameComponent(GameWindow game)
		{
			Game = game;
		}
	}
}
