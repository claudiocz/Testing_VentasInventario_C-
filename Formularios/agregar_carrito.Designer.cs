namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA
{
    partial class agregar_carrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregar_carrito));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            nud_cantidad = new NumericUpDown();
            lb_cantidad = new Label();
            lb_precio = new Label();
            lb_modelo = new Label();
            lb_marca = new Label();
            lb_tipo = new Label();
            lb_nombre = new Label();
            lb_id = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 85);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 15F);
            label1.Location = new Point(88, 30);
            label1.Name = "label1";
            label1.Size = new Size(435, 24);
            label1.TabIndex = 0;
            label1.Text = "VERIFIQUE QUE LOS DATOS SEAN CORRECTOS";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(btn_cancelar);
            panel2.Controls.Add(btn_agregar);
            panel2.Controls.Add(nud_cantidad);
            panel2.Controls.Add(lb_cantidad);
            panel2.Controls.Add(lb_precio);
            panel2.Controls.Add(lb_modelo);
            panel2.Controls.Add(lb_marca);
            panel2.Controls.Add(lb_tipo);
            panel2.Controls.Add(lb_nombre);
            panel2.Controls.Add(lb_id);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(637, 406);
            panel2.TabIndex = 1;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Red;
            btn_cancelar.Font = new Font("Arial", 12F);
            btn_cancelar.Location = new Point(413, 358);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(110, 36);
            btn_cancelar.TabIndex = 17;
            btn_cancelar.Text = "CANCELAR";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(0, 192, 0);
            btn_agregar.Font = new Font("Arial", 12F);
            btn_agregar.Location = new Point(137, 358);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(110, 36);
            btn_agregar.TabIndex = 16;
            btn_agregar.Text = "AGREGAR";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // nud_cantidad
            // 
            nud_cantidad.Font = new Font("Arial", 12F);
            nud_cantidad.Location = new Point(384, 307);
            nud_cantidad.Name = "nud_cantidad";
            nud_cantidad.Size = new Size(66, 26);
            nud_cantidad.TabIndex = 15;
            // 
            // lb_cantidad
            // 
            lb_cantidad.AutoSize = true;
            lb_cantidad.Font = new Font("Arial", 12F);
            lb_cantidad.Location = new Point(384, 238);
            lb_cantidad.Name = "lb_cantidad";
            lb_cantidad.Size = new Size(59, 18);
            lb_cantidad.TabIndex = 14;
            lb_cantidad.Text = "label16";
            // 
            // lb_precio
            // 
            lb_precio.AutoSize = true;
            lb_precio.Font = new Font("Arial", 12F);
            lb_precio.Location = new Point(384, 163);
            lb_precio.Name = "lb_precio";
            lb_precio.Size = new Size(59, 18);
            lb_precio.TabIndex = 13;
            lb_precio.Text = "label15";
            // 
            // lb_modelo
            // 
            lb_modelo.AutoSize = true;
            lb_modelo.Font = new Font("Arial", 12F);
            lb_modelo.Location = new Point(384, 82);
            lb_modelo.Name = "lb_modelo";
            lb_modelo.Size = new Size(59, 18);
            lb_modelo.TabIndex = 12;
            lb_modelo.Text = "label14";
            // 
            // lb_marca
            // 
            lb_marca.AutoSize = true;
            lb_marca.Font = new Font("Arial", 12F);
            lb_marca.Location = new Point(43, 315);
            lb_marca.Name = "lb_marca";
            lb_marca.Size = new Size(59, 18);
            lb_marca.TabIndex = 11;
            lb_marca.Text = "label13";
            // 
            // lb_tipo
            // 
            lb_tipo.AutoSize = true;
            lb_tipo.Font = new Font("Arial", 12F);
            lb_tipo.Location = new Point(43, 238);
            lb_tipo.Name = "lb_tipo";
            lb_tipo.Size = new Size(59, 18);
            lb_tipo.TabIndex = 10;
            lb_tipo.Text = "label12";
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.Font = new Font("Arial", 12F);
            lb_nombre.Location = new Point(43, 163);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(58, 18);
            lb_nombre.TabIndex = 9;
            lb_nombre.Text = "label11";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Arial", 12F);
            lb_id.Location = new Point(43, 82);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(59, 18);
            lb_id.TabIndex = 8;
            lb_id.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 12F);
            label9.Location = new Point(350, 271);
            label9.Name = "label9";
            label9.Size = new Size(276, 23);
            label9.TabIndex = 7;
            label9.Text = "INGRESE CANTIDAD A LLEVAR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 12F);
            label8.Location = new Point(350, 198);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 6;
            label8.Text = "CANTIDAD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 12F);
            label7.Location = new Point(350, 115);
            label7.Name = "label7";
            label7.Size = new Size(77, 23);
            label7.TabIndex = 5;
            label7.Text = "PRECIO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 12F);
            label6.Location = new Point(350, 32);
            label6.Name = "label6";
            label6.Size = new Size(86, 23);
            label6.TabIndex = 4;
            label6.Text = "MODELO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 12F);
            label5.Location = new Point(9, 271);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 3;
            label5.Text = "MARCA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 12F);
            label4.Location = new Point(9, 198);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 2;
            label4.Text = "TIPO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F);
            label3.Location = new Point(9, 115);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 1;
            label3.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F);
            label2.Location = new Point(9, 32);
            label2.Name = "label2";
            label2.Size = new Size(28, 23);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // agregar_carrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 491);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "agregar_carrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AGREGAR AL CARRITO";
            Load += agregar_carrito_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_cantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown nud_cantidad;
        private Label lb_cantidad;
        private Label lb_precio;
        private Label lb_modelo;
        private Label lb_marca;
        private Label lb_tipo;
        private Label lb_nombre;
        private Label lb_id;
        private Button btn_cancelar;
        private Button btn_agregar;
    }
}