using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsReminder.SOLID.InterfaceSegregation
{
    public interface IBird : IAnimal
    {
        public void Fly();
    }
}
