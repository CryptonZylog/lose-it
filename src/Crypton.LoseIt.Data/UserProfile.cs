using System;
using System.Collections.Generic;
using System.Text;

namespace Crypton.LoseIt.Data
{
    /// <summary>
    /// Defines biologic genders
    /// </summary>
    public enum Genders
    {
        Male,
        Female
    }


    /// <summary>
    /// Defines user profile fields
    /// </summary>
    public class UserProfile
    {

        public string Email
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public DateTime Birthdate
        {
            get;
            set;
        }

        public Genders Gender
        {
            get;
            set;
        }

        /// <summary>
        /// Defines user's height in centimeters
        /// </summary>
        public float Height
        {
            get;
            set;
        }
        

    }
}
