using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using MDEditor.Interface.Attributes;

namespace MDEditor.Interface
{
    internal class ObjectToObjectMgr
    {
        private static Dictionary<object, ObjectToObjectClass> s_classes = new Dictionary<object, ObjectToObjectClass>();
        public static void Add(ObjectToObjectClass oClass)
        {

        }

        public static ObjectToObjectClass Scan(object target)
        {
            Type targetType = target.GetType();
            ObjectToObjectClass[] otoClasses = (ObjectToObjectClass[])targetType.GetCustomAttributes(typeof(ObjectToObjectClass), false);
            Manager.Log("OTO Scanning requested ({0}): ", targetType.Name);
            ObjectToObjectClass otoClass = null;

            if (otoClasses.Length > 0)
            {
                Manager.Log("Started!\n", false);
                otoClass = otoClasses[0];

                foreach (FieldInfo field in targetType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    ObjectToObjectTarget[] otoTargets = (ObjectToObjectTarget[])field.GetCustomAttributes(typeof(ObjectToObjectTarget), false);

                    if (otoTargets.Length > 0)
                    {
                        Manager.Log("Found target: {0}\n", field.Name);
                        otoClass.ObjectTarget = field.GetValue(target);
                    }
                }

                foreach (FieldInfo field in targetType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    ObjectToObject[] otos = (ObjectToObject[])field.GetCustomAttributes(typeof(ObjectToObject), false);

                    foreach (ObjectToObject oto in otos)
                    {
                        Manager.Log("Found field {0}\n", field.Name);
                        oto.Owner = (Control)field.GetValue(target);
                        otoClass.Add(oto);
                    }
                }

                if (otoClass.ObjectTarget != null)
                {
                    Add(otoClass);
                    Manager.Log("OTO Successfull scan\n");
                    return otoClass;
                }
                else
                {
                    Manager.Log("OTO Unsuccessful scan\n");
                }
            }
            else
                Manager.Log("Failed, not OTO class.\n", false);

            return null;
        }

        [Load("Object to Object Manager", Priority.First)]
        public static void Initialize()
        {
        }
    }
}
