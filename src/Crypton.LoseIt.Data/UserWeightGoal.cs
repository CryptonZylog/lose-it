using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Crypton.LoseIt.Data
{

    /// <summary>
    /// Defines possible changes in weight
    /// </summary>
    public enum WeightChangeDirections
    {
        /// <summary>
        /// Weight loss
        /// </summary>
        Loss,
        /// <summary>
        /// Weight gain
        /// </summary>
        Gain,
        /// <summary>
        /// Maintain weight
        /// </summary>
        Maintain
    }

    /// <summary>
    /// Defines a weight change (loss/maintain/gain) goal
    /// </summary>
    public class UserWeightGoal
    {

        /// <summary>
        /// User's desired effect on weight
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public WeightChangeDirections TargetChange
        {
            get;
            set;
        } = WeightChangeDirections.Maintain;

        /// <summary>
        /// Target weight (in kg), can be set to current weight if TargetChange=Maintain
        /// </summary>
        public float TargetWeight
        {
            get;
            set;
        } = 0f;

        /// <summary>
        /// Defines a positive, negative, or zero (depending on TargetChange) change in
        /// user's weight per week in kg
        /// </summary>
        public float WeeklyTarget
        {
            get;
            set;
        } = 0f;

    }
}
