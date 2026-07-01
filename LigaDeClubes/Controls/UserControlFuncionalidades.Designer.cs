namespace LigaDeClubes.Controls
{
    partial class UserControlFuncionalidades
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.selectEquipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectCategoria = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.groupJugadores = new System.Windows.Forms.GroupBox();
            this.dgvJugadoresFuncionalidades = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.groupJugadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadoresFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkRed;
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(595, 57);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(2, 16);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "FUNCIONALIDADES";
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFiltros.Controls.Add(this.selectEquipo);
            this.panelFiltros.Controls.Add(this.label2);
            this.panelFiltros.Controls.Add(this.label1);
            this.panelFiltros.Controls.Add(this.selectCategoria);
            this.panelFiltros.Controls.Add(this.lblFiltro);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(0, 57);
            this.panelFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(595, 133);
            this.panelFiltros.TabIndex = 0;
            // 
            // selectEquipo
            // 
            this.selectEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectEquipo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.selectEquipo.Items.AddRange(new object[] {
            "Todos"});
            this.selectEquipo.Location = new System.Drawing.Point(11, 69);
            this.selectEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.selectEquipo.Name = "selectEquipo";
            this.selectEquipo.Size = new System.Drawing.Size(228, 28);
            this.selectEquipo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar jugadores afiliados:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(291, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por categoria:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectCategoria
            // 
            this.selectCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCategoria.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.selectCategoria.Items.AddRange(new object[] {
            "Todos"});
            this.selectCategoria.Location = new System.Drawing.Point(293, 69);
            this.selectCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.selectCategoria.Name = "selectCategoria";
            this.selectCategoria.Size = new System.Drawing.Size(237, 28);
            this.selectCategoria.TabIndex = 1;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblFiltro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFiltro.Location = new System.Drawing.Point(9, 47);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(136, 20);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Filtrar por equipo:";
            this.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFiltro.Click += new System.EventHandler(this.lblFiltro_Click);
            // 
            // groupJugadores
            // 
            this.groupJugadores.Controls.Add(this.dgvJugadoresFuncionalidades);
            this.groupJugadores.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupJugadores.Location = new System.Drawing.Point(0, 174);
            this.groupJugadores.Margin = new System.Windows.Forms.Padding(2);
            this.groupJugadores.Name = "groupJugadores";
            this.groupJugadores.Padding = new System.Windows.Forms.Padding(2);
            this.groupJugadores.Size = new System.Drawing.Size(593, 247);
            this.groupJugadores.TabIndex = 0;
            this.groupJugadores.TabStop = false;
            this.groupJugadores.Text = "Jugadores afiliados";
            // 
            // dgvJugadoresFuncionalidades
            // 
            this.dgvJugadoresFuncionalidades.AllowUserToAddRows = false;
            this.dgvJugadoresFuncionalidades.AllowUserToDeleteRows = false;
            this.dgvJugadoresFuncionalidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvJugadoresFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadoresFuncionalidades.Location = new System.Drawing.Point(2, 23);
            this.dgvJugadoresFuncionalidades.Margin = new System.Windows.Forms.Padding(2);
            this.dgvJugadoresFuncionalidades.Name = "dgvJugadoresFuncionalidades";
            this.dgvJugadoresFuncionalidades.ReadOnly = true;
            this.dgvJugadoresFuncionalidades.RowHeadersVisible = false;
            this.dgvJugadoresFuncionalidades.RowHeadersWidth = 51;
            this.dgvJugadoresFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJugadoresFuncionalidades.Size = new System.Drawing.Size(581, 220);
            this.dgvJugadoresFuncionalidades.TabIndex = 0;
            // 
            // UserControlFuncionalidades
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupJugadores);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlFuncionalidades";
            this.Size = new System.Drawing.Size(595, 423);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.groupJugadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadoresFuncionalidades)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox selectCategoria;
        private System.Windows.Forms.GroupBox groupJugadores;
        private System.Windows.Forms.DataGridView dgvJugadoresFuncionalidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectEquipo;
        private System.Windows.Forms.Label label2;
    }
}
