using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MDEditor.Interface;
using MDEditor.Interface.Attributes;
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
        private static LogInterface m_logInterface;

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
            m_logInterface = new LogInterface();
            m_logInterface.MdiParent = m_parentInterface;
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
                foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Static))
                {
                    load = (Load[])method.GetCustomAttributes(typeof(Load), false);
                    

                    foreach (Load loadItem in load)
                    {
                        if (loadItem.VisibleName == "")
                            loadItem.VisibleName = method.Name;

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
                            Log("Loading dynamic content: {0}\n", load.VisibleName);
                            Activator.CreateInstance(load.Type, load.Parameters);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show("An error has occured, the program must now close.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Application.Exit();
                        }
                    }
                    else
                    {
                        Log("Executing static method: {0}\n", load.VisibleName);
                        load.Initialize.Invoke(null, null);
                    }
                }
            }
        }

        internal static LogInterface LogInterface
        {
            get { return m_logInterface; }
        }

        [Load("Interface Setup", Priority.Fifth)]
        public static void ShowForm()
        {
            m_logInterface.WindowState = FormWindowState.Maximized;
            m_logInterface.Show();
            Application.Run(m_parentInterface);
        }

        #region Log Redirect
        public static void Log(string text, bool addTimeStamp, params object[] param)
        {
            Log(String.Format(text, param), addTimeStamp);
        }

        public static void Log(string text, params object[] param)
        {
            Log(String.Format(text, param), true);
        }

        public static void Log(string text)
        {
            Log(text, true);
        }

        public static void Log(string text, bool addTimeStamp)
        {
            m_logInterface.Log(text, addTimeStamp);
        }
        #endregion
    }
}
