using System;
using System.Collections.Generic;
using System.Text;

namespace MDEditor.Interface.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class RequirementClass : Attribute
    {
        private List<RequiredField> m_requirements;

        public RequirementClass()
        {
            m_requirements = new List<RequiredField>();
        }

        public void Add(RequiredField requirement)
        {
            m_requirements.Add(requirement);
        }

        public bool MeetsRequirement
        {
            get
            {
                foreach (RequiredField requirement in m_requirements)
                {
                    if (!requirement.MeetsRequirement)
                        return false;
                }

                return true;
            }
        }
    }
}
