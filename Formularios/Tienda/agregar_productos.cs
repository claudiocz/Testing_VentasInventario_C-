using GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Datos;
using GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA
{
    public partial class agregar_productos : Form
    {
        public agregar_productos()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación básica de campos
                if (string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                    string.IsNullOrWhiteSpace(txt_tipo.Text) ||
                    string.IsNullOrWhiteSpace(txt_marca.Text) ||
                    string.IsNullOrWhiteSpace(txt_modelo.Text) ||
                    string.IsNullOrWhiteSpace(txt_precio.Text) ||
                    string.IsNullOrWhiteSpace(txt_cantidad.Text) ||
                    string.IsNullOrWhiteSpace(txt_ubicacion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }
                // Conversión segura de datos
                float precio;
                int cantidad;

                if (!float.TryParse(txt_precio.Text, out precio))
                {
                    MessageBox.Show("Precio inválido.");
                    return;
                }
                if (!int.TryParse(txt_cantidad.Text, out cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Cantidad inválida.");
                    return;
                }
                // Crear objeto producto
                Producto nuevo = new Producto(
                    txt_nombre.Text,
                    txt_tipo.Text,
                    txt_marca.Text,
                    txt_modelo.Text,
                    precio,
                    cantidad,
                    txt_ubicacion.Text
                );
                // Conexión
                ConexionPostgreSQL conexion = new ConexionPostgreSQL();
                var conn = conexion.ObtenerConexion();

                // Registrar producto y obtener ID
                int productoId = nuevo.registrar(conn);

                if (productoId > 0)
                {
                    // Crear y registrar movimiento
                    Movimiento movimiento = new Movimiento(
                        productoId,
                        "entrada",
                        DateTime.Today,
                        cantidad,
                        "Ingreso de " + txt_nombre.Text
                    );

                    if (movimiento.registrar(conn))
                    {
                        MessageBox.Show("✅ Producto y movimiento registrados con éxito.");
                        txt_nombre.Clear(); txt_ubicacion.Focus();
                        txt_tipo.Clear(); txt_cantidad.Focus();
                        txt_marca.Clear(); txt_precio.Focus();
                        txt_modelo.Clear(); txt_modelo.Focus();
                        txt_precio.Clear(); txt_marca.Focus();
                        txt_cantidad.Clear(); txt_tipo.Focus();
                        txt_ubicacion.Clear(); txt_nombre.Focus();
                    }
                    else
                    {
                        MessageBox.Show("⚠️ Producto registrado, pero falló el registro de movimiento.");
                    }
                }
                else
                {
                    MessageBox.Show("❌ Error al registrar el producto.");
                }

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
            panel_usuario? panel = Application.OpenForms["panel_usuario"] as panel_usuario;
            panel?.ActualizarPanel();
        }
    }
}
