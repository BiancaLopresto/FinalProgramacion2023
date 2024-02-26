namespace FinalProgramacion2023.Windows
{
    partial class frmCuadrilatero
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
            components = new System.ComponentModel.Container();
            gbxBordes = new GroupBox();
            rbPuntos = new RadioButton();
            rbRayas = new RadioButton();
            rbLineal = new RadioButton();
            cboRelleno = new ComboBox();
            label4 = new Label();
            btnCancelar = new Button();
            btnOK = new Button();
            txtLadoB = new TextBox();
            label2 = new Label();
            txtLadoA = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            gbxBordes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // gbxBordes
            // 
            gbxBordes.Controls.Add(rbPuntos);
            gbxBordes.Controls.Add(rbRayas);
            gbxBordes.Controls.Add(rbLineal);
            gbxBordes.Location = new Point(41, 144);
            gbxBordes.Name = "gbxBordes";
            gbxBordes.Size = new Size(284, 76);
            gbxBordes.TabIndex = 16;
            gbxBordes.TabStop = false;
            gbxBordes.Text = " Bordes ";
            // 
            // rbPuntos
            // 
            rbPuntos.AutoSize = true;
            rbPuntos.Location = new Point(179, 34);
            rbPuntos.Name = "rbPuntos";
            rbPuntos.Size = new Size(62, 19);
            rbPuntos.TabIndex = 2;
            rbPuntos.TabStop = true;
            rbPuntos.Text = "Puntos";
            rbPuntos.UseVisualStyleBackColor = true;
            // 
            // rbRayas
            // 
            rbRayas.AutoSize = true;
            rbRayas.Location = new Point(98, 34);
            rbRayas.Name = "rbRayas";
            rbRayas.Size = new Size(55, 19);
            rbRayas.TabIndex = 1;
            rbRayas.TabStop = true;
            rbRayas.Text = "Rayas";
            rbRayas.UseVisualStyleBackColor = true;
            // 
            // rbLineal
            // 
            rbLineal.AutoSize = true;
            rbLineal.Location = new Point(19, 34);
            rbLineal.Name = "rbLineal";
            rbLineal.Size = new Size(56, 19);
            rbLineal.TabIndex = 0;
            rbLineal.TabStop = true;
            rbLineal.Text = "Lineal";
            rbLineal.UseVisualStyleBackColor = true;
            // 
            // cboRelleno
            // 
            cboRelleno.FormattingEnabled = true;
            cboRelleno.Items.AddRange(new object[] { "Rojo", "Azul", "Verde" });
            cboRelleno.Location = new Point(101, 115);
            cboRelleno.Name = "cboRelleno";
            cboRelleno.Size = new Size(121, 23);
            cboRelleno.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 118);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 14;
            label4.Text = "Relleno:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(250, 229);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 61);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(41, 229);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 61);
            btnOK.TabIndex = 13;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(101, 51);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(100, 23);
            txtLadoB.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 54);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 7;
            label2.Text = "Lado B;";
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(101, 22);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(100, 23);
            txtLadoA.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 8;
            label1.Text = "Lado A:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // frmCuadrilatero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 313);
            Controls.Add(gbxBordes);
            Controls.Add(cboRelleno);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtLadoB);
            Controls.Add(label2);
            Controls.Add(txtLadoA);
            Controls.Add(label1);
            Name = "frmCuadrilatero";
            Text = "frmCuadrilatero";
            Load += frmCuadrilatero_Load;
            gbxBordes.ResumeLayout(false);
            gbxBordes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxBordes;
        private ComboBox cboRelleno;
        private Label label4;
        private Button btnCancelar;
        private Button btnOK;
        private TextBox txtLadoB;
        private Label label2;
        private TextBox txtLadoA;
        private Label label1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private RadioButton rbLineal;
        private RadioButton rbPuntos;
        private RadioButton rbRayas;
    }
}