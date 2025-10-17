namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new RichTextBox();
            btnBorrar = new Button();
            btnBorrarTodo = new Button();
            btnQuitar = new Button();
            btnNueve = new Button();
            btnOcho = new Button();
            btnSiete = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnCuatro = new Button();
            btnTres = new Button();
            btnDos = new Button();
            btnUno = new Button();
            btnPunto = new Button();
            btnCero = new Button();
            btnSigno = new Button();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplica = new Button();
            btnDividir = new Button();
            btnCuadrado = new Button();
            btnRaizCuadrada = new Button();
            btnResultado = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.Info;
            txtResultado.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(12, 27);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(425, 117);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(18, 156);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(71, 78);
            btnBorrar.TabIndex = 1;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(95, 156);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(71, 78);
            btnBorrarTodo.TabIndex = 2;
            btnBorrarTodo.Text = "C";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(172, 156);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(71, 78);
            btnQuitar.TabIndex = 3;
            btnQuitar.Text = "-<";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnNueve
            // 
            btnNueve.Location = new Point(172, 240);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(71, 78);
            btnNueve.TabIndex = 6;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            btnNueve.Click += agregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.Location = new Point(95, 240);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(71, 78);
            btnOcho.TabIndex = 5;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += agregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.Location = new Point(18, 240);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(71, 78);
            btnSiete.TabIndex = 4;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += agregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(172, 324);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(71, 78);
            btnSeis.TabIndex = 9;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += agregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(95, 324);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(71, 78);
            btnCinco.TabIndex = 8;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += agregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.Location = new Point(18, 324);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(71, 78);
            btnCuatro.TabIndex = 7;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += agregarNumero;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(172, 408);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(71, 78);
            btnTres.TabIndex = 12;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += agregarNumero;
            // 
            // btnDos
            // 
            btnDos.Location = new Point(95, 408);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(71, 78);
            btnDos.TabIndex = 11;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += agregarNumero;
            // 
            // btnUno
            // 
            btnUno.Location = new Point(18, 408);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(71, 78);
            btnUno.TabIndex = 10;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += agregarNumero;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPunto.Location = new Point(172, 492);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(71, 78);
            btnPunto.TabIndex = 15;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnCero
            // 
            btnCero.Location = new Point(95, 492);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(71, 78);
            btnCero.TabIndex = 14;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += agregarNumero;
            // 
            // btnSigno
            // 
            btnSigno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSigno.Location = new Point(18, 489);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new Size(71, 78);
            btnSigno.TabIndex = 13;
            btnSigno.Text = "-/+";
            btnSigno.UseVisualStyleBackColor = true;
            btnSigno.Click += btnSigno_Click;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSumar.Location = new Point(366, 324);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(71, 78);
            btnSumar.TabIndex = 21;
            btnSumar.Tag = "+";
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += clickOperador;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestar.Location = new Point(289, 324);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(71, 78);
            btnRestar.TabIndex = 20;
            btnRestar.Tag = "-";
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += clickOperador;
            // 
            // btnMultiplica
            // 
            btnMultiplica.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplica.Location = new Point(366, 240);
            btnMultiplica.Name = "btnMultiplica";
            btnMultiplica.Size = new Size(71, 78);
            btnMultiplica.TabIndex = 19;
            btnMultiplica.Tag = "X";
            btnMultiplica.Text = "×";
            btnMultiplica.UseVisualStyleBackColor = true;
            btnMultiplica.Click += clickOperador;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(289, 240);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(71, 78);
            btnDividir.TabIndex = 18;
            btnDividir.Tag = "/";
            btnDividir.Text = "÷";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += clickOperador;
            // 
            // btnCuadrado
            // 
            btnCuadrado.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCuadrado.Location = new Point(366, 156);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new Size(71, 78);
            btnCuadrado.TabIndex = 17;
            btnCuadrado.Tag = "²";
            btnCuadrado.Text = "X²";
            btnCuadrado.UseVisualStyleBackColor = true;
            btnCuadrado.Click += clickOperador;
            // 
            // btnRaizCuadrada
            // 
            btnRaizCuadrada.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRaizCuadrada.Location = new Point(289, 156);
            btnRaizCuadrada.Name = "btnRaizCuadrada";
            btnRaizCuadrada.Size = new Size(71, 78);
            btnRaizCuadrada.TabIndex = 16;
            btnRaizCuadrada.Tag = "√";
            btnRaizCuadrada.Text = "√";
            btnRaizCuadrada.UseVisualStyleBackColor = true;
            btnRaizCuadrada.Click += clickOperador;
            // 
            // btnResultado
            // 
            btnResultado.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResultado.Location = new Point(289, 408);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(148, 78);
            btnResultado.TabIndex = 22;
            btnResultado.Tag = "";
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 558);
            Controls.Add(btnResultado);
            Controls.Add(btnSumar);
            Controls.Add(btnRestar);
            Controls.Add(btnMultiplica);
            Controls.Add(btnDividir);
            Controls.Add(btnCuadrado);
            Controls.Add(btnRaizCuadrada);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnSigno);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnQuitar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnBorrar);
            Controls.Add(txtResultado);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtResultado;
        private Button btnBorrar;
        private Button btnBorrarTodo;
        private Button btnQuitar;
        private Button btnNueve;
        private Button btnOcho;
        private Button btnSiete;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnCuatro;
        private Button btnTres;
        private Button btnDos;
        private Button btnUno;
        private Button btnPunto;
        private Button btnCero;
        private Button btnSigno;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplica;
        private Button btnDividir;
        private Button btnCuadrado;
        private Button btnRaizCuadrada;
        private Button btnResultado;
    }
}
