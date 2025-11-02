namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Formularios.Ver
{
    partial class Detalles_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalles_Venta));
            panel1 = new Panel();
            btn_editar = new Button();
            lbl_total_dia = new Label();
            lbl_total_mes = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_buscar = new Button();
            txt_buscar = new TextBox();
            label1 = new Label();
            data_clientes = new DataGridView();
            data_detalles = new DataGridView();
            data_ventas = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_clientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_detalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_ventas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btn_editar);
            panel1.Controls.Add(lbl_total_dia);
            panel1.Controls.Add(lbl_total_mes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_buscar);
            panel1.Controls.Add(txt_buscar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1460, 133);
            panel1.TabIndex = 1;
            // 
            // btn_editar
            // 
            btn_editar.BackgroundImage = (Image)resources.GetObject("btn_editar.BackgroundImage");
            btn_editar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_editar.Location = new Point(426, 25);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(78, 83);
            btn_editar.TabIndex = 26;
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // lbl_total_dia
            // 
            lbl_total_dia.AutoSize = true;
            lbl_total_dia.Location = new Point(1283, 32);
            lbl_total_dia.Name = "lbl_total_dia";
            lbl_total_dia.Size = new Size(17, 20);
            lbl_total_dia.TabIndex = 24;
            lbl_total_dia.Text = "0";
            // 
            // lbl_total_mes
            // 
            lbl_total_mes.AutoSize = true;
            lbl_total_mes.Location = new Point(1283, 83);
            lbl_total_mes.Name = "lbl_total_mes";
            lbl_total_mes.Size = new Size(17, 20);
            lbl_total_mes.TabIndex = 23;
            lbl_total_mes.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1126, 83);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 22;
            label3.Text = "GANACIAS DEL MES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1126, 32);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 21;
            label2.Text = "GANANCIAS DEL DIA";
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(319, 51);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(86, 31);
            btn_buscar.TabIndex = 18;
            btn_buscar.Text = "BUSCAR";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(87, 52);
            txt_buscar.Margin = new Padding(3, 4, 3, 4);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.PlaceholderText = "ID, Nombre";
            txt_buscar.Size = new Size(222, 27);
            txt_buscar.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 56);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 16;
            label1.Text = "FILTRAR";
            // 
            // data_clientes
            // 
            data_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_clientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            data_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_clientes.Dock = DockStyle.Left;
            data_clientes.Location = new Point(0, 133);
            data_clientes.Margin = new Padding(3, 4, 3, 4);
            data_clientes.Name = "data_clientes";
            data_clientes.RowHeadersWidth = 51;
            data_clientes.Size = new Size(486, 618);
            data_clientes.TabIndex = 4;
            data_clientes.CellClick += data_clientes_CellContentClick;
            data_clientes.CellContentClick += data_clientes_CellContentClick;
            // 
            // data_detalles
            // 
            data_detalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_detalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            data_detalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_detalles.Dock = DockStyle.Right;
            data_detalles.Location = new Point(1045, 133);
            data_detalles.Margin = new Padding(3, 4, 3, 4);
            data_detalles.Name = "data_detalles";
            data_detalles.RowHeadersWidth = 51;
            data_detalles.Size = new Size(415, 618);
            data_detalles.TabIndex = 6;
            // 
            // data_ventas
            // 
            data_ventas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_ventas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            data_ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_ventas.Dock = DockStyle.Fill;
            data_ventas.Location = new Point(486, 133);
            data_ventas.Margin = new Padding(3, 4, 3, 4);
            data_ventas.Name = "data_ventas";
            data_ventas.RowHeadersWidth = 51;
            data_ventas.Size = new Size(559, 618);
            data_ventas.TabIndex = 7;
            data_ventas.CellClick += data_ventas_CellContentClick;
            data_ventas.CellContentClick += data_ventas_CellContentClick;
            // 
            // Detalles_Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 751);
            Controls.Add(data_ventas);
            Controls.Add(data_detalles);
            Controls.Add(data_clientes);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Detalles_Venta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalles de Ventas";
            Load += Detalles_Venta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_clientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_detalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_ventas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_buscar;
        private TextBox txt_buscar;
        private Label label1;
        private DataGridView data_clientes;
        private DataGridView data_detalles;
        private DataGridView data_ventas;
        private Button button1;
        private Label label5;
        private Label lbl_total_mes;
        private Label lbl_total_dia;
        private Label label3;
        private Label label2;
        private Button btn_editar;
    }
}