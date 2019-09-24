using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Crypton.LoseIt.Data
{
    /// <summary>
    /// Defines user's daily nutrition goals
    /// </summary>
    public class NutritionGoal
    {

        /// <summary>
        /// Which days of week this goal applies to
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public List<DayOfWeek> DaysOfWeek
        {
            get;
            set;
        } = new List<DayOfWeek>();

        public float MaxCalories
        {
            get;
            set;
        }

        public float MinCalories
        {
            get;
            set;
        }

        public float MaxCarbohydrates
        {
            get;
            set;
        }

        public float MinCarbohydrates
        {
            get;
            set;
        }

        public float MaxProtein
        {
            get;
            set;
        }

        public float MinProtein
        {
            get;
            set;
        }

        public float MaxFat
        {
            get;
            set;
        }

        public float MinFat
        {
            get;
            set;
        }

        public NutritionGoal()
        {
            // unless otherwise specified, this "default" goal applies to all days of the week
            DaysOfWeek = new List<DayOfWeek> { 
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday,
                DayOfWeek.Saturday,
                DayOfWeek.Sunday
            };
        }

    }
}
