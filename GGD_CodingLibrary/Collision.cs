using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GGD_CodingLibrary
{
    public class Collision
    {
        public Collision() { }
        public bool Intersects(AABB rect1, AABB rect2)
        {
            return rect1.X + rect1.Width >= rect2.X &&
            rect1.X <= rect2.X + rect2.Width &&
            rect1.Y + rect1.Height >= rect2.Y &&
            rect1.Y <= rect2.Y + rect2.Height;
        }

        public List<float> Intersect(AABB rect1, AABB rect2) 
        {
            AABB intersect;
            float num = Math.Min(rect1.X + rect1.Width, rect2.X + rect2.Width);
            float num2 = Math.Max(rect1.X, rect2.X);
            float num3 = Math.Max(rect1.Y, rect2.Y);
            float num4 = Math.Min(rect1.Y + rect1.Height, rect2.Y + rect2.Height);
            intersect = new AABB(num2, num3, num - num2, num4 - num3);

            if (rect1.X <= rect2.X)
            {
                if (rect1.Y <= rect2.Y)
                {
                    return new List<float> { -intersect.Width, -intersect.Height };
                }
                if (rect1.Y > rect2.Y)
                {
                    return new List<float> { -intersect.Width, intersect.Height };
                }
            }
            if (rect1.X > rect2.X)
            {
                if (rect1.Y <= rect2.Y)
                {
                    return new List<float> { intersect.Width, -intersect.Height };
                }
                if (rect1.Y > rect2.Y)
                {
                    return new List<float> { intersect.Width, intersect.Height };
                }
            }
            return null;
        }
    }
}
