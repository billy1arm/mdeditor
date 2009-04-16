using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace MDEditor.Interface.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class ObjectToObjectAttribute : Attribute
    {
        private string m_targetField;
        private PropertyInfo m_field;
        private PropertyInfo m_ownerField;
        private string m_ownerFieldText;
        private Type m_target;
        private Control m_owner;

        public ObjectToObjectAttribute(Type target, string targetField, string ownerField)
        {
            m_target = target;
            m_ownerFieldText = ownerField;
            m_targetField = targetField;
            m_field = m_target.GetProperty(targetField);
        }

        public Control Owner
        {
            get { return m_owner; }
            set 
            { 
                m_owner = value;
                m_ownerField = m_owner.GetType().GetProperty(m_ownerFieldText);
            }
        }

        public string TargetField
        {
            get { return m_targetField; }
        }

        public PropertyInfo Field
        {
            get { return m_field; }
            set { m_field = value; }
        }
    }
}
