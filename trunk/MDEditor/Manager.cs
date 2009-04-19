using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MDEditor.Interface;
using System.Reflection;
using System.Windows.Forms;

namespace MDEditor
{
    /// <summary>
    /// Entry point into the program, it is god
    /// </summary>
    public class Manager
    {
        private static ParentInterface m_parentInterface;

        public static void Start()
        {
            SortedDictionary<int, List<Load>> Queue = new SortedDictionary<int, List<Load>>();

            foreach (int i in Enum.GetValues(typeof(Priority)))
            {
                List<Load> list = new List<Load>();
                Queue.Add(i, list);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            m_parentInterface = new ParentInterface();
            Assembly ourAssembly = Assembly.GetExecutingAssembly();

            //This is where we will search for and queue all loading attributes
            foreach (Type type in ourAssembly.GetTypes())
            {
                //First of all, search the class for a load method if possible
                Load[] load = (Load[])type.GetCustomAttributes(typeof(Load), false);

                if (load.Length > 0)
                {
                    if (load[0].VisibleName == "")
                        load[0].VisibleName = type.Name;

                    load[0].Type = type;
                    Queue[(int)load[0].Priority].Add(load[0]);
                }

                //Now search for any initialize static methods
                foreach (MethodInfo method in type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
                {
                    load = (Load[])type.GetCustomAttributes(typeof(Load), false);

                    foreach (Load loadItem in load)
                    {
                        if (loadItem.VisibleName == "")
                            loadItem.VisibleName = type.Name;

                        loadItem.Type = type;
                        loadItem.Initialize = method;
                        Queue[(int)loadItem.Priority].Add(loadItem);
                    }
                }
            }

            //This is where we enumerate the load queue and start activating things in order
            foreach (List<Load> list in Queue.Values)
            {
                foreach (Load load in list)
                {
                    if (load.IsClass)
                    {
                        try
                        {
                            Activator.CreateInstance(load.Type);
                        }
                        catch
                        {
                            MessageBox.Show("An error has occured, the program must now close.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Application.Exit();
                        }
                    }
                    else
                    {
                        try
                        {
                            load.Initialize.Invoke(null, null);
                        }
                        catch
                        {
                            MessageBox.Show("An error has occured, the program must now close.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Application.Exit();
                        }
                    }
                }
            }
        }

        [Load("Form Shown", Priority.Fifth)]
        public static void ShowForm()
        {
            Application.Run(m_parentInterface);
        }
    }
}
