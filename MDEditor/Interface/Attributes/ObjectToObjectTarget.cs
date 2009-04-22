using System;
using System.Collections.Generic;
using System.Text;

namespace MDEditor.Interface.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ObjectToObjectTarget : Attribute
    {
    }
}
