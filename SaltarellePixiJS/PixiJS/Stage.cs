using System;
using System.Html;
using System.Runtime.CompilerServices;


namespace PIXI
{		
    [Imported]
	public class Stage : DisplayObjectContainer
    {
		/// <summary>
		/// A Stage represents the root of the display tree. Everything connected to the stage is rendered
		/// </summary>
		/// <param name="backgroundColor">the background color of the stage, easiest way to pass this in is in hex format like: 0xFFFFFF for white</param>
		/// <param name="interactive">enable / disable interaction (default is false)</param>
		public Stage (int backgroundColor, bool interactive=false) { }
    }    
}


