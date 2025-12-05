namespace risk_manager
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
            tabPage1 = new TabPage();
            label5 = new Label();
            btnIrEvaluacion = new Button();
            rtbDescripcion = new RichTextBox();
            txtResponsable = new TextBox();
            txtNombre = new TextBox();
            txtID = new TextBox();
            cmbArea = new ComboBox();
            label6 = new Label();
            Responsable = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnGuardar = new Button();
            txtNivel = new TextBox();
            label15 = new Label();
            txtResultado = new TextBox();
            label14 = new Label();
            btnCalcular = new Button();
            nudF = new NumericUpDown();
            nudV = new NumericUpDown();
            nudA = new NumericUpDown();
            nudP = new NumericUpDown();
            nudE = new NumericUpDown();
            nudC = new NumericUpDown();
            label12 = new Label();
            label13 = new Label();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tabControl1 = new TabControl();
            tabHistorial = new TabPage();
            btnCargarHistorial = new Button();
            dgvHistorial = new DataGridView();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudC).BeginInit();
            tabControl1.SuspendLayout();
            tabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(btnIrEvaluacion);
            tabPage1.Controls.Add(rtbDescripcion);
            tabPage1.Controls.Add(txtResponsable);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(txtID);
            tabPage1.Controls.Add(cmbArea);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(Responsable);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(564, 492);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 238);
            label5.Name = "label5";
            label5.Size = new Size(115, 38);
            label5.TabIndex = 16;
            label5.Text = "Persona";
            // 
            // btnIrEvaluacion
            // 
            btnIrEvaluacion.Location = new Point(6, 418);
            btnIrEvaluacion.Name = "btnIrEvaluacion";
            btnIrEvaluacion.Size = new Size(214, 39);
            btnIrEvaluacion.TabIndex = 15;
            btnIrEvaluacion.Text = "Ir a Evaluación";
            btnIrEvaluacion.UseVisualStyleBackColor = true;
            btnIrEvaluacion.Click += btnIrEvaluacion_Click;
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.BackColor = SystemColors.InactiveCaption;
            rtbDescripcion.Location = new Point(135, 290);
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(414, 83);
            rtbDescripcion.TabIndex = 14;
            rtbDescripcion.Text = "";
            // 
            // txtResponsable
            // 
            txtResponsable.BackColor = SystemColors.InactiveCaption;
            txtResponsable.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResponsable.Location = new Point(135, 238);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(136, 31);
            txtResponsable.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(135, 143);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(136, 31);
            txtNombre.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.InactiveCaption;
            txtID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.ForeColor = Color.Black;
            txtID.Location = new Point(135, 95);
            txtID.Name = "txtID";
            txtID.Size = new Size(136, 31);
            txtID.TabIndex = 7;
            // 
            // cmbArea
            // 
            cmbArea.BackColor = SystemColors.InactiveCaption;
            cmbArea.FormattingEnabled = true;
            cmbArea.Location = new Point(135, 194);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(136, 28);
            cmbArea.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 279);
            label6.Name = "label6";
            label6.Size = new Size(135, 38);
            label6.TabIndex = 5;
            label6.Text = "Problema";
            // 
            // Responsable
            // 
            Responsable.AutoSize = true;
            Responsable.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Responsable.Location = new Point(6, 231);
            Responsable.Name = "Responsable";
            Responsable.Size = new Size(0, 38);
            Responsable.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 184);
            label4.Name = "label4";
            label4.Size = new Size(74, 38);
            label4.TabIndex = 3;
            label4.Text = "Area";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 136);
            label3.Name = "label3";
            label3.Size = new Size(119, 38);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 88);
            label2.Name = "label2";
            label2.Size = new Size(44, 38);
            label2.TabIndex = 1;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(250, 40);
            label1.TabIndex = 0;
            label1.Text = "Registro de Riesgo";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnGuardar);
            tabPage2.Controls.Add(txtNivel);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(txtResultado);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(btnCalcular);
            tabPage2.Controls.Add(nudF);
            tabPage2.Controls.Add(nudV);
            tabPage2.Controls.Add(nudA);
            tabPage2.Controls.Add(nudP);
            tabPage2.Controls.Add(nudE);
            tabPage2.Controls.Add(nudC);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(564, 492);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Evaluacion";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(7, 442);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(151, 44);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNivel
            // 
            txtNivel.BackColor = SystemColors.InactiveCaption;
            txtNivel.BorderStyle = BorderStyle.FixedSingle;
            txtNivel.Location = new Point(338, 430);
            txtNivel.Name = "txtNivel";
            txtNivel.ReadOnly = true;
            txtNivel.Size = new Size(138, 27);
            txtNivel.TabIndex = 17;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(178, 426);
            label15.Name = "label15";
            label15.Size = new Size(77, 31);
            label15.TabIndex = 16;
            label15.Text = "Nivel :";
            label15.Click += label15_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.InactiveCaption;
            txtResultado.BorderStyle = BorderStyle.FixedSingle;
            txtResultado.Location = new Point(338, 383);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(138, 27);
            txtResultado.TabIndex = 15;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(178, 379);
            label14.Name = "label14";
            label14.Size = new Size(154, 31);
            label14.TabIndex = 14;
            label14.Text = "Resultado (R):";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(6, 369);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(152, 59);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular Riesgo";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // nudF
            // 
            nudF.Location = new Point(227, 333);
            nudF.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudF.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudF.Name = "nudF";
            nudF.Size = new Size(77, 27);
            nudF.TabIndex = 12;
            nudF.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudV
            // 
            nudV.Location = new Point(227, 283);
            nudV.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudV.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudV.Name = "nudV";
            nudV.Size = new Size(77, 27);
            nudV.TabIndex = 11;
            nudV.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudA
            // 
            nudA.Location = new Point(227, 234);
            nudA.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudA.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudA.Name = "nudA";
            nudA.Size = new Size(77, 27);
            nudA.TabIndex = 10;
            nudA.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudP
            // 
            nudP.Location = new Point(227, 184);
            nudP.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudP.Name = "nudP";
            nudP.Size = new Size(77, 27);
            nudP.TabIndex = 9;
            nudP.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudE
            // 
            nudE.Location = new Point(227, 136);
            nudE.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudE.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudE.Name = "nudE";
            nudE.Size = new Size(77, 27);
            nudE.TabIndex = 8;
            nudE.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudC
            // 
            nudC.Location = new Point(227, 86);
            nudC.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudC.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudC.Name = "nudC";
            nudC.Size = new Size(77, 27);
            nudC.TabIndex = 7;
            nudC.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(6, 322);
            label12.Name = "label12";
            label12.Size = new Size(150, 38);
            label12.TabIndex = 6;
            label12.Text = "Frecuencia";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(6, 272);
            label13.Name = "label13";
            label13.Size = new Size(194, 38);
            label13.TabIndex = 5;
            label13.Text = "Vulnerabilidad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 223);
            label10.Name = "label10";
            label10.Size = new Size(147, 38);
            label10.TabIndex = 4;
            label10.Text = "Afectación";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 173);
            label11.Name = "label11";
            label11.Size = new Size(172, 38);
            label11.TabIndex = 3;
            label11.Text = "Probabilidad";
            label11.Click += label11_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 125);
            label9.Name = "label9";
            label9.Size = new Size(147, 38);
            label9.TabIndex = 2;
            label9.Text = "Exposición";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 75);
            label8.Name = "label8";
            label8.Size = new Size(187, 38);
            label8.TabIndex = 1;
            label8.Text = "Consecuencia";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gray;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 15);
            label7.Name = "label7";
            label7.Size = new Size(256, 41);
            label7.TabIndex = 0;
            label7.Text = "Evaluación Mosler";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabHistorial);
            tabControl1.Location = new Point(23, 37);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(572, 525);
            tabControl1.TabIndex = 0;
            // 
            // tabHistorial
            // 
            tabHistorial.Controls.Add(btnCargarHistorial);
            tabHistorial.Controls.Add(dgvHistorial);
            tabHistorial.Location = new Point(4, 29);
            tabHistorial.Name = "tabHistorial";
            tabHistorial.Size = new Size(564, 492);
            tabHistorial.TabIndex = 2;
            tabHistorial.Text = "Historial";
            tabHistorial.UseVisualStyleBackColor = true;
            // 
            // btnCargarHistorial
            // 
            btnCargarHistorial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarHistorial.Location = new Point(30, 38);
            btnCargarHistorial.Name = "btnCargarHistorial";
            btnCargarHistorial.Size = new Size(145, 48);
            btnCargarHistorial.TabIndex = 1;
            btnCargarHistorial.Text = "Cargar Datos";
            btnCargarHistorial.UseVisualStyleBackColor = true;
            btnCargarHistorial.Click += btnCargarHistorial_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(19, 110);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(525, 357);
            dgvHistorial.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 574);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudF).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudV).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudA).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudP).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudE).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudC).EndInit();
            tabControl1.ResumeLayout(false);
            tabHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private Label label5;
        private Button btnIrEvaluacion;
        private RichTextBox rtbDescripcion;
        private TextBox txtResponsable;
        private TextBox txtNombre;
        private TextBox txtID;
        private ComboBox cmbArea;
        private Label label6;
        private Label Responsable;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TabControl tabControl1;
        private Label label7;
        private Label label8;
        private Label label12;
        private Label label13;
        private Label label10;
        private Label label11;
        private Label label9;
        private NumericUpDown nudC;
        private NumericUpDown nudF;
        private NumericUpDown nudV;
        private NumericUpDown nudA;
        private NumericUpDown nudP;
        private NumericUpDown nudE;
        private Button btnCalcular;
        private Label label14;
        private Label label15;
        private TextBox txtResultado;
        private TextBox txtNivel;
        private Button btnGuardar;
        private TabPage tabHistorial;
        private DataGridView dgvHistorial;
        private Button btnCargarHistorial;
    }
}
