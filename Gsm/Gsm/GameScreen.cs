﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gsm.Control;

namespace Gsm
{
    public abstract class GameScreen : IGameScreen
    {
        public IGameScreenManager ScreenManager { get; private set; }
        public bool PropagateUpdate { get; protected set; }
        public bool PropagateInput { get; protected set; }
        public bool PropagateDraw { get; protected set; }

        public bool BlockForInput { get; protected set; }
        public ScreenState State { get; private set; }

        public GameScreen()
        {
            PropagateDraw = true;
            State = ScreenState.None;
        }

        public virtual void Load() { }
        public virtual void Unload() { }

        public virtual void Draw() { }
        public virtual void Update() { }
        public virtual void OnKeyPress(KeyPressEventArgs args) { }

        public void OnEnter(IGameScreenManager screenManager)
        {
            ScreenManager = screenManager;
            State = ScreenState.Active;
        }

        public virtual void OnExit()
        {
            ScreenManager = null;
            State = ScreenState.None;
        }

        public virtual void Exit()
        {
            if (ScreenManager != null)
            {
                ScreenManager.Remove(this);
            }
        }
    }
}
