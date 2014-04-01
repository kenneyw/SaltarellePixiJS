using System;
using System.Html;
using System.Runtime.CompilerServices;


namespace PIXI
{
	/// <summary>
	/// A DisplayObjectContainer represents a collection of display objects.
	/// It is the base class of all display objects that act as a container for other objects.
	/// </summary>
	[Imported]
	public class DisplayObjectContainer : DisplayObject
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public DisplayObjectContainer()
		{
		}

		/// <summary>
		/// [read-only] The of children of this container.
		/// </summary>
		public DisplayObject[] children;

		/// <summary>
		/// Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown
		/// </summary>
		/// <param name="child">The DisplayObject to add to the container</param>
		public void AddChild(object child)
		{
		}

		/// <summary>
		/// Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown
		/// </summary>
		/// <param name="child">The child to add</param>
		/// <param name="index">The index to place the child in</param>
		public void AddChildAt(DisplayObject child, int index)
		{
		}

		/// <summary>
		/// Returns the Child at the specified index
		/// </summary>
		/// <param name="index">The index to get the child from</param>
		/// <returns></returns>
		public DisplayObject GetChildAt(int index)
		{
			return null;
		}

		/// <summary>
		/// Removes a child from the container.
		/// </summary>
		/// <param name="child">The DisplayObject to remove</param>
		public void RemoveChild(DisplayObject child)
		{
		}
	}
}


