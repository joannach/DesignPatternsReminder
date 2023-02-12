using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsReminder.Creational.BuilderStepwise
{
    public class Meal
    {
        public TypeOfMealEnum mealType { get; set; }
        public int prepTime { get; set; }

        public Meal()
        {

        }
        public override string ToString()
        {
            return $"{nameof(mealType)}: {mealType}, {nameof(prepTime)}: {prepTime}";
        }
    }
}
