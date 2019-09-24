using Crypton.LoseIt.Data.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crypton.LoseIt.Data.Diary
{
    /// <summary>
    /// Defines a meal entry
    /// </summary>
    public class MealEntry : Entry
    {

        /// <summary>
        /// Defines the meal class, such as "Breakfast"
        /// </summary>
        public MealClass MealClass
        {
            get;
            private set;
        }

        public override float CalorieOutput => throw new NotImplementedException();

        /// <summary>
        /// Gets the number of servings consumed for this meal entry
        /// </summary>
        public float NumberOfServings
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the serving size of the meal
        /// </summary>
        public ServingSizeUnits ServingSize
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Calculated total of all nutrient macros based on the meal
        /// </summary>
        public virtual IEnumerable<NutrientCount> Nutrients
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the name of the meal, such as "Egg Loaf"
        /// </summary>
        public string Title
        {
            get;
            private set;
        }

        // serving size
        // servings

        public MealEntry() { }

        /// <summary>
        /// Creates a meal entry from ingredient
        /// </summary>
        /// <param name="fromIngredient"></param>
        public MealEntry(Ingredient fromIngredient)
        {
            // TODO copy name
            // TODO copy nutrients

        }

    }
}
