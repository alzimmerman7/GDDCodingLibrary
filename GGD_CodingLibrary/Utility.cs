/*
    Made by alzimmerman7

    Useful code for 2D games
    Made for use in Unity and Godot
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGD_CodingLibrary
{
    internal class Utility
    {
        private readonly IKeyboardInput kbInput;
        private readonly IMouseInput mouseInput;

        internal Utility(IKeyboardInput _kbInput, IMouseInput _mouseInput)
        {
            kbInput = _kbInput;
            mouseInput = _mouseInput;
            kbInput.OnKeyPressed += KeyAction;
        }

        private void KeyAction(string key)
        {

        }
    }
}
