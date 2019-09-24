using System;
using System.Collections.Generic;
using System.Text;

namespace Crypton.LoseIt.Data
{
    /// <summary>
    /// Defines a calorie goal for each meal
    /// </summary>
    public class CalorieGoalByMeal
    {

        public DayOfWeek DayOfWeek { get; set; }

        public MealClass Meal { get; set; }

        public float Percentage { get; set; }

    }
}
