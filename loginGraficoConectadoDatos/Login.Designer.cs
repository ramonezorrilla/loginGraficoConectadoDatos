namespace loginGraficoConectadoDatos
{
    partial class Login
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
            btnaceptar = new Button();
            txtusuario = new TextBox();
            txtclave = new TextBox();
            lblusuario = new Label();
            lblclave = new Label();
            SuspendLayout();
            // 
            // btnaceptar
            // 
            btnaceptar.Location = new Point(346, 248);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(75, 23);
            btnaceptar.TabIndex = 0;
            btnaceptar.Text = "ACEPTAR";
            btnaceptar.UseVisualStyleBackColor = true;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(444, 106);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(100, 23);
            txtusuario.TabIndex = 1;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(444, 159);
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(100, 23);
            txtclave.TabIndex = 2;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(336, 114);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(56, 15);
            lblusuario.TabIndex = 3;
            lblusuario.Text = "USUARIO";
            // 
            // lblclave
            // 
            lblclave.AutoSize = true;
            lblclave.Location = new Point(336, 167);
            lblclave.Name = "lblclave";
            lblclave.Size = new Size(84, 15);
            lblclave.TabIndex = 4;
            lblclave.Text = "CONTRASEÑA";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblclave);
            Controls.Add(lblusuario);
            Controls.Add(txtclave);
            Controls.Add(txtusuario);
            Controls.Add(btnaceptar);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnaceptar;
        private TextBox txtusuario;
        private TextBox txtclave;
        private Label lblusuario;
        private Label lblclave;
    }
}
