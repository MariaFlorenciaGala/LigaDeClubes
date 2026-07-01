namespace LigaDeClubes.Controls
{
    partial class UserControlEquipos
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
            this.tableLayoutPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalEquiposCargados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportarEquipos = new System.Windows.Forms.Button();
            this.lblTotalEquipos = new System.Windows.Forms.Label();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.groupFiltros = new System.Windows.Forms.GroupBox();
            this.selectClub = new System.Windows.Forms.ComboBox();
            this.filtrarCategoria = new System.Windows.Forms.Button();
            this.filtrarClub = new System.Windows.Forms.Button();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            this.selectCategoria = new System.Windows.Forms.ComboBox();
            this.lblFiltroClub = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPrincipal.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.groupFiltros.SuspendLayout();
            this.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(253, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GESTIÓN DE EQUIPOS";
            // 
            // tableLayoutPrincipal
            // 
            this.tableLayoutPrincipal.ColumnCount = 1;
            this.tableLayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPrincipal.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPrincipal.Controls.Add(this.panelToolbar, 0, 1);
            this.tableLayoutPrincipal.Controls.Add(this.dgvEquipos, 0, 3);
            this.tableLayoutPrincipal.Controls.Add(this.groupFiltros, 0, 2);
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
            this.tableLayoutPrincipal.TabIndex = 0;
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.SystemColors.Control;
            this.panelToolbar.Controls.Add(this.label4);
            this.panelToolbar.Controls.Add(this.label3);
            this.panelToolbar.Controls.Add(this.label2);
            this.panelToolbar.Controls.Add(this.lblTotalEquiposCargados);
            this.panelToolbar.Controls.Add(this.label1);
            this.panelToolbar.Controls.Add(this.btnImportarEquipos);
            this.panelToolbar.Controls.Add(this.lblTotalEquipos);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelToolbar.Location = new System.Drawing.Point(0, 59);
            this.panelToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(595, 66);
            this.panelToolbar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(2, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "con los equipos a cargar en la ";
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
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "equipos cargados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnImportarEquipos
            // 
            this.btnImportarEquipos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImportarEquipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImportarEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarEquipos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarEquipos.ForeColor = System.Drawing.Color.White;
            this.btnImportarEquipos.Location = new System.Drawing.Point(300, 12);
            this.btnImportarEquipos.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportarEquipos.Name = "btnImportarEquipos";
            this.btnImportarEquipos.Size = new System.Drawing.Size(126, 39);
            this.btnImportarEquipos.TabIndex = 4;
            this.btnImportarEquipos.Text = "Importar";
            this.btnImportarEquipos.UseVisualStyleBackColor = false;
            this.btnImportarEquipos.Click += new System.EventHandler(this.btnImportar_Click);
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
            // dgvEquipos
            // 
            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.AllowUserToDeleteRows = false;
            this.dgvEquipos.BackgroundColor = System.Drawing.Color.White;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEquipos.Location = new System.Drawing.Point(2, 214);
            this.dgvEquipos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.ReadOnly = true;
            this.dgvEquipos.RowHeadersVisible = false;
            this.dgvEquipos.RowHeadersWidth = 51;
            this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipos.Size = new System.Drawing.Size(591, 207);
            this.dgvEquipos.TabIndex = 1;
            // 
            // groupFiltros
            // 
            this.groupFiltros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupFiltros.Controls.Add(this.selectClub);
            this.groupFiltros.Controls.Add(this.filtrarCategoria);
            this.groupFiltros.Controls.Add(this.filtrarClub);
            this.groupFiltros.Controls.Add(this.btnAgregarEquipo);
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
            this.groupFiltros.TabIndex = 0;
            this.groupFiltros.TabStop = false;
            this.groupFiltros.Text = "Filtrar";
            // 
            // selectClub
            // 
            this.selectClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectClub.Items.AddRange(new object[] {
            "Todas",
            "Infantiles",
            "Cadetes",
            "Juveniles",
            "Primera",
            "Veteranos"});
            this.selectClub.Location = new System.Drawing.Point(7, 45);
            this.selectClub.Margin = new System.Windows.Forms.Padding(2);
            this.selectClub.Name = "selectClub";
            this.selectClub.Size = new System.Drawing.Size(139, 27);
            this.selectClub.TabIndex = 11;
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
            // filtrarClub
            // 
            this.filtrarClub.BackColor = System.Drawing.Color.Maroon;
            this.filtrarClub.FlatAppearance.BorderSize = 0;
            this.filtrarClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrarClub.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarClub.ForeColor = System.Drawing.Color.White;
            this.filtrarClub.Location = new System.Drawing.Point(150, 44);
            this.filtrarClub.Margin = new System.Windows.Forms.Padding(2);
            this.filtrarClub.Name = "filtrarClub";
            this.filtrarClub.Size = new System.Drawing.Size(62, 28);
            this.filtrarClub.TabIndex = 9;
            this.filtrarClub.Text = "Filtrar";
            this.filtrarClub.UseVisualStyleBackColor = false;
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEquipo.BackColor = System.Drawing.Color.Maroon;
            this.btnAgregarEquipo.FlatAppearance.BorderSize = 0;
            this.btnAgregarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEquipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEquipo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEquipo.Location = new System.Drawing.Point(486, 21);
            this.btnAgregarEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(92, 51);
            this.btnAgregarEquipo.TabIndex = 9;
            this.btnAgregarEquipo.Text = "Agregar Equipo";
            this.btnAgregarEquipo.UseVisualStyleBackColor = false;
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
            this.lblFiltroClub.Size = new System.Drawing.Size(47, 20);
            this.lblFiltroClub.TabIndex = 3;
            this.lblFiltroClub.Text = "Club:";
            // 
            // UserControlEquipos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlEquipos";
            this.Size = new System.Drawing.Size(595, 423);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tableLayoutPrincipal.ResumeLayout(false);
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.groupFiltros.ResumeLayout(false);
            this.groupFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPrincipal;
        private System.Windows.Forms.GroupBox groupFiltros;
        private System.Windows.Forms.Label lblFiltroClub;
        private System.Windows.Forms.ComboBox selectCategoria;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Label lblTotalEquipos;
        private System.Windows.Forms.Button btnImportarEquipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalEquiposCargados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarEquipo;
        private System.Windows.Forms.Button filtrarClub;
        private System.Windows.Forms.Button filtrarCategoria;
        private System.Windows.Forms.ComboBox selectClub;
    }
}
