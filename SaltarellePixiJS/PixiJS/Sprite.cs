using System;
using System.Html;
using System.Runtime.CompilerServices;


namespace PIXI
{	
	/// <summary>
	/// The Sprite class is the base for all textured objects that are rendered to the screen
	/// </summary>
    [Imported]
	public class Sprite : DisplayObjectContainer
    {
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="texture">The texture for this sprite</param>
		public  Sprite(Texture texture) { }

		/// The anchor sets the origin point of the texture.
		/// The default is 0,0 this means the textures origin is the top left 
		/// Setting than anchor to 0.5,0.5 means the textures origin is centered
		/// Setting the anchor to 1,1 would mean the textures origin points will be the bottom right
		public Point anchor;

		/// <summary>
		/// The texture that the sprite is using
		/// </summary>
		public Texture texture;

		/// <summary>
		/// The blend mode of sprite.
		/// currently supports PIXI.blendModes.NORMAL and PIXI.blendModes.SCREEN
		/// </summary>
		public Pixi.BlendModes blendMode ;

		/// <summary>
		/// The width of the sprite, setting this will actually modify the scale to acheive the value set
		/// </summary>
		public float width;

		/// <summary>
		/// The height of the sprite, setting this will actually modify the scale to acheive the value set
		/// </summary>
		public float height;

    }    
}


