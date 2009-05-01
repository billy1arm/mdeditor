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

        private bool m_basicConversions;
        private Conversion m_convertTo;
        private Conversion m_convertFrom;

        /// <summary>
        /// Transfers the values of the <see cref="targetField"/> and <see cref="ownerField"/> between eachother
        /// </summary>
        /// <param name="target">Target refers to the storage file</param>
        /// <param name="targetField">Refers to Storage.*Name*</param>
        /// <param name="ownerField">Refers to TextBox.*Text*</param>
        public ObjectToObject(Type target, string targetField, string ownerField)
        {
            m_target = target;
            m_ownerFieldText = ownerField;
            m_targetFieldText = targetField;
            m_targetField = m_target.GetProperty(targetField);
            m_basicConversions = false;
        }

        /// <summary>
        /// Transfers the values of the <see cref="targetField"/> and <see cref="ownerField"/> between eachother.
        /// </summary>
        /// <param name="target">Target refers to the storage file</param>
        /// <param name="targetField">Refers to TextBox.*Text*</param>
        /// <param name="ownerField">Refers to Storage.*Name*</param>
        /// <param name="handleDefaultConversions">Enabling this will convert basic types if required.</param>
        public ObjectToObject(Type target, string targetField, string ownerField, bool handleDefaultConversions)
        {
            m_target = target;
            m_ownerFieldText = ownerField;
            m_targetFieldText = targetField;
            m_targetField = m_target.GetProperty(targetField);
            m_basicConversions = handleDefaultConversions;
            m_convertFrom = InternalConvertFrom;
            m_convertTo = InternalConvertTo;
        }

        /// <summary>
        /// Transfers the values of the <see cref="targetField"/> and <see cref="ownerField"/> between eachother. Also allows for conversion of the two different types.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="targetField"></param>
        /// <param name="ownerField"></param>
        /// <param name="convertTo"></param>
        /// <param name="convertFrom"></param>
        public ObjectToObject(Type target, string targetField, string ownerField, Conversion convertTo, Conversion convertFrom)
        {
            m_target = target;
            m_ownerFieldText = ownerField;
            m_targetFieldText = targetField;
            m_targetField = m_target.GetProperty(targetField);
            m_convertFrom = convertFrom;
            m_convertTo = convertTo;
            m_basicConversions = false;
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

        public bool RequiresConversion
        {
            get
            {
                return m_convertTo != null || m_basicConversions;
            }
        }

        public Conversion ConvertTo
        {
            get { return m_convertTo; }
        }

        public Conversion ConvertFrom
        {
            get { return m_convertFrom; }
        }

        public PropertyInfo OwnerField
        {
            get { return m_ownerField; }
            set { m_ownerField = value; }
        }

        private object InternalConvertTo(object obj)
        {
            return Convert.ChangeType(obj, m_targetField.PropertyType);
        }

        private object InternalConvertFrom(object obj)
        {
            return Convert.ChangeType(obj, m_ownerField.PropertyType);
        }
    }
}
