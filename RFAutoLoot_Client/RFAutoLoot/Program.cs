﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace RFAutoLoot
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AutoLoot());
        }
    }
}
