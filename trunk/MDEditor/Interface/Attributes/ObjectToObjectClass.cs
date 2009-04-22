using System;
using System.Collections.Generic;
using System.Text;

namespace MDEditor.Interface.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class ObjectToObjectClass : Attribute
    {
        private List<ObjectToObject> m_otos;
        private object m_objectTarget;

        public ObjectToObjectClass()
        {
            m_otos = new List<ObjectToObject>();
        }

        public void Add(ObjectToObject otoAttribute)
        {
            m_otos.Add(otoAttribute);
        }

        public void GetValues()
        {
            Type targetType = m_objectTarget.GetType();
            foreach (ObjectToObject oto in m_otos)
            {
                oto.OwnerField.SetValue(oto.Owner, oto.TargetField.GetValue(m_objectTarget, null), null);
            }
        }

        public object ObjectTarget
        {
            set { m_objectTarget = value; }
            get { return m_objectTarget; }
        }

        public void SaveValues()
        {
            Type targetType = m_objectTarget.GetType();
            foreach (ObjectToObject oto in m_otos)
            {
                oto.TargetField.SetValue(m_objectTarget, oto.OwnerField.GetValue(oto.Owner, null), null);
            }
        }
    }
}
