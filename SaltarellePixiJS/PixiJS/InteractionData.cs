using System;
using System.Html;
using System.Runtime.CompilerServices;


namespace PIXI
{	
	/// <summary>
	/// Holds all information related to an Interaction event
	/// </summary>
    [Imported]
	public class InteractionData
    {

	
		/// <summary>
		/// This point stores the global coords of where the touch/mouse event happened
		/// </summary>
		public Point global;

		/// <summary>
		/// this is here for legacy... but will remove
		/// </summary>
		public Point local;

		/// <summary>
		/// When passed to an event handler, this will be the original DOM Event that was captured
		/// </summary>
		public System.Html.Event originalEvent;

    }    
}

