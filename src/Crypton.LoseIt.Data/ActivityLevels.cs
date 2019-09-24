using System;
using System.Collections.Generic;
using System.Text;

namespace Crypton.LoseIt.Data
{
    public enum ActivityLevels : int
    {

        /// <summary>
        /// Sedentary (spent most of the day sitting, office work)
        /// </summary>
        Sedentary = 0,

        /// <summary>
        /// Spent most of the day sedentary, but light active work
        /// </summary>
        Small = 3,

        /// <summary>
        /// Spent most of the day active
        /// </summary>
        Medium = 5,

        /// <summary>
        /// Spent most of the day in physical activity
        /// </summary>
        Highest = 10

    }
}
