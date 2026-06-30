using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGD_CodingLibrary
{
    internal interface IKeyboardInput
    {
        event Action<string> OnKeyPressed;
    }
}
