namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Formularios.Ver
{
    partial class editar_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editar_cliente));
            panel1 = new Panel();
            txt_correo = new TextBox();
            txt_celular = new TextBox();
            txt_nombre = new TextBox();
            txt_id = new TextBox();
            btn_cancelar = new Button();
            btn_actualizar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_correo);
            panel1.Controls.Add(txt_celular);
            panel1.Controls.Add(txt_nombre);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(btn_cancelar);
            panel1.Controls.Add(btn_actualizar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 706);
            panel1.TabIndex = 0;
            // 
            // txt_correo
            // 
            txt_correo.Font = new Font("Arial", 12F);
            txt_correo.Location = new Point(449, 382);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(125, 30);
            txt_correo.TabIndex = 21;
            // 
            // txt_celular
            // 
            txt_celular.Font = new Font("Arial", 12F);
            txt_celular.Location = new Point(449, 251);
            txt_celular.Name = "txt_celular";
            txt_celular.Size = new Size(125, 30);
            txt_celular.TabIndex = 20;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Arial", 12F);
            txt_nombre.Location = new Point(127, 382);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(125, 30);
            txt_nombre.TabIndex = 19;
            // 
            // txt_id
            // 
            txt_id.Font = new Font("Arial", 12F);
            txt_id.Location = new Point(127, 251);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(125, 30);
            txt_id.TabIndex = 18;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Arial", 12F);
            btn_cancelar.Location = new Point(449, 536);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(139, 32);
            btn_cancelar.TabIndex = 17;
            btn_cancelar.Text = "CANCELAR";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Font = new Font("Arial", 12F);
            btn_actualizar.Location = new Point(127, 536);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(139, 42);
            btn_actualizar.TabIndex = 16;
            btn_actualizar.Text = "ACTUALIZAR";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(190, 46);
            label5.Name = "label5";
            label5.Size = new Size(384, 52);
            label5.TabIndex = 15;
            label5.Text = "DATOS DE CLIENTE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(449, 197);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 14;
            label4.Text = "CELULAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(449, 324);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 13;
            label3.Text = "CORREO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(127, 324);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 12;
            label2.Text = "NOMBRE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(127, 197);
            label1.Name = "label1";
            label1.Size = new Size(30, 23);
            label1.TabIndex = 11;
            label1.Text = "ID";
            // 
            // editar_cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 706);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "editar_cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDITAR CLIENTE";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_correo;
        private TextBox txt_celular;
        private TextBox txt_nombre;
        private TextBox txt_id;
        private Button btn_cancelar;
        private Button btn_actualizar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}