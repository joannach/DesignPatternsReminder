using System;

namespace DesignPatternsReminder.SOLID.DependecyInversion
{
    public class Reaserch
    {
        public Reaserch(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("Konstantyn"))
                Console.WriteLine("Konstantyn has a child: " + p.Name);
        }
    }
}
