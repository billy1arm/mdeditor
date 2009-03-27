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
                    s_profiles.Add(profile.Handle, profile);
                }
            }
        }
        
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
            Remove(profile.Handle);
        }

        internal static void Remove(string handle)
        {
            s_profiles.Remove(handle);

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

        internal static void Load()
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
