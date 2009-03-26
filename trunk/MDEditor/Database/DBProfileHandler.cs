using System;
using System.Collections.Generic;
using System.Text;

namespace MDEditor.Database
{
    /// <summary>
    /// This is a static class which handles all database profiles
    /// </summary>
    internal class DBProfileHandler
    {
        /// <summary>
        /// When all profiles are removed this event is invoked
        /// </summary>
        internal static event Action NoProfiles;

        /// <summary>
        /// When a profile is created when there was none previously this event is invoked
        /// </summary>
        internal static event Action ProfilesAvaliable;

        private static Dictionary<string, DBProfile> s_profiles = new Dictionary<string, DBProfile>();

        internal static bool Add(DBProfile profile)
        {
            if (!s_profiles.ContainsKey(profile.Handle))
            {
                s_profiles.Add(profile.Handle, profile);

                if (s_profiles.Count == 1 && ProfilesAvaliable != null)
                    ProfilesAvaliable.Invoke();

                return true;
            }

            return false;
        }

        internal static void Remove(DBProfile profile)
        {

        }

        internal static void Remove(string handle)
        {
            s_profiles.Remove(handle);

            if (s_profiles.Count == 0 && NoProfiles != null)
                NoProfiles.Invoke();
        }
    }
}
