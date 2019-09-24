using System;
using System.Collections.Generic;
using System.Text;

namespace Crypton.LoseIt.Data
{
    /// <summary>
    /// Defines the user and all their profile data
    /// </summary>
    public class User
    {

        /// <summary>
        /// Defines user's profile
        /// </summary>
        public UserProfile Profile { get; set; }

        /// <summary>
        /// Defines user's goals
        /// </summary>
        public UserGoals Goals { get; set; }

    }
}
