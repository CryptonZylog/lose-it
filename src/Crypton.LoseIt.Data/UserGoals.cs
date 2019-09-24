using System;
using System.Collections.Generic;
using System.Text;

namespace Crypton.LoseIt.Data
{
    /// <summary>
    /// Defines user goal preferences
    /// </summary>
    public class UserGoals
    {

        /// <summary>
        /// Defines what the user wants to do to their weight
        /// </summary>
        public UserWeightGoal WeightGoal
        {
            get;
            set;
        } = new UserWeightGoal();

        /// <summary>
        /// Defines user's daily nutrition goals that are unique to each day of the week
        /// </summary>
        public List<NutritionGoal> NutritionGoals
        {
            get;
            set;
        } = new List<NutritionGoal>();

        /// <summary>
        /// Defines user's calorie goals by meal types
        /// </summary>
        public List<CalorieGoalByMeal> CalorieGoals
        {
            get;
            set;
        } = new List<CalorieGoalByMeal>();


    }
}
