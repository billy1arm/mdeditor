using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace MDEditor.Interface.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class ObjectToObject : Attribute
    {
        private string m_targetFieldText;
        private PropertyInfo m_targetField;
        private PropertyInfo m_ownerField;
        private string m_ownerFieldText;
        /// <summary>
        /// Ex. DBProfile
        /// </summary>
        private Type m_target;
        /// <summary>
        /// Ex. The text box
        /// </summary>
        private Control m_owner;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target">Target refers to the storage file</param>
        /// <param name="targetField">Refers to TextBox.*Text*</param>
        /// <param name="ownerField">Refers to Storage.*Name*</param>
        public ObjectToObject(Type target, string targetField, string ownerField)
        {
            m_target = target;
            m_ownerFieldText = ownerField;
            m_targetFieldText = targetField;
            m_targetField = m_target.GetProperty(targetField);
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

        public string TargetFieldText
        {
            get { return m_targetFieldText; }
        }

        public PropertyInfo TargetField
        {
            get { return m_targetField; }
            set { m_targetField = value; }
        }

        public PropertyInfo OwnerField
        {
            get { return m_ownerField; }
            set { m_ownerField = value; }
        }
    }
}
