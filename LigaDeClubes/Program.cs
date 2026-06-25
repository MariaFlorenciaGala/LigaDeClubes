using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LigaDeClubes.Models;
using LigaDeClubes.Services;

namespace LigaDeClubes
{

    internal static class Program
    {
        public static Liga Liga { get; private set; }
        [STAThread]
        static void Main()
        {
            Liga liga = new Liga();
            Liga = new Liga();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPortada());
        }
    }
}

