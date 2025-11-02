namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Formularios
{
    partial class acerca_SisVP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acerca_SisVP));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lnk_actualizaciones = new LinkLabel();
            label4 = new Label();
            link_whatsapp = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(49, 257);
            label1.Name = "label1";
            label1.Size = new Size(135, 24);
            label1.TabIndex = 0;
            label1.Text = "CONTACTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(138, 477);
            label2.Name = "label2";
            label2.Size = new Size(115, 24);
            label2.TabIndex = 1;
            label2.Text = "SisVP 2025";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(49, 38);
            label3.Name = "label3";
            label3.Size = new Size(75, 24);
            label3.TabIndex = 2;
            label3.Text = "AYUDA";
            // 
            // lnk_actualizaciones
            // 
            lnk_actualizaciones.AutoSize = true;
            lnk_actualizaciones.Font = new Font("Arial", 10F);
            lnk_actualizaciones.Location = new Point(49, 177);
            lnk_actualizaciones.Name = "lnk_actualizaciones";
            lnk_actualizaciones.Size = new Size(245, 19);
            lnk_actualizaciones.TabIndex = 3;
            lnk_actualizaciones.TabStop = true;
            lnk_actualizaciones.Text = "BUSCAR ACTUALIZACIONES...";
            lnk_actualizaciones.LinkClicked += lnk_actualizaciones_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F);
            label4.Location = new Point(49, 110);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 4;
            label4.Text = "VERSIÓN 1.0";
            // 
            // link_whatsapp
            // 
            link_whatsapp.AutoSize = true;
            link_whatsapp.Font = new Font("Arial", 10F);
            link_whatsapp.Location = new Point(49, 322);
            link_whatsapp.Name = "link_whatsapp";
            link_whatsapp.Size = new Size(100, 19);
            link_whatsapp.TabIndex = 5;
            link_whatsapp.TabStop = true;
            link_whatsapp.Text = "WHATSAPP";
            link_whatsapp.LinkClicked += link_whatsapp_LinkClicked;
            // 
            // acerca_SisVP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 510);
            Controls.Add(link_whatsapp);
            Controls.Add(label4);
            Controls.Add(lnk_actualizaciones);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "acerca_SisVP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SisVP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel lnk_actualizaciones;
        private Label label4;
        private LinkLabel link_whatsapp;
    }
}