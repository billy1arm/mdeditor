using System;
using System.Collections.Generic;
using System.Text;

namespace MDEditor.Interface.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class RequirementClass : Attribute
    {
        private List<RequiredField> m_requirements;
        private Dictionary<int, List<RequiredField>> m_requiredGroups;

        public RequirementClass()
        {
            m_requirements = new List<RequiredField>();
            m_requiredGroups = new Dictionary<int, List<RequiredField>>();
        }

        public void Add(RequiredField requirement)
        {
            if (requirement.RequirementGroup >= 0)
            {
                if (!m_requiredGroups.ContainsKey(requirement.RequirementGroup))
                    m_requiredGroups.Add(requirement.RequirementGroup, new List<RequiredField>());

                m_requiredGroups[requirement.RequirementGroup].Add(requirement);
            }
            else
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

                int[] groups = new int[m_requiredGroups.Keys.Count];

                m_requiredGroups.Keys.CopyTo(groups, 0);

                foreach (int i in groups)
                {
                    bool foundEmpty = false;
                    bool foundValue = false;
                    foreach (RequiredField field in m_requiredGroups[i])
                    {
                        if (!field.MeetsRequirement)
                            foundEmpty = true;
                        else
                            foundValue = true;

                        if (foundEmpty && foundValue)
                            return false;
                    }
                }

                return true;
            }
        }
    }
}
