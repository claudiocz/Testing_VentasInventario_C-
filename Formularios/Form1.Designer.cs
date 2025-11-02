namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA
{
    partial class login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            texbox_usuario = new TextBox();
            textbox_pass = new TextBox();
            bindingSource1 = new BindingSource(components);
            btn_ingresar = new Button();
            linklabel_recu = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // texbox_usuario
            // 
            texbox_usuario.Location = new Point(83, 145);
            texbox_usuario.Name = "texbox_usuario";
            texbox_usuario.PlaceholderText = "Usuario";
            texbox_usuario.Size = new Size(100, 23);
            texbox_usuario.TabIndex = 2;
            texbox_usuario.TextChanged += texbox_usuario_TextChanged;
            // 
            // textbox_pass
            // 
            textbox_pass.Location = new Point(83, 205);
            textbox_pass.Name = "textbox_pass";
            textbox_pass.PlaceholderText = "Contraseña";
            textbox_pass.Size = new Size(100, 23);
            textbox_pass.TabIndex = 3;
            textbox_pass.UseSystemPasswordChar = true;
            // 
            // btn_ingresar
            // 
            btn_ingresar.Location = new Point(94, 267);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(75, 23);
            btn_ingresar.TabIndex = 4;
            btn_ingresar.Text = "INGRESAR";
            btn_ingresar.UseVisualStyleBackColor = true;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // linklabel_recu
            // 
            linklabel_recu.AutoSize = true;
            linklabel_recu.Location = new Point(61, 328);
            linklabel_recu.Name = "linklabel_recu";
            linklabel_recu.Size = new Size(141, 15);
            linklabel_recu.TabIndex = 5;
            linklabel_recu.TabStop = true;
            linklabel_recu.Text = "¿Olvidaste tu contraseña?";
            linklabel_recu.LinkClicked += linklabel_recu_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 352);
            Controls.Add(pictureBox1);
            Controls.Add(linklabel_recu);
            Controls.Add(btn_ingresar);
            Controls.Add(textbox_pass);
            Controls.Add(texbox_usuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox texbox_usuario;
        private TextBox textbox_pass;
        private BindingSource bindingSource1;
        private Button btn_ingresar;
        private LinkLabel linklabel_recu;
        private PictureBox pictureBox1;
    }
}
