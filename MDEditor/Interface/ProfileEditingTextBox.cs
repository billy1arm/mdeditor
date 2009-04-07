using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using MDEditor.Database;

namespace MDEditor.Interface
{
    public partial class ProfileEditingTextBox : TextBox, IProfileEditing
    {
        private string m_fieldName;
        private DBProfile m_profile;
        private PropertyInfo m_field;

        public ProfileEditingTextBox()
        {

        }

        

        #region IProfileEditing Members

        public PropertyInfo Field
        {
            get
            {
                return m_field;
            }
            set
            {
                m_field = value;
            }
        }

        public DBProfile Profile
        {
            get
            {
                return m_profile;
            }
            set
            {
                m_profile = value;
            }
        }

        public void Set(DBProfile profile, PropertyInfo field)
        {
            Profile = profile;
            Field = field;
            Text = (String)field.GetValue(profile, null);
        }

        public void UpdateValue()
        {
            if (m_field != null)
            {
                m_field.SetValue(Profile, Text, null);
            }
        }

        #endregion

    }
}
