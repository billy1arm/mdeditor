using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Windows;

namespace MDEditor.Interface.Attributes
{
    public delegate bool RequiredFieldCheck(PropertyInfo field);

    [AttributeUsage(AttributeTargets.Field)]
    internal class RequiredField : Attribute
    {
        private string m_targetPropertyText;
        private string m_errorText;
        private RequiredFieldCheck m_requiredDelegate;
        private PropertyInfo m_targetField;
        private object m_target;
        private int m_requiredGroup;

        public RequiredField(string targetProperty, string errorText)
        {
            m_targetPropertyText = targetProperty;
            m_errorText = errorText;
            m_requiredDelegate = null;
            m_requiredGroup = -1;
        }

        public RequiredField(string targetProperty, string errorText, RequiredFieldCheck check)
        {
            m_targetPropertyText = targetProperty;
            m_errorText = errorText;
            m_requiredDelegate = check;
            m_requiredGroup = -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetProperty"></param>
        /// <param name="errorText"></param>
        /// <param name="fieldGroup">Signifies that if one of these fields are filled in, they are all required</param>
        public RequiredField(string targetProperty, string errorText, int fieldGroup)
        {
            m_targetPropertyText = targetProperty;
            m_errorText = errorText;
            m_requiredGroup = fieldGroup;
        }

        public PropertyInfo TargetField
        {
            get { return m_targetField; }
        }

        public object Target
        {
            get { return m_target; }
            set 
            { 
                m_target = value;
                Type targettype = m_target.GetType();
                m_targetField = targettype.GetProperty(m_targetPropertyText);
            }
        }

        public int RequirementGroup
        {
            get { return m_requiredGroup; }
        }

        public bool MeetsRequirement
        {
            get
            {
                if (m_requiredDelegate != null)
                {
                    return m_requiredDelegate.Invoke(m_targetField);
                }
                else
                {
                    object target = m_targetField.GetValue(m_target, null);

                    if (target == null)
                        return false;

                    if (target is string)
                    {
                        if ((target as string).Length > 0)
                            return true;
                    }

                    return false;
                }
            }
        }
    }
}
