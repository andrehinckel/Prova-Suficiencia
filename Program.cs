﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_Suficiencia
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// /// <summary>
        /// ANDRÉ MARCOS HINCKEL
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrincipalForm());
        }
    }
}