using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace MDEditor.Interface.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class ProfileEditingAttribute : Attribute
    {
        private string m_targetField;
        private FieldInfo m_field;

        public ProfileEditingAttribute(string targetField)
        {
            m_targetField = targetField;
        }

        public string TargetField
        {
            get { return m_targetField; }
        }

        public FieldInfo Field
        {
            get { return m_field; }
            set { m_field = value; }
        }
    }
}
