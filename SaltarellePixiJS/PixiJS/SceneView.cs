using System;
using System.Html;
using System.Runtime.CompilerServices;


namespace PIXI
{
	public class SceneView : Stage
    {
        private bool _paused = false;
		private Action _updateCb = null;
		private Action _updateDoneCb = null;
		private Scene _root = null;

		public SceneView(int backgroundColor, bool interactive = false)
			: base(backgroundColor, interactive)
		{
			_root = new Scene();
			_root.position.x = SceneViewManager.WindowWidth / 2f;
			_root.position.y = SceneViewManager.WindowHeight / 2f;
			this.AddChild(_root);
		}

		public Scene Scene
		{
			get { return _root; }
		}

		public Action OnUpdate
		{
			get { return _updateCb; }
			set { _updateCb = value; }
		}

		public Action OnUpdateDone
		{
			get { return _updateDoneCb; }
			set { _updateDoneCb = value; }
		}

		public void Update()
		{
			_updateCb();
		}

		public void UpdateDone()
		{
			_updateDoneCb();
		}

		public void Pause()
		{
			_paused = true;
		}

		public void Resume()
		{
			_paused = false;
		}

		public bool IsPaused
		{
			get { return _paused; }
		}


    }    
}


