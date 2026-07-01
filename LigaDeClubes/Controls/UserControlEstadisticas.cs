using System;
using System.Windows.Forms;
using LigaDeClubes.Services;

namespace LigaDeClubes.Controls
{
    public partial class UserControlEstadisticas : UserControl
    {
        private Liga liga;

        public UserControlEstadisticas(Liga liga)
        {
            InitializeComponent();
            this.liga = liga;

            cboPartidos.SelectedIndexChanged += CboPartidos_SelectedIndexChanged;
        }

        private void CboPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPartido_Click(object sender, EventArgs e)
        {

        }
    }
}
