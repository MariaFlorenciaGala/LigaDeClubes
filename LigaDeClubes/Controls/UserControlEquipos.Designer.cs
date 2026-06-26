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
            this.groupFiltros = new System.Windows.Forms.GroupBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            this.cboFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.lblFiltroClub = new System.Windows.Forms.Label();
            this.txtFiltroClub = new System.Windows.Forms.TextBox();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTotalEquipos = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPrincipal.SuspendLayout();
            this.groupFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.panelToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkRed;
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(563, 45);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(8, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(253, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GESTIÓN DE EQUIPOS";
            // 
            // tableLayoutPrincipal
            // 
            this.tableLayoutPrincipal.ColumnCount = 2;
            this.tableLayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPrincipal.Controls.Add(this.groupFiltros, 0, 0);
            this.tableLayoutPrincipal.Controls.Add(this.dgvEquipos, 1, 0);
            this.tableLayoutPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPrincipal.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPrincipal.Name = "tableLayoutPrincipal";
            this.tableLayoutPrincipal.RowCount = 1;
            this.tableLayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPrincipal.Size = new System.Drawing.Size(563, 273);
            this.tableLayoutPrincipal.TabIndex = 0;
            // 
            // groupFiltros
            // 
            this.groupFiltros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupFiltros.Controls.Add(this.btnImportar);
            this.groupFiltros.Controls.Add(this.btnFiltrar);
            this.groupFiltros.Controls.Add(this.lblFiltroCategoria);
            this.groupFiltros.Controls.Add(this.cboFiltroCategoria);
            this.groupFiltros.Controls.Add(this.lblFiltroClub);
            this.groupFiltros.Controls.Add(this.txtFiltroClub);
            this.groupFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupFiltros.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupFiltros.Location = new System.Drawing.Point(3, 3);
            this.groupFiltros.Name = "groupFiltros";
            this.groupFiltros.Padding = new System.Windows.Forms.Padding(0);
            this.groupFiltros.Size = new System.Drawing.Size(194, 267);
            this.groupFiltros.TabIndex = 0;
            this.groupFiltros.TabStop = false;
            this.groupFiltros.Text = "Filtros";
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.DarkRed;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.White;
            this.btnImportar.Location = new System.Drawing.Point(10, 197);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(169, 30);
            this.btnImportar.TabIndex = 4;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Maroon;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(10, 155);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(170, 35);
            this.btnFiltrar.TabIndex = 0;
            this.btnFiltrar.Text = "Aplicar Filtro";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblFiltroCategoria
            // 
            this.lblFiltroCategoria.AutoSize = true;
            this.lblFiltroCategoria.Location = new System.Drawing.Point(7, 82);
            this.lblFiltroCategoria.Name = "lblFiltroCategoria";
            this.lblFiltroCategoria.Size = new System.Drawing.Size(88, 20);
            this.lblFiltroCategoria.TabIndex = 1;
            this.lblFiltroCategoria.Text = "Categoría:";
            // 
            // cboFiltroCategoria
            // 
            this.cboFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroCategoria.Items.AddRange(new object[] {
            "Todas",
            "Infantiles",
            "Cadetes",
            "Juveniles",
            "Primera",
            "Veteranos"});
            this.cboFiltroCategoria.Location = new System.Drawing.Point(10, 108);
            this.cboFiltroCategoria.Name = "cboFiltroCategoria";
            this.cboFiltroCategoria.Size = new System.Drawing.Size(160, 28);
            this.cboFiltroCategoria.TabIndex = 2;
            // 
            // lblFiltroClub
            // 
            this.lblFiltroClub.AutoSize = true;
            this.lblFiltroClub.Location = new System.Drawing.Point(7, 22);
            this.lblFiltroClub.Name = "lblFiltroClub";
            this.lblFiltroClub.Size = new System.Drawing.Size(47, 20);
            this.lblFiltroClub.TabIndex = 3;
            this.lblFiltroClub.Text = "Club:";
            // 
            // txtFiltroClub
            // 
            this.txtFiltroClub.Location = new System.Drawing.Point(10, 48);
            this.txtFiltroClub.Name = "txtFiltroClub";
            this.txtFiltroClub.Size = new System.Drawing.Size(160, 26);
            this.txtFiltroClub.TabIndex = 4;
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.AllowUserToDeleteRows = false;
            this.dgvEquipos.BackgroundColor = System.Drawing.Color.White;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEquipos.Location = new System.Drawing.Point(203, 3);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.ReadOnly = true;
            this.dgvEquipos.RowHeadersVisible = false;
            this.dgvEquipos.RowHeadersWidth = 51;
            this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipos.Size = new System.Drawing.Size(357, 267);
            this.dgvEquipos.TabIndex = 1;
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.SystemColors.Control;
            this.panelToolbar.Controls.Add(this.btnNuevo);
            this.panelToolbar.Controls.Add(this.btnEditar);
            this.panelToolbar.Controls.Add(this.btnEliminar);
            this.panelToolbar.Controls.Add(this.lblTotalEquipos);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelToolbar.Location = new System.Drawing.Point(0, 318);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(563, 45);
            this.panelToolbar.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DarkRed;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(6, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 33);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(108, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 33);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(210, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 33);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTotalEquipos
            // 
            this.lblTotalEquipos.AutoSize = true;
            this.lblTotalEquipos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTotalEquipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalEquipos.Location = new System.Drawing.Point(311, 11);
            this.lblTotalEquipos.Name = "lblTotalEquipos";
            this.lblTotalEquipos.Size = new System.Drawing.Size(141, 21);
            this.lblTotalEquipos.TabIndex = 3;
            this.lblTotalEquipos.Text = "Total: 0 equipos";
            // 
            // UserControlEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPrincipal);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelToolbar);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlEquipos";
            this.Size = new System.Drawing.Size(563, 363);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tableLayoutPrincipal.ResumeLayout(false);
            this.groupFiltros.ResumeLayout(false);
            this.groupFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPrincipal;
        private System.Windows.Forms.GroupBox groupFiltros;
        private System.Windows.Forms.TextBox txtFiltroClub;
        private System.Windows.Forms.Label lblFiltroClub;
        private System.Windows.Forms.ComboBox cboFiltroCategoria;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTotalEquipos;
        private System.Windows.Forms.Button btnImportar;
    }
}
