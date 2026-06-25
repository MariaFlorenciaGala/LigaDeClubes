using LigaDeClubes.Properties;

namespace LigaDeClubes
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelBtns = new System.Windows.Forms.Panel();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnFuncionalidades = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.panelLateral.SuspendLayout();
            this.panelBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.DarkRed;
            this.panelLateral.Controls.Add(this.panelBtns);
            this.panelLateral.Controls.Add(this.pictureBox1);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(237, 450);
            this.panelLateral.TabIndex = 0;
            // 
            // panelBtns
            // 
            this.panelBtns.BackColor = System.Drawing.Color.DarkRed;
            this.panelBtns.Controls.Add(this.btnInformacion);
            this.panelBtns.Controls.Add(this.btnReportes);
            this.panelBtns.Controls.Add(this.btnFuncionalidades);
            this.panelBtns.Controls.Add(this.btnEstadisticas);
            this.panelBtns.Controls.Add(this.btnPartidos);
            this.panelBtns.Controls.Add(this.btnJugadores);
            this.panelBtns.Controls.Add(this.btnEquipos);
            this.panelBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBtns.Location = new System.Drawing.Point(0, 136);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(237, 314);
            this.panelBtns.TabIndex = 1;
            // 
            // btnPartidos
            // 
            this.btnPartidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPartidos.FlatAppearance.BorderSize = 0;
            this.btnPartidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos.Location = new System.Drawing.Point(0, 80);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(237, 40);
            this.btnPartidos.TabIndex = 2;
            this.btnPartidos.Text = "Partidos";
            this.btnPartidos.UseVisualStyleBackColor = true;
            // 
            // btnJugadores
            // 
            this.btnJugadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJugadores.FlatAppearance.BorderSize = 0;
            this.btnJugadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugadores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugadores.Location = new System.Drawing.Point(0, 40);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(237, 40);
            this.btnJugadores.TabIndex = 1;
            this.btnJugadores.Text = "Jugadores";
            this.btnJugadores.UseVisualStyleBackColor = true;
            // 
            // btnEquipos
            // 
            this.btnEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEquipos.FlatAppearance.BorderSize = 0;
            this.btnEquipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipos.Location = new System.Drawing.Point(0, 0);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(237, 40);
            this.btnEquipos.TabIndex = 0;
            this.btnEquipos.Text = "Equipos";
            this.btnEquipos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Location = new System.Drawing.Point(738, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 40);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 120);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(237, 40);
            this.btnEstadisticas.TabIndex = 3;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // btnFuncionalidades
            // 
            this.btnFuncionalidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFuncionalidades.FlatAppearance.BorderSize = 0;
            this.btnFuncionalidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFuncionalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionalidades.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionalidades.Location = new System.Drawing.Point(0, 160);
            this.btnFuncionalidades.Name = "btnFuncionalidades";
            this.btnFuncionalidades.Size = new System.Drawing.Size(237, 40);
            this.btnFuncionalidades.TabIndex = 4;
            this.btnFuncionalidades.Text = "Funcionalidades";
            this.btnFuncionalidades.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(0, 200);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(237, 40);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnInformacion
            // 
            this.btnInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformacion.FlatAppearance.BorderSize = 0;
            this.btnInformacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.Location = new System.Drawing.Point(0, 240);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(237, 40);
            this.btnInformacion.TabIndex = 6;
            this.btnInformacion.Text = "Informacion";
            this.btnInformacion.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panelLateral);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.panelBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelBtns;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnFuncionalidades;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}