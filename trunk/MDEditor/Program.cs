﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MDEditor.Interface;

namespace MDEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Manager.Start();
        }
    }
}
