using System;
using System.Collections.Generic;
using System.Text;

namespace Crypton.LoseIt.Data.Diary
{
    /// <summary>
    /// Defines a diary entry
    /// </summary>
    public abstract class Entry
    {

        /// <summary>
        /// Gets or sets the date and time the entry was created
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the entry type
        /// </summary>
        public EntryTypes Type { get; set; }

        /// <summary>
        /// Defines the calorie output produced by the entry;
        /// positive if it's a meal, negative if it's exercise,
        /// zero if it's water
        /// </summary>
        public abstract float CalorieOutput { get; }

    }
}
