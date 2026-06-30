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
    internal class _2D
    {
        Utility util;

        private readonly IKeyboardInput kbInput;
        private readonly IMouseInput mouseInput;

        internal _2D(IKeyboardInput _kbInput, IMouseInput _mouseInput)
        {
            kbInput = _kbInput;
            mouseInput = _mouseInput;

            //Key Actions
            kbInput.OnKeyPressed += KeyAction;
        }

        private void KeyAction(string key)
        {
            switch (key.ToLower())
            {
                case "rightarrow":
                    break;
                case "d":
                    break;
                case "uparrow":
                    break;
                case "w":
                    break;
                case "downarrow":
                    break;
                case "s":
                    break;
                case "leftarrow":
                    break;
                case "a":
                    break;
                case "space":
                    break;
                case "enter":
                    break;
                case "escape":
                    break;
            }
        }

        //Collision

        //Movement

        //UI

        //Animation

    }
}
