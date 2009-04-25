using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

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

        /// <summary>
        /// When a profile is added
        /// </summary>
        internal static event Action<DBProfile> Added;

        /// <summary>
        /// When a profile is removed
        /// </summary>
        internal static event Action<DBProfile> Removed;

        private static Dictionary<string, DBProfile> s_profiles = new Dictionary<string, DBProfile>();


        /// <summary>
        /// To be use only to save and load profiles
        /// </summary>
        [XmlArray("Profiles")]
        internal static DBProfile[] Profiles
        {
            get
            {
                DBProfile[] profiles = new DBProfile[s_profiles.Values.Count];
                s_profiles.Values.CopyTo(profiles, 0);
                return profiles;
            }

            set
            {
                foreach (DBProfile profile in value)
                {
                    Add(profile);
                }
            }
        }

        internal static int Count
        {
            get { return s_profiles.Count; }
        }
        
        internal static bool Add(DBProfile profile)
        {
            if (!s_profiles.ContainsKey(profile.Handle))
            {
                profile.Saved = true;
                s_profiles.Add(profile.Handle, profile);

                if (Added != null)
                    Added.Invoke(profile);

                if (s_profiles.Count == 1 && ProfilesAvaliable != null)
                    ProfilesAvaliable.Invoke();

                return true;
            }

            return false;
        }

        internal static void Remove(DBProfile profile)
        {
            profile.Saved = false;
            s_profiles.Remove(profile.Handle);

            if (Removed != null)
                Removed.Invoke(profile);

            if (s_profiles.Count == 0 && NoProfiles != null)
                NoProfiles.Invoke();
        }

        internal static void Save()
        {
            XmlSerializer writer = new XmlSerializer(typeof(DBProfile[]));
            TextWriter stream = new StreamWriter("profiles.db");

            writer.Serialize(stream, Profiles);

            stream.Close();
        }

        public static void Load()
        {
            if (File.Exists("profiles.db"))
            {
                XmlSerializer reader = new XmlSerializer(typeof(DBProfile[]));
                TextReader stream = new StreamReader("profiles.db");

                Profiles = (DBProfile[])reader.Deserialize(stream);

                stream.Close();
            }
        }
    }
}
