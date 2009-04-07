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
        private static Dictionary<string, ObjectToFieldAttribute> m_fields = new Dictionary<string, ObjectToFieldAttribute>();

        public static void StaticInitialize()
        {
            Type type = typeof(DBProfileEditor);
            Type targetType = typeof(DBProfile);

            foreach (FieldInfo field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                ObjectToFieldAttribute[] attributes = (ObjectToFieldAttribute[])field.GetCustomAttributes(typeof(ObjectToFieldAttribute), false);
                if (attributes.Length > 0)
                {
                    attributes[0].Field = targetType.GetProperty(attributes[0].TargetField);

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
            Scan(this.Controls);
        }
    }
}
