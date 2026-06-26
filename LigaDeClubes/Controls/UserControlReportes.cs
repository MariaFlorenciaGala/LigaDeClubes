using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LigaDeClubes.Services;


namespace LigaDeClubes.Controls
{
    public partial class UserControlReportes : UserControl
    {
        private Liga liga;
        public UserControlReportes(Liga liga)
        {
            InitializeComponent();
            this.liga = liga;
        }
    }
}
