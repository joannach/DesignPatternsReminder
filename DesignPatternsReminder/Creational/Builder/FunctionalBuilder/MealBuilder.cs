using DesignPatternsReminder.Creational.BuilderStepwise;
using System;
using System.Collections.Generic;

namespace DesignPatternsReminder.Creational.Builder.FunctionalBuilder
{
    public class MealBuilder
    {
        public List<Action<Meal>> mealActions = new List<Action<Meal>>();
        public Meal Build()
        {
            var meal = new Meal();
            mealActions.ForEach(a => a(meal));

            return meal;
        }
        public MealBuilder ClassifyByType(string type)
        {
            mealActions.Add(a => a.mealType = (TypeOfMealEnum)Enum.Parse(typeof(TypeOfMealEnum), type));
            return this;
        }
    }
}
