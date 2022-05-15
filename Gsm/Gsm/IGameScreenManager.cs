using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gsm.Control;

namespace Gsm.Gsm
{
    public interface IGameScreenManager
    {
        void Add(IGameScreen screen);
        void Remove(IGameScreen screen);

        void Draw();
        void Update();
        void OnKeyPress(object sender, KeyPressEventArgs args);

        bool BlockForInput { get; }
    }
}
