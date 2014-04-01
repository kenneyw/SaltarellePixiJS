using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;


namespace PIXI
{
	/// <summary>
	/// Manages one or more SceneViews.
	/// </summary>
	public class SceneViewManager
    {
        private static JsDictionary<string, SceneView> _scenes = new JsDictionary<string, SceneView>();
        private static SceneView _currentSceneView = null;
		private static dynamic _renderer = null;
        private static float _ratio = 1f;
        private static int _defaultWidth = 1024;
        private static int _defaultHeight = 768;
        private static int _width;
        private static int _height;

		public static void CreateRenderSurface(bool scale)
		{
			CreateRenderSurface(WindowWidth, WindowHeight, true);
		}

		public static void CreateRenderSurface(int w = 0, int h = 0, bool scale=false)
		{
			// create a renderer instance.
			if (w == 0)
				w = WindowWidth;
			if (h == 0)
				h = WindowHeight;
			_defaultWidth = _width = w;
			_defaultHeight = _height = h;

			_renderer = Pixi.AutoDetectRenderer(_width, _height);
			if (scale) 
			{
                Rescale();
                Window.AddEventListener("resize", Rescale, false);
            }

			// add the renderer view element to the DOM
			Document.Body.AppendChild(_renderer.view);

			// start rendering
			RequestAnimFrame(RenderLoop);
		}

		public static dynamic RenderContext
		{
			get { return _renderer.context; }
		}

		public static int RenderSurfaceWidth
		{
			get { return _width; }
		}

		public static int RenderSurfaceHeight
		{
			get { return _height;  }
		}

		public static int WindowWidth
		{
			get { return Window.InnerWidth; }
		}

		public static int WindowHeight
		{
			get { return Window.InnerHeight; }
		}
		
		public static SceneView CreateSceneView(string id, int backgroundColor = 0x000000)
		{
            if (_scenes.ContainsKey(id))
				return null;

			var scene = new SceneView(backgroundColor, true);
            _scenes[id] = scene;
 
            return scene;
        }

		public static bool GoToSceneView(string id)
		{
            if (_scenes.ContainsKey(id)) 
			{
                if (_currentSceneView!=null)
					_currentSceneView.Pause();
                _currentSceneView = _scenes[id];
                _currentSceneView.Resume();
                return true;
            }
            return false;
        }

        private static void RenderLoop() 
		{
            if (_currentSceneView==null || _currentSceneView.IsPaused) 
				return;

            _currentSceneView.Update();
			//ApplyRatio(_currentSceneView.Scene, _ratio); //scale to screen size
			_renderer.render(_currentSceneView);
			//ApplyRatio(_currentSceneView.Scene, 1f / _ratio); //restore original scale
			_currentSceneView.UpdateDone();

			RequestAnimFrame(RenderLoop);
		}

		[InlineCode("requestAnimFrame({f})")]
		private static void RequestAnimFrame(Action f)
		{
		}

		private static void Rescale()
		{
			_ratio = Math.Min((float) WindowWidth/(float) _defaultWidth, (float) WindowHeight/(float) _defaultHeight);
            _width = (int)(_defaultWidth * _ratio);
            _height = (int)(_defaultHeight * _ratio);
            _renderer.resize(_width, _height);
        }

		private static void ApplyRatio(DisplayObject displayObj, float ratio, int depth=0) 
		{
            if (ratio == 1f) 
				return;

            displayObj.position.x = displayObj.position.x * ratio;
            displayObj.position.y = displayObj.position.y * ratio;
            displayObj.scale.x = displayObj.scale.x * ratio;
            displayObj.scale.y = displayObj.scale.y * ratio;

			//if (depth >= 1)
			//	return;

			//DisplayObjectContainer doc = (DisplayObjectContainer)displayObj;
			//for (var i = 0; i < doc.children.Length; i++)
			//{
			//	ApplyRatio(doc.children[i], ratio, ++depth);
			//}
        }
 


    }    
}


