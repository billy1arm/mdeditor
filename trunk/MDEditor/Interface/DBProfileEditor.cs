using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using MDEditor.Database;
using MDEditor.Interface.Attributes;

namespace MDEditor.Interface
{
    public partial class DBProfileEditor : Form
    {
        private static Dictionary<string, ProfileEditingAttribute> m_fields = new Dictionary<string, ProfileEditingAttribute>();

        public static void StaticInitialize()
        {
            Type type = typeof(DBProfileEditor);
            Type targetType = typeof(DBProfile);

            foreach (FieldInfo field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                ProfileEditingAttribute[] attributes = (ProfileEditingAttribute[])field.GetCustomAttributes(typeof(ProfileEditingAttribute), false);
                if (attributes.Length > 0)
                {
                    attributes[0].Field = targetType.GetField(attributes[0].TargetField);

                    if (attributes[0].Field != null)
                        m_fields.Add(field.Name, attributes[0]);
                }
            }
        }

        private DBProfile m_profile;

        public DBProfileEditor()
        {
            m_profile = new DBProfile();
            InitializeComponent();
            Initialize();
        }

        public DBProfileEditor(DBProfile profile)
        {
            m_profile = profile;
            InitializeComponent();
            Initialize();
        }

        private void Save()
        {
            foreach (IProfileEditing profile in Controls)
            {
                profile.UpdateValue();
            }

            if (!m_profile.Saved)
            {
                DBProfileHandler.Add(m_profile);
            }
        }

        private void Initialize()
        {
            foreach (IProfileEditing profile in Controls)
            {
                ProfileEditingAttribute attribute;
                if (m_fields.TryGetValue(profile.ToString(), out attribute))
                    profile.Set(m_profile, attribute.Field);

            }
        }
    }
}
