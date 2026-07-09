using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGD_CodingLibrary
{
    public class AABB
    {
        public float Width { get; }
        public float Height { get; }
        public float X { get; }
        public float Y { get; }

        public AABB(float x, float y, float width, float height)
        {
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }

    }
}
