using System;
using System.Collections.Generic;
using System.Text;

namespace Crypton.LoseIt.Data.Foods
{
    public class NutrientCount
    {

        public NutritionMacros Macro
        {
            get;
            private set;
        }

        public NutrientUnits AmountUnit
        {
            get;
            private set;
        }

        /// <summary>
        /// Amount of the nutrient
        /// </summary>
        public float Amount
        {
            get;
            private set;
        }

    }
}
