namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA
{
    partial class venta_carrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(venta_carrito));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btn_editar = new Button();
            btn_eliminar = new Button();
            clb_articulos = new CheckedListBox();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            button1 = new Button();
            btn_calular_cambio = new Button();
            lbl_cambio = new Label();
            txt_cambio = new TextBox();
            lbl_total = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cbx_tipo_pago = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            btn_cancelar = new Button();
            txt_correo = new TextBox();
            txt_celular = new TextBox();
            txt_nombre = new TextBox();
            txt_id = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1249, 353);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_editar);
            groupBox1.Controls.Add(btn_eliminar);
            groupBox1.Controls.Add(clb_articulos);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1222, 329);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ARTICULOS";
            // 
            // btn_editar
            // 
            btn_editar.Font = new Font("Arial Black", 12F);
            btn_editar.Location = new Point(1009, 269);
            btn_editar.Margin = new Padding(3, 4, 3, 4);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(143, 52);
            btn_editar.TabIndex = 2;
            btn_editar.Text = "EDITAR";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Arial Black", 12F);
            btn_eliminar.Location = new Point(119, 269);
            btn_eliminar.Margin = new Padding(3, 4, 3, 4);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(143, 52);
            btn_eliminar.TabIndex = 1;
            btn_eliminar.Text = "ELIMINAR";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // clb_articulos
            // 
            clb_articulos.Font = new Font("Arial", 12F);
            clb_articulos.FormattingEnabled = true;
            clb_articulos.Location = new Point(7, 64);
            clb_articulos.Margin = new Padding(3, 4, 3, 4);
            clb_articulos.Name = "clb_articulos";
            clb_articulos.Size = new Size(1207, 154);
            clb_articulos.TabIndex = 0;
            clb_articulos.SelectedIndexChanged += clb_articulos_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 353);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1249, 490);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btn_calular_cambio);
            groupBox2.Controls.Add(lbl_cambio);
            groupBox2.Controls.Add(txt_cambio);
            groupBox2.Controls.Add(lbl_total);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cbx_tipo_pago);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btn_cancelar);
            groupBox2.Controls.Add(txt_correo);
            groupBox2.Controls.Add(txt_celular);
            groupBox2.Controls.Add(txt_nombre);
            groupBox2.Controls.Add(txt_id);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(14, 8);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1222, 465);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "CLIENTE";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Arial Black", 12F);
            button1.Location = new Point(141, 379);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(143, 52);
            button1.TabIndex = 20;
            button1.Text = "VENDER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_calular_cambio
            // 
            btn_calular_cambio.BackgroundImage = (Image)resources.GetObject("btn_calular_cambio.BackgroundImage");
            btn_calular_cambio.BackgroundImageLayout = ImageLayout.Zoom;
            btn_calular_cambio.Image = (Image)resources.GetObject("btn_calular_cambio.Image");
            btn_calular_cambio.Location = new Point(1149, 222);
            btn_calular_cambio.Margin = new Padding(3, 4, 3, 4);
            btn_calular_cambio.Name = "btn_calular_cambio";
            btn_calular_cambio.Size = new Size(65, 33);
            btn_calular_cambio.TabIndex = 19;
            btn_calular_cambio.UseVisualStyleBackColor = true;
            btn_calular_cambio.Click += btn_calular_cambio_Click;
            // 
            // lbl_cambio
            // 
            lbl_cambio.AutoSize = true;
            lbl_cambio.Font = new Font("Segoe UI", 12F);
            lbl_cambio.Location = new Point(975, 281);
            lbl_cambio.Name = "lbl_cambio";
            lbl_cambio.Size = new Size(23, 28);
            lbl_cambio.TabIndex = 18;
            lbl_cambio.Text = "0";
            // 
            // txt_cambio
            // 
            txt_cambio.Font = new Font("Arial", 12F);
            txt_cambio.Location = new Point(1029, 225);
            txt_cambio.Margin = new Padding(3, 4, 3, 4);
            txt_cambio.Name = "txt_cambio";
            txt_cambio.Size = new Size(114, 30);
            txt_cambio.TabIndex = 17;
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Font = new Font("Segoe UI", 12F);
            lbl_total.Location = new Point(959, 384);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(23, 28);
            lbl_total.TabIndex = 16;
            lbl_total.Text = "0";
            lbl_total.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 12F);
            label9.Location = new Point(874, 385);
            label9.Name = "label9";
            label9.Size = new Size(85, 28);
            label9.TabIndex = 15;
            label9.Text = "TOTAL:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 12F);
            label8.Location = new Point(874, 281);
            label8.Name = "label8";
            label8.Size = new Size(102, 28);
            label8.TabIndex = 14;
            label8.Text = "CAMBIO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F);
            label7.Location = new Point(874, 227);
            label7.Name = "label7";
            label7.Size = new Size(161, 28);
            label7.TabIndex = 13;
            label7.Text = "INGRESE PAGO";
            // 
            // cbx_tipo_pago
            // 
            cbx_tipo_pago.Font = new Font("Arial", 12F);
            cbx_tipo_pago.FormattingEnabled = true;
            cbx_tipo_pago.Items.AddRange(new object[] { "DOLAR", "BOLIVIANOS" });
            cbx_tipo_pago.Location = new Point(867, 100);
            cbx_tipo_pago.Margin = new Padding(3, 4, 3, 4);
            cbx_tipo_pago.Name = "cbx_tipo_pago";
            cbx_tipo_pago.Size = new Size(161, 31);
            cbx_tipo_pago.TabIndex = 12;
            cbx_tipo_pago.Text = "SELECCIONE";
            cbx_tipo_pago.SelectedIndexChanged += cbx_tipo_pago_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F);
            label6.Location = new Point(874, 169);
            label6.Name = "label6";
            label6.Size = new Size(286, 28);
            label6.TabIndex = 11;
            label6.Text = "CALCULADORA DE CAMBIO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F);
            label5.Location = new Point(867, 48);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 10;
            label5.Text = "TIPO DE PAGO";
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(255, 128, 128);
            btn_cancelar.Font = new Font("Arial Black", 12F);
            btn_cancelar.Location = new Point(566, 379);
            btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(146, 52);
            btn_cancelar.TabIndex = 9;
            btn_cancelar.Text = "CANCELAR";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // txt_correo
            // 
            txt_correo.Font = new Font("Arial", 12F);
            txt_correo.Location = new Point(515, 277);
            txt_correo.Margin = new Padding(3, 4, 3, 4);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(197, 30);
            txt_correo.TabIndex = 7;
            // 
            // txt_celular
            // 
            txt_celular.Font = new Font("Arial", 12F);
            txt_celular.Location = new Point(515, 100);
            txt_celular.Margin = new Padding(3, 4, 3, 4);
            txt_celular.Name = "txt_celular";
            txt_celular.Size = new Size(197, 30);
            txt_celular.TabIndex = 6;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Arial", 12F);
            txt_nombre.Location = new Point(16, 277);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(267, 30);
            txt_nombre.TabIndex = 5;
            // 
            // txt_id
            // 
            txt_id.Font = new Font("Arial", 12F);
            txt_id.Location = new Point(16, 100);
            txt_id.Margin = new Padding(3, 4, 3, 4);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(267, 30);
            txt_id.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F);
            label4.Location = new Point(515, 191);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 3;
            label4.Text = "CORREO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F);
            label3.Location = new Point(515, 48);
            label3.Name = "label3";
            label3.Size = new Size(215, 28);
            label3.TabIndex = 2;
            label3.Text = "CELULAR/TELEFONO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F);
            label2.Location = new Point(16, 191);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F);
            label1.Location = new Point(16, 48);
            label1.Name = "label1";
            label1.Size = new Size(295, 28);
            label1.TabIndex = 0;
            label1.Text = "ID O CARNET DE IDENTIDAD";
            // 
            // venta_carrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 843);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "venta_carrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VENTAS";
            Load += venta_carrito_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private GroupBox groupBox2;
        private Button btn_cancelar;
        private TextBox txt_correo;
        private TextBox txt_celular;
        private TextBox txt_nombre;
        private TextBox txt_id;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_editar;
        private Button btn_eliminar;
        private CheckedListBox clb_articulos;
        private Label label7;
        private ComboBox cbx_tipo_pago;
        private Label label6;
        private Label label5;
        private Label lbl_cambio;
        private TextBox txt_cambio;
        private Label lbl_total;
        private Label label9;
        private Label label8;
        private Button btn_calular_cambio;
        private Button button1;
    }
}