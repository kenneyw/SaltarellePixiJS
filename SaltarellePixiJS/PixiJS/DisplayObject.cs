using System;
using System.Html;
using System.Runtime.CompilerServices;


namespace PIXI
{
	/// <summary>
	/// The base class for all objects that are rendered on the screen.
	/// </summary>
	[Imported]
	public class DisplayObject
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public DisplayObject()
		{
		}

		/// <summary>
		/// The position of the object.
		/// </summary>
		public Point position;

		/// <summary>
		/// The scale factor of the object.
		/// </summary>
		public Point scale;

		/// <summary>
		/// The pivot point of the displayObject that it rotates around
		/// </summary>
		public Point pivot;

		/// <summary>
		/// The rotation of the object in radians.
		/// </summary>
		public float rotation;

		/// <summary>
		/// The opacity of the object.
		/// </summary>
		public int alpha;

		/// <summary>
		/// The visibility of the object.
		/// </summary>
		public bool visible;

		/// <summary>
		/// This is the defined area that will pick up mouse / touch events. It is null by default.
		/// Setting it is a neat way of optimising the hitTest function that the interactionManager 
		/// will use (as it will not need to hit test all the children)
		/// type: Rectangle|Circle|Ellipse|Polygon
		/// </summary>
		public int hitArea;

		/// <summary>
		/// This is used to indicate if the displayObject should display a mouse hand cursor on rollover
		/// </summary>
		public bool buttonMode;

		/// <summary>
		/// Can this object be rendered
		/// </summary>
		public bool renderable;

		/// <summary>
		/// [read-only] The display object container that contains this display object.
		/// </summary>
		public DisplayObjectContainer parent;

		/// <summary>
		/// [read-only] The stage the display object is connected to, or undefined if it is not connected to the stage.
		/// </summary>
		public Stage stage;

		/// <summary>
		/// [read-only] The multiplied alpha of the displayobject
		/// </summary>
		public float worldAlpha;

		/// <summary>
		/// Indicates if the sprite will have touch and mouse interactivity. It is false by default
		/// </summary>
		[IntrinsicProperty]
		public bool interactive { get; set; }

		public Func<InteractionData, bool> mousemove;
		public Func<InteractionData, bool> click;

		/// <summary>
		/// Updates the container's children's transform for rendering
		/// </summary>
		public void UpdateTransform()
		{
		}
	}
}


