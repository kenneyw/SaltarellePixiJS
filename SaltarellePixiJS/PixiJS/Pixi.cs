using System;
using System.Html;
using System.Runtime.CompilerServices;


namespace PIXI
{		
    [Imported]
    [IgnoreNamespace]
	[ScriptName("PIXI")]
    public static class Pixi
    {
		/// <summary>
		/// This helper function will automatically detect which renderer you should be using.
		/// WebGL is the preferred renderer as it is a lot fastest. If WebGL is not supported by
		/// the browser then this function will fall back to a canvas renderer.
		/// </summary>
		/// <param name="width"> the width of the canvas view</param>
		/// <param name="height">the height of the canvas view</param>
		/// <param name="view">the canvas to use as a view, optional</param>
		/// <param name="transparent">the transparency of the render view, default false</param>
		public static dynamic AutoDetectRenderer(int width, int height, object view = null, bool transparent = false, bool antialias = false)
		{
			return null; 
		}

		public enum BlendModes { NORMAL = 0, Screen = 1 };

	}    
}


