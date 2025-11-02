namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA
{
    partial class panel_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panel_usuario));
            panel1 = new Panel();
            panel3 = new Panel();
            data_productos = new DataGridView();
            panel2 = new Panel();
            btn_editar = new Button();
            btn_eliminar = new Button();
            btn_venta = new Button();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            introducciónToolStripMenuItem = new ToolStripMenuItem();
            acercaDeSisIVPToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            label2 = new Label();
            cbx_tipo = new ComboBox();
            cbx_marca = new ComboBox();
            btn_buscar = new Button();
            txt_buscar = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_productos).BeginInit();
            panel2.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 736);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(data_productos);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 107);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1280, 629);
            panel3.TabIndex = 10;
            // 
            // data_productos
            // 
            data_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_productos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            data_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_productos.Dock = DockStyle.Fill;
            data_productos.Location = new Point(0, 0);
            data_productos.Margin = new Padding(3, 4, 3, 4);
            data_productos.Name = "data_productos";
            data_productos.RowHeadersWidth = 51;
            data_productos.Size = new Size(1280, 629);
            data_productos.TabIndex = 2;
            data_productos.CellContentClick += data_productos_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_editar);
            panel2.Controls.Add(btn_eliminar);
            panel2.Controls.Add(btn_venta);
            panel2.Controls.Add(menuStrip2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cbx_tipo);
            panel2.Controls.Add(cbx_marca);
            panel2.Controls.Add(btn_buscar);
            panel2.Controls.Add(txt_buscar);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1280, 107);
            panel2.TabIndex = 9;
            // 
            // btn_editar
            // 
            btn_editar.BackgroundImage = (Image)resources.GetObject("btn_editar.BackgroundImage");
            btn_editar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_editar.Location = new Point(955, 13);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(78, 83);
            btn_editar.TabIndex = 19;
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackgroundImage = (Image)resources.GetObject("btn_eliminar.BackgroundImage");
            btn_eliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_eliminar.Location = new Point(1074, 13);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(78, 83);
            btn_eliminar.TabIndex = 18;
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_venta
            // 
            btn_venta.BackgroundImage = (Image)resources.GetObject("btn_venta.BackgroundImage");
            btn_venta.BackgroundImageLayout = ImageLayout.Zoom;
            btn_venta.Location = new Point(1190, 13);
            btn_venta.Margin = new Padding(3, 4, 3, 4);
            btn_venta.Name = "btn_venta";
            btn_venta.Size = new Size(78, 83);
            btn_venta.TabIndex = 17;
            btn_venta.UseVisualStyleBackColor = true;
            btn_venta.Click += btn_venta_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem3, toolStripMenuItem6, toolStripMenuItem8, ayudaToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(7, 3, 0, 3);
            menuStrip2.Size = new Size(531, 30);
            menuStrip2.TabIndex = 16;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(68, 24);
            toolStripMenuItem1.Text = "Tienda";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(224, 26);
            toolStripMenuItem2.Text = "Agregar";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem4, toolStripMenuItem5 });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(44, 24);
            toolStripMenuItem3.Text = "Ver";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(208, 26);
            toolStripMenuItem4.Text = "Inventario";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(208, 26);
            toolStripMenuItem5.Text = "Detalles de Venta";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem7 });
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(85, 24);
            toolStripMenuItem6.Text = "Opciones";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(226, 26);
            toolStripMenuItem7.Text = "Cambiar Contraseña";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(110, 24);
            toolStripMenuItem8.Text = "Cerrar Sesion";
            toolStripMenuItem8.Click += toolStripMenuItem8_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { introducciónToolStripMenuItem, acercaDeSisIVPToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // introducciónToolStripMenuItem
            // 
            introducciónToolStripMenuItem.Name = "introducciónToolStripMenuItem";
            introducciónToolStripMenuItem.Size = new Size(201, 26);
            introducciónToolStripMenuItem.Text = "Introducción";
            // 
            // acercaDeSisIVPToolStripMenuItem
            // 
            acercaDeSisIVPToolStripMenuItem.Name = "acercaDeSisIVPToolStripMenuItem";
            acercaDeSisIVPToolStripMenuItem.Size = new Size(201, 26);
            acercaDeSisIVPToolStripMenuItem.Text = "Acerca de SisIVP";
            acercaDeSisIVPToolStripMenuItem.Click += acercaDeSisIVPToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(688, 56);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 15;
            label3.Text = "MARCA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 56);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 14;
            label2.Text = "TIPO";
            // 
            // cbx_tipo
            // 
            cbx_tipo.FormattingEnabled = true;
            cbx_tipo.Location = new Point(499, 52);
            cbx_tipo.Margin = new Padding(3, 4, 3, 4);
            cbx_tipo.Name = "cbx_tipo";
            cbx_tipo.Size = new Size(181, 28);
            cbx_tipo.TabIndex = 13;
            cbx_tipo.SelectedIndexChanged += cbx_tipo_SelectedIndexChanged;
            // 
            // cbx_marca
            // 
            cbx_marca.FormattingEnabled = true;
            cbx_marca.Location = new Point(751, 51);
            cbx_marca.Margin = new Padding(3, 4, 3, 4);
            cbx_marca.Name = "cbx_marca";
            cbx_marca.Size = new Size(181, 28);
            cbx_marca.TabIndex = 12;
            cbx_marca.SelectedIndexChanged += cbx_marca_SelectedIndexChanged;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(365, 51);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(86, 31);
            btn_buscar.TabIndex = 11;
            btn_buscar.Text = "BUSCAR";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(133, 52);
            txt_buscar.Margin = new Padding(3, 4, 3, 4);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.PlaceholderText = "ID, Nombre";
            txt_buscar.Size = new Size(222, 27);
            txt_buscar.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 56);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 9;
            label1.Text = "FILTRAR";
            // 
            // panel_usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 736);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "panel_usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BIENVENIDO";
            Load += panel_usuario_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_productos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private Label label3;
        private Label label2;
        private ComboBox cbx_tipo;
        private ComboBox cbx_marca;
        private Button btn_buscar;
        private TextBox txt_buscar;
        private Label label1;
        private Panel panel3;
        private DataGridView data_productos;
        private Button btn_venta;
        private Button btn_editar;
        private Button btn_eliminar;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem introducciónToolStripMenuItem;
        private ToolStripMenuItem acercaDeSisIVPToolStripMenuItem;
    }
}