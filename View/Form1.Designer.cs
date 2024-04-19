namespace FiguraGeometrica2
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.txtResArea = new System.Windows.Forms.TextBox();
            this.txtResPerimetro = new System.Windows.Forms.TextBox();
            this.txtResAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Location = new System.Drawing.Point(13, 30);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(112, 23);
            this.btnCuadrado.TabIndex = 0;
            this.btnCuadrado.Text = "Crear Cuadrado";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(13, 59);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(112, 23);
            this.btnCirculo.TabIndex = 1;
            this.btnCirculo.Text = "Crear Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(13, 89);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(112, 23);
            this.btnTriangulo.TabIndex = 2;
            this.btnTriangulo.Text = "Crear Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(254, 30);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 13);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "AREA";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(371, 30);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(71, 13);
            this.lblPerimetro.TabIndex = 4;
            this.lblPerimetro.Text = "PERIMETRO";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(506, 30);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(50, 13);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "ALTURA";
            this.lblAltura.Visible = false;
            this.lblAltura.VisibleChanged += new System.EventHandler(this.btnTriangulo_Click);
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(13, 168);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(41, 13);
            this.lblRadio.TabIndex = 6;
            this.lblRadio.Text = "RADIO";
            this.lblRadio.Visible = false;
            this.lblRadio.VisibleChanged += new System.EventHandler(this.btnCirculo_Click);
            this.lblRadio.Click += new System.EventHandler(this.lblRadio_Click);
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(71, 168);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 7;
            this.txtRadio.Visible = false;
            this.txtRadio.TextChanged += new System.EventHandler(this.txtRadio_TextChanged);
            this.txtRadio.VisibleChanged += new System.EventHandler(this.btnCirculo_Click);
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Location = new System.Drawing.Point(16, 138);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(36, 13);
            this.lblLadoC.TabIndex = 8;
            this.lblLadoC.Text = "LADO";
            this.lblLadoC.Visible = false;
            this.lblLadoC.VisibleChanged += new System.EventHandler(this.btnCuadrado_Click);
            this.lblLadoC.Click += new System.EventHandler(this.lblLadoC_Click);
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(71, 138);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(100, 20);
            this.txtLadoC.TabIndex = 9;
            this.txtLadoC.Visible = false;
            this.txtLadoC.TextChanged += new System.EventHandler(this.txtLadoC_TextChanged);
            this.txtLadoC.VisibleChanged += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // txtResArea
            // 
            this.txtResArea.Location = new System.Drawing.Point(231, 62);
            this.txtResArea.Name = "txtResArea";
            this.txtResArea.ReadOnly = true;
            this.txtResArea.Size = new System.Drawing.Size(81, 20);
            this.txtResArea.TabIndex = 12;
            this.txtResArea.VisibleChanged += new System.EventHandler(this.Form1_Load);
            // 
            // txtResPerimetro
            // 
            this.txtResPerimetro.Location = new System.Drawing.Point(367, 61);
            this.txtResPerimetro.Name = "txtResPerimetro";
            this.txtResPerimetro.ReadOnly = true;
            this.txtResPerimetro.Size = new System.Drawing.Size(75, 20);
            this.txtResPerimetro.TabIndex = 13;
            this.txtResPerimetro.VisibleChanged += new System.EventHandler(this.Form1_Load);
            // 
            // txtResAltura
            // 
            this.txtResAltura.Location = new System.Drawing.Point(492, 62);
            this.txtResAltura.Name = "txtResAltura";
            this.txtResAltura.ReadOnly = true;
            this.txtResAltura.Size = new System.Drawing.Size(74, 20);
            this.txtResAltura.TabIndex = 14;
            this.txtResAltura.Visible = false;
            this.txtResAltura.TextChanged += new System.EventHandler(this.txtResAltura_TextChanged);
            this.txtResAltura.VisibleChanged += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(667, 398);
            this.Controls.Add(this.txtResAltura);
            this.Controls.Add(this.txtResPerimetro);
            this.Controls.Add(this.txtResArea);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.btnCuadrado);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearFigura;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearTrianguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCirculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCuadradoToolStripMenuItem;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.TextBox txtResArea;
        private System.Windows.Forms.TextBox txtResPerimetro;
        private System.Windows.Forms.TextBox txtResAltura;
    }
}

