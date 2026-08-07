using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GGD_CodingLibrary
{
    internal interface IMouseInput
    {
        //Get Cursor Position
        float X { get; }
        float Y { get; }
        (float X, float Y) Position => (X, Y);

        //Get whether mouse buttons are pressed
        bool IsLeftClicked { get; }
        bool IsRightClicked { get; }
    }
}
