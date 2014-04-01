using System;
using System.Html;
using System.Runtime.CompilerServices;


namespace PIXI
{		
    [Imported]
    public class Texture
    {
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="baseTexture">The base texture source to create the texture from</param>
		/// <param name="frame">The rectangle frame of the texture to show</param>
		public Texture(BaseTexture baseTexture, Rectangle frame)
		{
		}

		/// <summary>
		/// The base texture of this texture
		/// </summary>
	    public BaseTexture baseTexture;

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
    }    
}


