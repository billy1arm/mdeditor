using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using MDEditor.Interface;

namespace MDEditor
{
    public delegate void Action();
    public delegate bool BoolAction();
    public delegate object Conversion(object obj);

    public enum Priority
    {
        First = 0,
        Second,
        Third,
        Fourth,
        Fifth,
        Last
    }

    /// <summary>
    /// Used to automaticly load a class or static class
    /// Note: This will only create instances or run objects at a specific run time
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class Load : Attribute
    {
        public string VisibleName = "";
        public Priority Priority;
        public object[] Parameters;

        /// <summary>
        /// Used for class loading
        /// </summary>
        public Type Type;
        /// <summary>
        /// Used for Initializing a static class
        /// </summary>
        public MethodInfo Initialize;

        public Load(string visibleName)
        {
            VisibleName = visibleName;
            Priority = Priority.Last;
        }

        public Load(string visibleName, params object[] parameters)
        {
            VisibleName = visibleName;
            Priority = Priority.Last;
        }

        public Load(params object[] parameters)
        {
            Priority = Priority.Last;
            Parameters = parameters;
        }

        public Load(Priority priority)
        {
            Priority = priority;
        }

        public Load(Priority priority, params object[] parameters)
        {
            Priority = Priority.Last;
            Parameters = parameters;
        }

        public Load(string visibleName, Priority priority)
        {
            VisibleName = visibleName;
            Priority = priority;
        }

        public Load(string visibleName, Priority priority, params object[] parameters)
        {
            VisibleName = visibleName;
            Priority = priority;
            Parameters = parameters;
        }

        public bool IsClass
        {
            get
            {
                return Initialize == null;
            }
        }
    }
}
