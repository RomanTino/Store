// -----------------------------------------------------------------------
// <copyright file="User.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Socket
{
    using System;
    using System.Collections.Generic;
    using Socket.Control;
    using System.Linq;
    using System.Windows.Forms;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Controler control = new Controler();
            Application.Run(control.GetHomeWindow());
        }
    }
}