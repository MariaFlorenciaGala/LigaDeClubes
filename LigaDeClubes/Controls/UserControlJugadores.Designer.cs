namespace LigaDeClubes.Controls
{
    partial class UserControlJugadores
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalEquiposCargados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportarJugadores = new System.Windows.Forms.Button();
            this.lblTotalEquipos = new System.Windows.Forms.Label();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.tableLayoutPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupFiltros = new System.Windows.Forms.GroupBox();
            this.filtrarCategoria = new System.Windows.Forms.Button();
            this.filtrarDNI = new System.Windows.Forms.Button();
            this.btnAgregarJugadores = new System.Windows.Forms.Button();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            this.selectCategoria = new System.Windows.Forms.ComboBox();
            this.lblFiltroClub = new System.Windows.Forms.Label();
            this.inputDNI = new System.Windows.Forms.TextBox();
            this.panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.tableLayoutPrincipal.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.groupFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(2, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "con los jugadores a cargar en la ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(4, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "carpeta compartida que envié.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usted puede encontrar el archivo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalEquiposCargados
            // 
            this.lblTotalEquiposCargados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEquiposCargados.AutoSize = true;
            this.lblTotalEquiposCargados.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblTotalEquiposCargados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalEquiposCargados.Location = new System.Drawing.Point(517, 8);
            this.lblTotalEquiposCargados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalEquiposCargados.Name = "lblTotalEquiposCargados";
            this.lblTotalEquiposCargados.Size = new System.Drawing.Size(0, 20);
            this.lblTotalEquiposCargados.TabIndex = 6;
            this.lblTotalEquiposCargados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(432, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "jugadores cargados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnImportarJugadores
            // 
            this.btnImportarJugadores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImportarJugadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImportarJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarJugadores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarJugadores.ForeColor = System.Drawing.Color.White;
            this.btnImportarJugadores.Location = new System.Drawing.Point(300, 12);
            this.btnImportarJugadores.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportarJugadores.Name = "btnImportarJugadores";
            this.btnImportarJugadores.Size = new System.Drawing.Size(126, 39);
            this.btnImportarJugadores.TabIndex = 4;
            this.btnImportarJugadores.Text = "Importar";
            this.btnImportarJugadores.UseVisualStyleBackColor = false;
            // 
            // lblTotalEquipos
            // 
            this.lblTotalEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEquipos.AutoSize = true;
            this.lblTotalEquipos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblTotalEquipos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalEquipos.Location = new System.Drawing.Point(432, 12);
            this.lblTotalEquipos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalEquipos.Name = "lblTotalEquipos";
            this.lblTotalEquipos.Size = new System.Drawing.Size(50, 20);
            this.lblTotalEquipos.TabIndex = 3;
            this.lblTotalEquipos.Text = "Total: ";
            this.lblTotalEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.SystemColors.Control;
            this.panelToolbar.Controls.Add(this.label4);
            this.panelToolbar.Controls.Add(this.label3);
            this.panelToolbar.Controls.Add(this.label2);
            this.panelToolbar.Controls.Add(this.lblTotalEquiposCargados);
            this.panelToolbar.Controls.Add(this.label1);
            this.panelToolbar.Controls.Add(this.btnImportarJugadores);
            this.panelToolbar.Controls.Add(this.lblTotalEquipos);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelToolbar.Location = new System.Drawing.Point(0, 59);
            this.panelToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(595, 66);
            this.panelToolbar.TabIndex = 1;
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AllowUserToAddRows = false;
            this.dgvJugadores.AllowUserToDeleteRows = false;
            this.dgvJugadores.BackgroundColor = System.Drawing.Color.White;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvJugadores.Location = new System.Drawing.Point(2, 214);
            this.dgvJugadores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.ReadOnly = true;
            this.dgvJugadores.RowHeadersVisible = false;
            this.dgvJugadores.RowHeadersWidth = 51;
            this.dgvJugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJugadores.Size = new System.Drawing.Size(591, 207);
            this.dgvJugadores.TabIndex = 1;
            // 
            // tableLayoutPrincipal
            // 
            this.tableLayoutPrincipal.ColumnCount = 1;
            this.tableLayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPrincipal.Controls.Add(this.groupFiltros, 0, 2);
            this.tableLayoutPrincipal.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPrincipal.Controls.Add(this.panelToolbar, 0, 1);
            this.tableLayoutPrincipal.Controls.Add(this.dgvJugadores, 0, 3);
            this.tableLayoutPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPrincipal.Name = "tableLayoutPrincipal";
            this.tableLayoutPrincipal.RowCount = 4;
            this.tableLayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPrincipal.Size = new System.Drawing.Size(595, 423);
            this.tableLayoutPrincipal.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelHeader.BackColor = System.Drawing.Color.DarkRed;
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
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
            this.lblTitulo.Size = new System.Drawing.Size(294, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GESTIÓN DE JUGADORES";
            // 
            // groupFiltros
            // 
            this.groupFiltros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupFiltros.Controls.Add(this.inputDNI);
            this.groupFiltros.Controls.Add(this.filtrarCategoria);
            this.groupFiltros.Controls.Add(this.filtrarDNI);
            this.groupFiltros.Controls.Add(this.btnAgregarJugadores);
            this.groupFiltros.Controls.Add(this.lblFiltroCategoria);
            this.groupFiltros.Controls.Add(this.selectCategoria);
            this.groupFiltros.Controls.Add(this.lblFiltroClub);
            this.groupFiltros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupFiltros.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupFiltros.Location = new System.Drawing.Point(0, 132);
            this.groupFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.groupFiltros.Name = "groupFiltros";
            this.groupFiltros.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.groupFiltros.Size = new System.Drawing.Size(595, 80);
            this.groupFiltros.TabIndex = 2;
            this.groupFiltros.TabStop = false;
            this.groupFiltros.Text = "Filtrar";
            // 
            // filtrarCategoria
            // 
            this.filtrarCategoria.BackColor = System.Drawing.Color.Maroon;
            this.filtrarCategoria.FlatAppearance.BorderSize = 0;
            this.filtrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrarCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarCategoria.ForeColor = System.Drawing.Color.White;
            this.filtrarCategoria.Location = new System.Drawing.Point(377, 44);
            this.filtrarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.filtrarCategoria.Name = "filtrarCategoria";
            this.filtrarCategoria.Size = new System.Drawing.Size(62, 28);
            this.filtrarCategoria.TabIndex = 10;
            this.filtrarCategoria.Text = "Filtrar";
            this.filtrarCategoria.UseVisualStyleBackColor = false;
            // 
            // filtrarDNI
            // 
            this.filtrarDNI.BackColor = System.Drawing.Color.Maroon;
            this.filtrarDNI.FlatAppearance.BorderSize = 0;
            this.filtrarDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrarDNI.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarDNI.ForeColor = System.Drawing.Color.White;
            this.filtrarDNI.Location = new System.Drawing.Point(150, 44);
            this.filtrarDNI.Margin = new System.Windows.Forms.Padding(2);
            this.filtrarDNI.Name = "filtrarDNI";
            this.filtrarDNI.Size = new System.Drawing.Size(62, 28);
            this.filtrarDNI.TabIndex = 9;
            this.filtrarDNI.Text = "Filtrar";
            this.filtrarDNI.UseVisualStyleBackColor = false;
            // 
            // btnAgregarJugadores
            // 
            this.btnAgregarJugadores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarJugadores.BackColor = System.Drawing.Color.Maroon;
            this.btnAgregarJugadores.FlatAppearance.BorderSize = 0;
            this.btnAgregarJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarJugadores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarJugadores.ForeColor = System.Drawing.Color.White;
            this.btnAgregarJugadores.Location = new System.Drawing.Point(486, 21);
            this.btnAgregarJugadores.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarJugadores.Name = "btnAgregarJugadores";
            this.btnAgregarJugadores.Size = new System.Drawing.Size(92, 51);
            this.btnAgregarJugadores.TabIndex = 9;
            this.btnAgregarJugadores.Text = "Agregar Equipo";
            this.btnAgregarJugadores.UseVisualStyleBackColor = false;
            // 
            // lblFiltroCategoria
            // 
            this.lblFiltroCategoria.AutoSize = true;
            this.lblFiltroCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFiltroCategoria.Location = new System.Drawing.Point(230, 21);
            this.lblFiltroCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroCategoria.Name = "lblFiltroCategoria";
            this.lblFiltroCategoria.Size = new System.Drawing.Size(88, 20);
            this.lblFiltroCategoria.TabIndex = 1;
            this.lblFiltroCategoria.Text = "Categoría:";
            // 
            // selectCategoria
            // 
            this.selectCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCategoria.Items.AddRange(new object[] {
            "Todas",
            "Infantiles",
            "Cadetes",
            "Juveniles",
            "Primera",
            "Veteranos"});
            this.selectCategoria.Location = new System.Drawing.Point(234, 45);
            this.selectCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.selectCategoria.Name = "selectCategoria";
            this.selectCategoria.Size = new System.Drawing.Size(139, 27);
            this.selectCategoria.TabIndex = 2;
            // 
            // lblFiltroClub
            // 
            this.lblFiltroClub.AutoSize = true;
            this.lblFiltroClub.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroClub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFiltroClub.Location = new System.Drawing.Point(3, 21);
            this.lblFiltroClub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroClub.Name = "lblFiltroClub";
            this.lblFiltroClub.Size = new System.Drawing.Size(40, 20);
            this.lblFiltroClub.TabIndex = 3;
            this.lblFiltroClub.Text = "DNI:";
            // 
            // inputDNI
            // 
            this.inputDNI.Location = new System.Drawing.Point(7, 44);
            this.inputDNI.Margin = new System.Windows.Forms.Padding(2);
            this.inputDNI.Name = "inputDNI";
            this.inputDNI.Size = new System.Drawing.Size(139, 28);
            this.inputDNI.TabIndex = 11;
            // 
            // UserControlJugadores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlJugadores";
            this.Size = new System.Drawing.Size(595, 423);
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.tableLayoutPrincipal.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupFiltros.ResumeLayout(false);
            this.groupFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalEquiposCargados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImportarJugadores;
        private System.Windows.Forms.Label lblTotalEquipos;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPrincipal;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupFiltros;
        private System.Windows.Forms.Button filtrarCategoria;
        private System.Windows.Forms.Button filtrarDNI;
        private System.Windows.Forms.Button btnAgregarJugadores;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.ComboBox selectCategoria;
        private System.Windows.Forms.Label lblFiltroClub;
        private System.Windows.Forms.TextBox inputDNI;
    }
}
