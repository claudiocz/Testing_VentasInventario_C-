using GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Datos;
using GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Modelos;
using Npgsql;
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
    public partial class actualizar_productos : Form
    {
        private int? idProducto = null;
        public actualizar_productos(int? idProducto = null)
        {
            InitializeComponent();
            this.idProducto = idProducto;
            if (idProducto.HasValue)
            {
                CargarDatosProducto(idProducto.Value);
            }
        }
        private void CargarDatosProducto(int id)
        {
            ConexionPostgreSQL conexion = new ConexionPostgreSQL();
            using (var conn = conexion.ObtenerConexion())
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open(); // ✅ solo abre si está cerrada

                string consulta = "SELECT nombre, tipo, marca, modelo, precio, cantidad, ubicacion FROM producto WHERE id = @id";
                using (var comando = new NpgsqlCommand(consulta, conn))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_nombre.Text = reader.GetString(0);
                            txt_tipo.Text = reader.GetString(1);
                            txt_marca.Text = reader.GetString(2);
                            txt_modelo.Text = reader.GetString(3);
                            txt_precio.Text = reader.GetDecimal(4).ToString();
                            txt_cantidad.Text = reader.GetInt32(5).ToString();
                            txt_ubicacion.Text = reader.GetString(6);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto con ese ID.");
                        }
                    }
                }
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Validación básica de campos obligatorios
            if (string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_tipo.Text) ||
                string.IsNullOrWhiteSpace(txt_marca.Text) ||
                string.IsNullOrWhiteSpace(txt_modelo.Text) ||
                string.IsNullOrWhiteSpace(txt_precio.Text) ||
                string.IsNullOrWhiteSpace(txt_cantidad.Text) ||
                string.IsNullOrWhiteSpace(txt_ubicacion.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de guardar.");
                return;
            }

            // Conversión segura de precio y cantidad
            if (!decimal.TryParse(txt_precio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return;
            }

            if (!int.TryParse(txt_cantidad.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
                return;
            }

            try
            {
                ConexionPostgreSQL conexion = new ConexionPostgreSQL();
                using (var conn = conexion.ObtenerConexion())
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string consulta = idProducto.HasValue
                        ? "UPDATE producto SET nombre = @nombre, tipo = @tipo, marca = @marca, modelo = @modelo, precio = @precio, cantidad = @cantidad, ubicacion = @ubicacion WHERE id = @id"
                        : "INSERT INTO producto (nombre, tipo, marca, modelo, precio, cantidad, ubicacion) VALUES (@nombre, @tipo, @marca, @modelo, @precio, @cantidad, @ubicacion)";

                    using (var comando = new NpgsqlCommand(consulta, conn))
                    {
                        comando.Parameters.AddWithValue("@nombre", txt_nombre.Text.Trim());
                        comando.Parameters.AddWithValue("@tipo", txt_tipo.Text.Trim());
                        comando.Parameters.AddWithValue("@marca", txt_marca.Text.Trim());
                        comando.Parameters.AddWithValue("@modelo", txt_modelo.Text.Trim());
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.Parameters.AddWithValue("@cantidad", cantidad);
                        comando.Parameters.AddWithValue("@ubicacion", txt_ubicacion.Text.Trim());

                        if (idProducto.HasValue)
                            comando.Parameters.AddWithValue("@id", idProducto.Value);

                        comando.ExecuteNonQuery();
                        MessageBox.Show(idProducto.HasValue ? "Producto actualizado correctamente." : "Producto agregado correctamente.");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Buscar el formulario principal abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is panel_usuario panel)
                {
                    panel.CargarProductosfiltrados();
                    break;
                }
            }
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizar_productos_Load(object sender, EventArgs e)
        {
           
        }
    }
}
