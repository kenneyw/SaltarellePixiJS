using System;
using System.Html;
using System.Runtime.CompilerServices;


namespace PIXI
{
	/// <summary>
	/// the CanvasRenderer draws the stage and all its content onto a 2d canvas. This renderer should be used for browsers that do not support webGL.
	/// Dont forget to add the view to your DOM or you will not see anything :)
	/// </summary>
    [Imported]
	public class CanvasRenderer
    {
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="width"> the width of the canvas view</param>
		/// <param name="height">the height of the canvas view</param>
		/// <param name="view">the canvas to use as a view, optional</param>
		/// <param name="transparent">the transparency of the render view, default false</param>
		public CanvasRenderer(int width, int height, object view = null, bool transparent = false) { }
	}    
}


