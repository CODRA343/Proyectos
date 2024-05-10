namespace Laboratorio_007
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
            txtSueldo = new TextBox();
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            txtHorasExtras = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            cboTipoSeguro = new ComboBox();
            label5 = new Label();
            cboArea = new ComboBox();
            label6 = new Label();
            txtResultado = new TextBox();
            btnCrear = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(12, 91);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(111, 23);
            txtSueldo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Sueldo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 29);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(164, 23);
            txtCodigo.TabIndex = 6;
            txtCodigo.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Código";
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Location = new Point(267, 91);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(164, 23);
            txtHorasExtras.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 73);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "Horas Extras";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(267, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(306, 23);
            txtNombre.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(267, 11);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 9;
            label4.Text = "Nombre";
            // 
            // cboTipoSeguro
            // 
            cboTipoSeguro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoSeguro.FormattingEnabled = true;
            cboTipoSeguro.Items.AddRange(new object[] { "AFP", "SNP" });
            cboTipoSeguro.Location = new Point(640, 29);
            cboTipoSeguro.Name = "cboTipoSeguro";
            cboTipoSeguro.Size = new Size(121, 23);
            cboTipoSeguro.TabIndex = 11;
            cboTipoSeguro.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(640, 11);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 12;
            label5.Text = "Tipo Seguro";
            label5.Click += label5_Click;
            // 
            // cboArea
            // 
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "Contabilidad", "Adminictración" });
            cboArea.Location = new Point(640, 91);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(121, 23);
            cboArea.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(640, 73);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 14;
            label6.Text = "Área";
            label6.Click += label6_Click_1;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 146);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(749, 212);
            txtResultado.TabIndex = 15;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(12, 384);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(143, 25);
            btnCrear.TabIndex = 16;
            btnCrear.Text = "Crear Objeto";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(170, 385);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(274, 23);
            btnMostrar.TabIndex = 17;
            btnMostrar.Text = "Mostrar Información del Objeto ";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(547, 384);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 23);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button1_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(667, 384);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 23);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(txtResultado);
            Controls.Add(label6);
            Controls.Add(cboArea);
            Controls.Add(label5);
            Controls.Add(cboTipoSeguro);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(txtHorasExtras);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(txtSueldo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Planilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSueldo;
        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtHorasExtras;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private ComboBox cboTipoSeguro;
        private Label label5;
        private ComboBox cboArea;
        private Label label6;
        private TextBox txtResultado;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
