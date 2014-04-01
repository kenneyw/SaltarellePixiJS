using System;
using System.Html;
using System.Runtime.CompilerServices;


namespace PIXI
{		
    [Imported]
    public class BaseTexture
    {
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="baseTexture">The base texture source to create the texture from</param>
		/// <param name="frame">The rectangle frame of the texture to show</param>
		public BaseTexture(BaseTexture baseTexture, Rectangle frame)
		{
		}

		/// <summary>
		/// [read-only] The width of the base texture set when the image has loaded
		/// </summary>
		public float width;

		/// <summary>
		/// [read-only] The height of the base texture set when the image has loaded
		/// </summary>
		public float height;

		/// <summary>
		/// The scale mode to apply when scaling this texture
		/// @type PIXI.scaleModes
		/// @default PIXI.scaleModes.LINEAR
		/// </summary>
		public int scaleMode;

		/// <summary>
		/// [read-only] Describes if the base texture has loaded or not
		/// </summary>
		public bool hasLoaded;

		/// <summary>
		/// The source that is loaded to create the texture
		/// </summary>
		public object source;

		/// <summary>
		/// The frame specifies the region of the base texture that this texture uses
		/// </summary>
	    public Rectangle frame;

		/// <summary>
		/// The trim point
		/// </summary>
	    public Point trim;

		/// <summary>
		/// Helper function that returns a texture based on an image url
		/// If the image is not in the texture cache it will be  created and loaded
		/// </summary>
		/// <param name="imageUrl">The image url of the texture</param>
		/// <param name="crossorigin">Whether requests should be treated as crossorigin</param>
		public static dynamic FromImage(string imageUrl, bool crossorigin = false)
		{
			return null; 
		}

		/// <summary>
		/// Destroys this base texture
		/// </summary>
		public void Destroy()
		{
		}

	    public void AddEventListener(String type, Action eventListener)
	    {
	    }
    }    
}


