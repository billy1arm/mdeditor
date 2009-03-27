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
    public partial class ProfileEditingCheckBox : CheckBox, IProfileEditing
    {
        private string m_fieldName;
        private DBProfile m_profile;
        private FieldInfo m_field;

        public ProfileEditingCheckBox()
        {

        }

        #region IProfileEditing Members

        public string FieldName
        {
            get
            {
                return m_fieldName;
            }
            set
            {
                m_fieldName = value;
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

        public void Set(DBProfile profile, string fieldName)
        {
            Profile = profile;
            FieldName = fieldName;
            if (profile != null)
                m_field = profile.GetType().GetField(fieldName);
        }

        public void UpdateValue()
        {
            if (m_field != null)
            {
                m_field.SetValue(Profile, Checked);
            }
        }
        #endregion
    }
}
