using System;
using System.Html;
using System.Runtime.CompilerServices;


namespace PIXI
{		
	[ScriptName("PIXI")]
    public static class Util
    {
		/// <summary>
		/// Number of children in the DisplayObjectContainer
		/// </summary>
		/// <param name="do">DisplayObject</param>
		/// <param name="recursive">Deep count</param>
		public static int ChildrenCount(DisplayObject @do, bool recursive = true)
		{
			dynamic ddo = @do;
			if (!ddo.children)
				return 0;
			int count = ddo.children.length;
			if (recursive)
			{
				for (var i = 0; i < ddo.children.length; i++)
				{
					count += ChildrenCount(ddo.children[i]);
				}
			}
			return count; 
		}

		public enum BlendModes { NORMAL = 0, Screen = 1 };

	}    
}


