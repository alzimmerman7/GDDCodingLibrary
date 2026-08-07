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
    /*
        The Utility Class is used as a placeholder class where you can write
        methods that can be used in any other class. If there is common code that
        you find yourself writing over and over again the utility class can be
        used to hold on to that code and store it as a method that can just be called 
        later.

        The Utility class is very useful for decluttering your code by removing most of 
        the repetitive code seen in other classes
     */
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
