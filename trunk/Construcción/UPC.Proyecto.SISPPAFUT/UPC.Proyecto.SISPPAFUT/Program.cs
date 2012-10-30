﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UPC.Proyecto.SISPPAFUT
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SISPPAFUTlogin login = SISPPAFUTlogin.Instance();
            Application.Run(login);
        }
    }
}
