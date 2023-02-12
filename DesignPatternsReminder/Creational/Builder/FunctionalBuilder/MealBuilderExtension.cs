using DesignPatternsReminder.Creational.BuilderStepwise;
using System;

namespace DesignPatternsReminder.Creational.Builder.FunctionalBuilder
{
    public static class MealBuilderExtension
    {
        public static MealBuilder PreparesIn(this MealBuilder builder, int prepTime)
        {
            builder.mealActions.Add(a => a.prepTime = prepTime);
            return builder;
        }
    }
}
