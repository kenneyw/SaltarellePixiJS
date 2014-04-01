using System;
using System.Html;
using System.Runtime.CompilerServices;


namespace PIXI
{	
	/// <summary>
	/// The Point object represents a location in a two-dimensional coordinate system, where x represents the horizontal axis and y represents the vertical axis.
	/// </summary>
    [Imported]
	public class Rectangle
    {
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="x">The X coord of the upper-left corner of the rectangle</param>
		/// <param name="y">The Y coord of the upper-left corner of the rectangle</param>
		/// <param name="width">The overall wisth of this rectangle</param>
		/// <param name="height">The overall height of this rectangle</param>
		public Rectangle(float x, float y, float width, float height) { }

		/// <summary>
		/// The X coord of the upper-left corner of the rectangle
		/// </summary>
		public float x;

		/// <summary>
		/// The Y coord of the upper-left corner of the rectangle
		/// </summary>
		public float y;

		/// <summary>
		/// The overall wisth of this rectangle
		/// </summary>
		public float width;

		/// <summary>
		/// The overall height of this rectangle
		/// </summary>
		public float height;
	}    
}


