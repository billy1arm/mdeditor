using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using MDEditor.Database;

namespace MDEditor.Interface
{
    internal interface IProfileEditing
    {
        FieldInfo Field
        {
            get;
            set;
        }

        DBProfile Profile
        {
            get;
            set;
        }

        void UpdateValue();
        void Set(DBProfile profile, FieldInfo field);
    }
}
