namespace LigaDeClubes.Controls
{
    partial class UserControlEstadisticas
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
            this.panelSelector = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPartido = new System.Windows.Forms.Label();
            this.cboPartidos = new System.Windows.Forms.ComboBox();
            this.tableLayoutCuerpo = new System.Windows.Forms.TableLayoutPanel();
            this.groupGolesJugador = new System.Windows.Forms.GroupBox();
            this.groupAsistencias = new System.Windows.Forms.GroupBox();
            this.groupGolesRecibidos = new System.Windows.Forms.GroupBox();
            this.groupGoleador = new System.Windows.Forms.GroupBox();
            this.groupRanking = new System.Windows.Forms.GroupBox();
            this.groupMejorArquero = new System.Windows.Forms.GroupBox();
            this.equipo1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.equipo2 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelSelector.SuspendLayout();
            this.tableLayoutCuerpo.SuspendLayout();
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
            this.panelHeader.Size = new System.Drawing.Size(506, 57);
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
            this.lblTitulo.Size = new System.Drawing.Size(166, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ESTADÍSTICAS";
            // 
            // panelSelector
            // 
            this.panelSelector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSelector.Controls.Add(this.equipo2);
            this.panelSelector.Controls.Add(this.label3);
            this.panelSelector.Controls.Add(this.equipo1);
            this.panelSelector.Controls.Add(this.comboBox1);
            this.panelSelector.Controls.Add(this.label1);
            this.panelSelector.Controls.Add(this.lblPartido);
            this.panelSelector.Controls.Add(this.cboPartidos);
            this.panelSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelector.Location = new System.Drawing.Point(0, 57);
            this.panelSelector.Margin = new System.Windows.Forms.Padding(2);
            this.panelSelector.Name = "panelSelector";
            this.panelSelector.Size = new System.Drawing.Size(506, 87);
            this.panelSelector.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.comboBox1.Location = new System.Drawing.Point(75, 48);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Partido:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblPartido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPartido.Location = new System.Drawing.Point(6, 14);
            this.lblPartido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(62, 20);
            this.lblPartido.TabIndex = 0;
            this.lblPartido.Text = "Torneo:";
            this.lblPartido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPartido.Click += new System.EventHandler(this.lblPartido_Click);
            // 
            // cboPartidos
            // 
            this.cboPartidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPartidos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cboPartidos.Location = new System.Drawing.Point(75, 10);
            this.cboPartidos.Margin = new System.Windows.Forms.Padding(2);
            this.cboPartidos.Name = "cboPartidos";
            this.cboPartidos.Size = new System.Drawing.Size(97, 28);
            this.cboPartidos.TabIndex = 1;
            // 
            // tableLayoutCuerpo
            // 
            this.tableLayoutCuerpo.ColumnCount = 2;
            this.tableLayoutCuerpo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutCuerpo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutCuerpo.Controls.Add(this.groupGolesJugador, 0, 0);
            this.tableLayoutCuerpo.Controls.Add(this.groupAsistencias, 1, 0);
            this.tableLayoutCuerpo.Controls.Add(this.groupGolesRecibidos, 0, 1);
            this.tableLayoutCuerpo.Controls.Add(this.groupGoleador, 1, 1);
            this.tableLayoutCuerpo.Controls.Add(this.groupRanking, 0, 2);
            this.tableLayoutCuerpo.Controls.Add(this.groupMejorArquero, 1, 2);
            this.tableLayoutCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutCuerpo.Location = new System.Drawing.Point(0, 144);
            this.tableLayoutCuerpo.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutCuerpo.Name = "tableLayoutCuerpo";
            this.tableLayoutCuerpo.RowCount = 3;
            this.tableLayoutCuerpo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutCuerpo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutCuerpo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutCuerpo.Size = new System.Drawing.Size(506, 221);
            this.tableLayoutCuerpo.TabIndex = 1;
            // 
            // groupGolesJugador
            // 
            this.groupGolesJugador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGolesJugador.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupGolesJugador.Location = new System.Drawing.Point(2, 2);
            this.groupGolesJugador.Margin = new System.Windows.Forms.Padding(2);
            this.groupGolesJugador.Name = "groupGolesJugador";
            this.groupGolesJugador.Padding = new System.Windows.Forms.Padding(2);
            this.groupGolesJugador.Size = new System.Drawing.Size(249, 69);
            this.groupGolesJugador.TabIndex = 0;
            this.groupGolesJugador.TabStop = false;
            this.groupGolesJugador.Text = "Goles por jugador";
            // 
            // groupAsistencias
            // 
            this.groupAsistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupAsistencias.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupAsistencias.Location = new System.Drawing.Point(255, 2);
            this.groupAsistencias.Margin = new System.Windows.Forms.Padding(2);
            this.groupAsistencias.Name = "groupAsistencias";
            this.groupAsistencias.Padding = new System.Windows.Forms.Padding(2);
            this.groupAsistencias.Size = new System.Drawing.Size(249, 69);
            this.groupAsistencias.TabIndex = 0;
            this.groupAsistencias.TabStop = false;
            this.groupAsistencias.Text = "Asistencias";
            // 
            // groupGolesRecibidos
            // 
            this.groupGolesRecibidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGolesRecibidos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupGolesRecibidos.Location = new System.Drawing.Point(2, 75);
            this.groupGolesRecibidos.Margin = new System.Windows.Forms.Padding(2);
            this.groupGolesRecibidos.Name = "groupGolesRecibidos";
            this.groupGolesRecibidos.Padding = new System.Windows.Forms.Padding(2);
            this.groupGolesRecibidos.Size = new System.Drawing.Size(249, 69);
            this.groupGolesRecibidos.TabIndex = 0;
            this.groupGolesRecibidos.TabStop = false;
            this.groupGolesRecibidos.Text = "Goles recibidos (arquero titular)";
            // 
            // groupGoleador
            // 
            this.groupGoleador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGoleador.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupGoleador.Location = new System.Drawing.Point(255, 75);
            this.groupGoleador.Margin = new System.Windows.Forms.Padding(2);
            this.groupGoleador.Name = "groupGoleador";
            this.groupGoleador.Padding = new System.Windows.Forms.Padding(2);
            this.groupGoleador.Size = new System.Drawing.Size(249, 69);
            this.groupGoleador.TabIndex = 0;
            this.groupGoleador.TabStop = false;
            this.groupGoleador.Text = "Goleador del torneo";
            // 
            // groupRanking
            // 
            this.groupRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupRanking.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupRanking.Location = new System.Drawing.Point(2, 148);
            this.groupRanking.Margin = new System.Windows.Forms.Padding(2);
            this.groupRanking.Name = "groupRanking";
            this.groupRanking.Padding = new System.Windows.Forms.Padding(2);
            this.groupRanking.Size = new System.Drawing.Size(249, 71);
            this.groupRanking.TabIndex = 0;
            this.groupRanking.TabStop = false;
            this.groupRanking.Text = "Ranking de goleadores";
            // 
            // groupMejorArquero
            // 
            this.groupMejorArquero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMejorArquero.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupMejorArquero.Location = new System.Drawing.Point(255, 148);
            this.groupMejorArquero.Margin = new System.Windows.Forms.Padding(2);
            this.groupMejorArquero.Name = "groupMejorArquero";
            this.groupMejorArquero.Padding = new System.Windows.Forms.Padding(2);
            this.groupMejorArquero.Size = new System.Drawing.Size(249, 71);
            this.groupMejorArquero.TabIndex = 0;
            this.groupMejorArquero.TabStop = false;
            this.groupMejorArquero.Text = "Mejor arquero";
            // 
            // equipo1
            // 
            this.equipo1.AutoSize = true;
            this.equipo1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.equipo1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.equipo1.Location = new System.Drawing.Point(233, 19);
            this.equipo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.equipo1.Name = "equipo1";
            this.equipo1.Size = new System.Drawing.Size(77, 19);
            this.equipo1.TabIndex = 4;
            this.equipo1.Text = "equipo1";
            this.equipo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(314, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = " - Vs - ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // equipo2
            // 
            this.equipo2.AutoSize = true;
            this.equipo2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.equipo2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.equipo2.Location = new System.Drawing.Point(381, 19);
            this.equipo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.equipo2.Name = "equipo2";
            this.equipo2.Size = new System.Drawing.Size(77, 19);
            this.equipo2.TabIndex = 7;
            this.equipo2.Text = "equipo2";
            this.equipo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControlEstadisticas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutCuerpo);
            this.Controls.Add(this.panelSelector);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlEstadisticas";
            this.Size = new System.Drawing.Size(506, 365);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSelector.ResumeLayout(false);
            this.panelSelector.PerformLayout();
            this.tableLayoutCuerpo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelSelector;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.ComboBox cboPartidos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutCuerpo;
        private System.Windows.Forms.GroupBox groupGolesJugador;
        private System.Windows.Forms.GroupBox groupAsistencias;
        private System.Windows.Forms.GroupBox groupGolesRecibidos;
        private System.Windows.Forms.GroupBox groupGoleador;
        private System.Windows.Forms.GroupBox groupRanking;
        private System.Windows.Forms.GroupBox groupMejorArquero;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label equipo1;
        private System.Windows.Forms.Label equipo2;
    }
}
