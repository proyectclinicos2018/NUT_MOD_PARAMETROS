﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Modificar_Parametros
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
            Application.Run(new Frm_Modificar_Parametros());
        }
    }
}
