using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsReminder.SOLID.Liskov
{
    public class Area
    {
        public int GetArea(Rectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }
    }
}
