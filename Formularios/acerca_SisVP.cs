using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Formularios
{
    public partial class acerca_SisVP : Form
    {
        public acerca_SisVP()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnk_actualizaciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("No hay actualizaciones disponibles en este momento.", "Actualizaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void link_whatsapp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string numero = "+59176492034";
            string mensaje = Uri.EscapeDataString("Hola, necesito asistencia con el sistema SisVP.");
            string url = $"https://wa.me/{numero}?text={mensaje}";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
