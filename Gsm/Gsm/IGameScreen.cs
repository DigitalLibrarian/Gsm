using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gsm.Control;

namespace Gsm.Gsm
{
    public interface IGameScreen
    {
        IGameScreenManager ScreenManager { get; }

        bool BlockForInput { get; }
        bool PropagateUpdate { get; }
        bool PropagateInput { get; }
        bool PropagateDraw { get; }

        ScreenState State { get; }

        void Exit();

        void Load();
        void Unload();

        void Draw();
        void Update();
        void OnKeyPress(KeyPressEventArgs args);

        void OnEnter(IGameScreenManager screenManager);
        void OnExit();

    }

}
