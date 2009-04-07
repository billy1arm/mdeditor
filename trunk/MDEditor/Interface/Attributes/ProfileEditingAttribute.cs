using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace MDEditor.Interface.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class ObjectToFieldAttribute : Attribute
    {
        private string m_targetField;
        private PropertyInfo m_field;
        private Type m_target;

        public ObjectToFieldAttribute(Type target, string targetField)
        {
            m_target = target;
            m_targetField = targetField;
            m_field = m_target.GetProperty(targetField);
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
