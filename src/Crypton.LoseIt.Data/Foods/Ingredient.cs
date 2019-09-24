using System;
using System.Collections.Generic;
using System.Text;

namespace Crypton.LoseIt.Data.Foods
{
    /// <summary>
    /// Defines a recipe ingredient
    /// </summary>
    public class Ingredient
    {

        /// <summary>
        /// Gets the ingredient name
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the number of servings of this ingredient (typically 1)
        /// </summary>
        public float NumberOfServings
        {
            get;
            private set;
        }

        /// <summary>
        /// Serving size in the measuring unit specified by ServingSizeUnit
        /// </summary>
        public float ServingSize
        {
            get;
            private set;
        }

        public ServingSizeUnits ServingSizeUnit
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the nutrients composing this ingredient
        /// such as calories, fats, etc.
        /// </summary>
        public IEnumerable<NutrientCount> Nutrients
        {
            get;
            private set;
        }

        /**
         * TODO: additional metadata like barcode, etc.
         */


        /// <summary>
        /// Sets the serving size parameters of this ingredient
        /// </summary>
        /// <param name="numberOfServings"></param>
        /// <param name="unit"></param>
        public void SetServingSize(float numberOfServings, ServingSizeUnits unit)
        {
            // TODO validation
            NumberOfServings = numberOfServings;
            ServingSizeUnit = unit;
        }

        /// <summary>
        /// Sets nutrition information
        /// </summary>
        /// <param name="macro">Macro to set, such as Total fat, or calories</param>
        /// <param name="unit">Measurement unit</param>
        /// <param name="amount">Amount of macros (such as calorie count)</param>
        public void SetNutrient(NutritionMacros macro, NutrientUnits unit, float amount)
        {
            // TODO overwrite `Nutrients` property keyed by macro type
            // TODO validate units, throw exception if using Grams for Calories (for example)
            // TODO validate range
        }

    }
}
