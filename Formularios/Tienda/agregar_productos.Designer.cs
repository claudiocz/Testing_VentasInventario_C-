namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA
{
    partial class agregar_productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregar_productos));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btn_limpiar = new Button();
            btn_agregar = new Button();
            txt_tipo = new TextBox();
            txt_modelo = new TextBox();
            txt_cantidad = new TextBox();
            txt_precio = new TextBox();
            txt_ubicacion = new TextBox();
            txt_marca = new TextBox();
            txt_nombre = new TextBox();
            txt_id = new TextBox();
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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1135, 109);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 22F);
            label1.Location = new Point(443, 35);
            label1.Name = "label1";
            label1.Size = new Size(304, 35);
            label1.TabIndex = 1;
            label1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(btn_limpiar);
            panel2.Controls.Add(btn_agregar);
            panel2.Controls.Add(txt_tipo);
            panel2.Controls.Add(txt_modelo);
            panel2.Controls.Add(txt_cantidad);
            panel2.Controls.Add(txt_precio);
            panel2.Controls.Add(txt_ubicacion);
            panel2.Controls.Add(txt_marca);
            panel2.Controls.Add(txt_nombre);
            panel2.Controls.Add(txt_id);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(1135, 520);
            panel2.TabIndex = 1;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.None;
            btn_limpiar.BackColor = Color.Red;
            btn_limpiar.Font = new Font("Tw Cen MT Condensed Extra Bold", 12F);
            btn_limpiar.Location = new Point(799, 440);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(89, 44);
            btn_limpiar.TabIndex = 17;
            btn_limpiar.Text = "CANCELAR";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Anchor = AnchorStyles.None;
            btn_agregar.BackColor = Color.FromArgb(0, 192, 0);
            btn_agregar.Font = new Font("Tw Cen MT Condensed Extra Bold", 12F);
            btn_agregar.Location = new Point(188, 440);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(89, 44);
            btn_agregar.TabIndex = 16;
            btn_agregar.Text = "AGREGAR";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // txt_tipo
            // 
            txt_tipo.Anchor = AnchorStyles.None;
            txt_tipo.Location = new Point(188, 281);
            txt_tipo.Name = "txt_tipo";
            txt_tipo.Size = new Size(189, 23);
            txt_tipo.TabIndex = 15;
            // 
            // txt_modelo
            // 
            txt_modelo.Anchor = AnchorStyles.None;
            txt_modelo.Location = new Point(725, 72);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(163, 23);
            txt_modelo.TabIndex = 14;
            // 
            // txt_cantidad
            // 
            txt_cantidad.Anchor = AnchorStyles.None;
            txt_cantidad.Location = new Point(725, 281);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(163, 23);
            txt_cantidad.TabIndex = 13;
            // 
            // txt_precio
            // 
            txt_precio.Anchor = AnchorStyles.None;
            txt_precio.Location = new Point(725, 180);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(163, 23);
            txt_precio.TabIndex = 12;
            // 
            // txt_ubicacion
            // 
            txt_ubicacion.Anchor = AnchorStyles.None;
            txt_ubicacion.Location = new Point(725, 364);
            txt_ubicacion.Name = "txt_ubicacion";
            txt_ubicacion.Size = new Size(163, 23);
            txt_ubicacion.TabIndex = 11;
            // 
            // txt_marca
            // 
            txt_marca.Anchor = AnchorStyles.None;
            txt_marca.Location = new Point(188, 364);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(189, 23);
            txt_marca.TabIndex = 10;
            // 
            // txt_nombre
            // 
            txt_nombre.Anchor = AnchorStyles.None;
            txt_nombre.Location = new Point(188, 180);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(189, 23);
            txt_nombre.TabIndex = 9;
            // 
            // txt_id
            // 
            txt_id.Anchor = AnchorStyles.None;
            txt_id.Enabled = false;
            txt_id.Location = new Point(188, 72);
            txt_id.Name = "txt_id";
            txt_id.PlaceholderText = "AUTOMÁTICO";
            txt_id.Size = new Size(189, 23);
            txt_id.TabIndex = 8;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F);
            label9.Location = new Point(725, 324);
            label9.Name = "label9";
            label9.Size = new Size(114, 28);
            label9.TabIndex = 7;
            label9.Text = "UBICACIÓN";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F);
            label8.Location = new Point(725, 229);
            label8.Name = "label8";
            label8.Size = new Size(107, 28);
            label8.TabIndex = 6;
            label8.Text = "CANTIDAD";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F);
            label7.Location = new Point(725, 124);
            label7.Name = "label7";
            label7.Size = new Size(77, 28);
            label7.TabIndex = 5;
            label7.Text = "PRECIO";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F);
            label6.Location = new Point(725, 41);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 4;
            label6.Text = "MODELO";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F);
            label5.Location = new Point(188, 324);
            label5.Name = "label5";
            label5.Size = new Size(79, 28);
            label5.TabIndex = 3;
            label5.Text = "MARCA";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F);
            label4.Location = new Point(188, 229);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 2;
            label4.Text = "TIPO";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F);
            label3.Location = new Point(188, 124);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 1;
            label3.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F);
            label2.Location = new Point(188, 41);
            label2.Name = "label2";
            label2.Size = new Size(32, 28);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // agregar_productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 629);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "agregar_productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AGREGAR PRODUCTOS";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private TextBox txt_tipo;
        private TextBox txt_modelo;
        private TextBox txt_cantidad;
        private TextBox txt_precio;
        private TextBox txt_ubicacion;
        private TextBox txt_marca;
        private TextBox txt_nombre;
        private TextBox txt_id;
        private Button btn_limpiar;
        private Button btn_agregar;
    }
}