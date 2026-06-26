using LigaDeClubes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LigaDeClubes.Controls
{
    public partial class UserControlFuncionalidades : UserControl
    {
        private Liga liga;

        public UserControlFuncionalidades(Liga liga)
        {
            InitializeComponent();
            this.liga = liga;
        }
    }
}
