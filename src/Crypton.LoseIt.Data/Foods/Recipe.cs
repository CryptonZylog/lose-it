using System;
using System.Collections.Generic;
using System.Text;

namespace Crypton.LoseIt.Data.Foods
{
    /// <summary>
    /// Defines a recipe which includes pieces of food and
    /// can be used to make a meal
    /// </summary>
    public class Recipe
    {

        /// <summary>
        /// Gets the recipe name or title
        /// </summary>
        public string Title
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the number of servings this recipe produces
        /// </summary>
        public float NumberOfServings
        {
            get;
            private set;
        }

        public IEnumerable<Ingredient> Ingredients
        {
            get;
            private set;
        }

        public float CaloriesPerServing
        {
            get
            {
                // TODO
                throw new NotImplementedException();
            }
        }

        public void AddIngredient(Ingredient ingredient)
        {
            // TODO
        }

    }
}
