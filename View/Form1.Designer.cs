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
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.btnPoligono = new System.Windows.Forms.Button();
            this.lblLadoP = new System.Windows.Forms.Label();
            this.txtLadoP = new System.Windows.Forms.TextBox();
            this.txtCantidadP = new System.Windows.Forms.TextBox();
            this.lblCantidadP = new System.Windows.Forms.Label();
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
            this.lblArea.Location = new System.Drawing.Point(215, 30);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 13);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "AREA";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(215, 69);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(71, 13);
            this.lblPerimetro.TabIndex = 4;
            this.lblPerimetro.Text = "PERIMETRO";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Enabled = false;
            this.lblAltura.Location = new System.Drawing.Point(215, 108);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(50, 13);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "ALTURA";
            this.lblAltura.EnabledChanged += new System.EventHandler(this.btnTriangulo_Click);
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Enabled = false;
            this.lblRadio.Location = new System.Drawing.Point(16, 208);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(41, 13);
            this.lblRadio.TabIndex = 6;
            this.lblRadio.Text = "RADIO";
            this.lblRadio.EnabledChanged += new System.EventHandler(this.btnCirculo_Click);
            this.lblRadio.Click += new System.EventHandler(this.lblRadio_Click);
            // 
            // txtRadio
            // 
            this.txtRadio.Enabled = false;
            this.txtRadio.Location = new System.Drawing.Point(68, 201);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 7;
            this.txtRadio.EnabledChanged += new System.EventHandler(this.btnCirculo_Click);
            this.txtRadio.TextChanged += new System.EventHandler(this.txtRadio_TextChanged);
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Enabled = false;
            this.lblLadoC.Location = new System.Drawing.Point(16, 174);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(46, 13);
            this.lblLadoC.TabIndex = 8;
            this.lblLadoC.Text = "LADO C";
            this.lblLadoC.EnabledChanged += new System.EventHandler(this.btnCuadrado_Click);
            this.lblLadoC.Click += new System.EventHandler(this.lblLadoC_Click);
            // 
            // txtLadoC
            // 
            this.txtLadoC.Enabled = false;
            this.txtLadoC.Location = new System.Drawing.Point(68, 167);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(100, 20);
            this.txtLadoC.TabIndex = 9;
            this.txtLadoC.EnabledChanged += new System.EventHandler(this.btnCuadrado_Click);
            this.txtLadoC.TextChanged += new System.EventHandler(this.txtLadoC_TextChanged);
            // 
            // txtResArea
            // 
            this.txtResArea.Location = new System.Drawing.Point(304, 23);
            this.txtResArea.Name = "txtResArea";
            this.txtResArea.ReadOnly = true;
            this.txtResArea.Size = new System.Drawing.Size(149, 20);
            this.txtResArea.TabIndex = 12;
            this.txtResArea.VisibleChanged += new System.EventHandler(this.Form1_Load);
            // 
            // txtResPerimetro
            // 
            this.txtResPerimetro.Location = new System.Drawing.Point(304, 66);
            this.txtResPerimetro.Name = "txtResPerimetro";
            this.txtResPerimetro.ReadOnly = true;
            this.txtResPerimetro.Size = new System.Drawing.Size(149, 20);
            this.txtResPerimetro.TabIndex = 13;
            this.txtResPerimetro.VisibleChanged += new System.EventHandler(this.Form1_Load);
            // 
            // txtResAltura
            // 
            this.txtResAltura.Enabled = false;
            this.txtResAltura.Location = new System.Drawing.Point(304, 105);
            this.txtResAltura.Name = "txtResAltura";
            this.txtResAltura.ReadOnly = true;
            this.txtResAltura.Size = new System.Drawing.Size(149, 20);
            this.txtResAltura.TabIndex = 14;
            this.txtResAltura.EnabledChanged += new System.EventHandler(this.btnTriangulo_Click);
            this.txtResAltura.TextChanged += new System.EventHandler(this.txtResAltura_TextChanged);
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Enabled = false;
            this.lblLado1.Location = new System.Drawing.Point(17, 247);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(45, 13);
            this.lblLado1.TabIndex = 15;
            this.lblLado1.Text = "LADO 1";
            this.lblLado1.EnabledChanged += new System.EventHandler(this.btnTriangulo_Click);
            this.lblLado1.Click += new System.EventHandler(this.lblLado1_Click);
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Enabled = false;
            this.lblLado2.Location = new System.Drawing.Point(197, 247);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(45, 13);
            this.lblLado2.TabIndex = 16;
            this.lblLado2.Text = "LADO 2";
            this.lblLado2.EnabledChanged += new System.EventHandler(this.btnTriangulo_Click);
            this.lblLado2.Click += new System.EventHandler(this.lblLado2_Click);
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Enabled = false;
            this.lblLado3.Location = new System.Drawing.Point(383, 247);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(45, 13);
            this.lblLado3.TabIndex = 17;
            this.lblLado3.Text = "LADO 3";
            this.lblLado3.EnabledChanged += new System.EventHandler(this.btnTriangulo_Click);
            this.lblLado3.Click += new System.EventHandler(this.lblLado3_Click);
            // 
            // txtLado1
            // 
            this.txtLado1.Enabled = false;
            this.txtLado1.Location = new System.Drawing.Point(68, 240);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 18;
            this.txtLado1.EnabledChanged += new System.EventHandler(this.btnTriangulo_Click);
            this.txtLado1.TextChanged += new System.EventHandler(this.txtLado1_TextChanged);
            this.txtLado1.Enter += new System.EventHandler(this.Form1_Load);
            this.txtLado1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLado1_KeyDown);
            // 
            // txtLado2
            // 
            this.txtLado2.Enabled = false;
            this.txtLado2.Location = new System.Drawing.Point(248, 240);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 19;
            this.txtLado2.EnabledChanged += new System.EventHandler(this.btnTriangulo_Click);
            this.txtLado2.TextChanged += new System.EventHandler(this.txtLado2_TextChanged);
            this.txtLado2.Enter += new System.EventHandler(this.Form1_Load);
            this.txtLado2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLado2_KeyDown);
            // 
            // txtLado3
            // 
            this.txtLado3.Enabled = false;
            this.txtLado3.Location = new System.Drawing.Point(434, 240);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 20);
            this.txtLado3.TabIndex = 20;
            this.txtLado3.EnabledChanged += new System.EventHandler(this.btnTriangulo_Click);
            this.txtLado3.TextChanged += new System.EventHandler(this.txtLado3_TextChanged);
            this.txtLado3.Enter += new System.EventHandler(this.Form1_Load);
            this.txtLado3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLado3_KeyDown);
            // 
            // btnPoligono
            // 
            this.btnPoligono.Location = new System.Drawing.Point(13, 119);
            this.btnPoligono.Name = "btnPoligono";
            this.btnPoligono.Size = new System.Drawing.Size(112, 23);
            this.btnPoligono.TabIndex = 21;
            this.btnPoligono.Text = "Crear Poligono";
            this.btnPoligono.UseVisualStyleBackColor = true;
            this.btnPoligono.Click += new System.EventHandler(this.btnPoligono_Click);
            // 
            // lblLadoP
            // 
            this.lblLadoP.AutoSize = true;
            this.lblLadoP.Enabled = false;
            this.lblLadoP.Location = new System.Drawing.Point(16, 286);
            this.lblLadoP.Name = "lblLadoP";
            this.lblLadoP.Size = new System.Drawing.Size(46, 13);
            this.lblLadoP.TabIndex = 22;
            this.lblLadoP.Text = "LADO P";
            // 
            // txtLadoP
            // 
            this.txtLadoP.Enabled = false;
            this.txtLadoP.Location = new System.Drawing.Point(68, 279);
            this.txtLadoP.Name = "txtLadoP";
            this.txtLadoP.Size = new System.Drawing.Size(100, 20);
            this.txtLadoP.TabIndex = 23;
            this.txtLadoP.TextChanged += new System.EventHandler(this.txtLadoP_TextChanged);
            this.txtLadoP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLadoP_KeyDown);
            // 
            // txtCantidadP
            // 
            this.txtCantidadP.Enabled = false;
            this.txtCantidadP.Location = new System.Drawing.Point(265, 279);
            this.txtCantidadP.Name = "txtCantidadP";
            this.txtCantidadP.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadP.TabIndex = 24;
            this.txtCantidadP.TextChanged += new System.EventHandler(this.txtCantidadP_TextChanged);
            this.txtCantidadP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidadP_KeyDown);
            // 
            // lblCantidadP
            // 
            this.lblCantidadP.AutoSize = true;
            this.lblCantidadP.Enabled = false;
            this.lblCantidadP.Location = new System.Drawing.Point(197, 286);
            this.lblCantidadP.Name = "lblCantidadP";
            this.lblCantidadP.Size = new System.Drawing.Size(62, 13);
            this.lblCantidadP.TabIndex = 25;
            this.lblCantidadP.Text = "CANTIDAD";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(667, 398);
            this.Controls.Add(this.lblCantidadP);
            this.Controls.Add(this.txtCantidadP);
            this.Controls.Add(this.txtLadoP);
            this.Controls.Add(this.lblLadoP);
            this.Controls.Add(this.btnPoligono);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado1);
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
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Button btnPoligono;
        private System.Windows.Forms.Label lblLadoP;
        private System.Windows.Forms.TextBox txtLadoP;
        private System.Windows.Forms.TextBox txtCantidadP;
        private System.Windows.Forms.Label lblCantidadP;
    }
}

