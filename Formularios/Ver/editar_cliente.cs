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

namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Formularios.Ver
{
    public partial class editar_cliente : Form
    {
        private int? idCliente = null;
        public editar_cliente(int? idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            if (idCliente.HasValue)
            {
                CargarDatosCliente(idCliente.Value);
            }
        }
        public void CargarDatosCliente(int id)
        {
            try
            {
                Datos.ConexionPostgreSQL conexion = new Datos.ConexionPostgreSQL();
                using (var conn = conexion.ObtenerConexion())
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string consulta = "SELECT id, nombre, celular, correo FROM cliente WHERE id = @id";

                    using (var comando = new NpgsqlCommand(consulta, conn))
                    {
                        comando.Parameters.AddWithValue("@id", id);
                        using (var reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Usa GetInt64 si el campo 'id' es bigint
                                if (!reader.IsDBNull(0))
                                    txt_id.Text = reader.GetInt64(0).ToString();
                                if (!reader.IsDBNull(1))
                                    txt_nombre.Text = reader.GetString(1);
                                if (!reader.IsDBNull(2))
                                    txt_celular.Text = reader.GetInt64(2).ToString();
                                if (!reader.IsDBNull(3))
                                    txt_correo.Text = reader.GetString(3);
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el cliente con ese ID.", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del cliente:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(txt_id.Text) ||
                string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_celular.Text) ||
                string.IsNullOrWhiteSpace(txt_correo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Conversión segura del ID
            if (!int.TryParse(txt_id.Text.Trim(), out int nuevoId))
            {
                MessageBox.Show("El ID debe ser un número entero válido.", "ID inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Conversión segura del celular (si es bigint en la base de datos)
            if (!long.TryParse(txt_celular.Text.Trim(), out long celular))
            {
                MessageBox.Show("El número de celular debe ser un número válido.", "Celular inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ConexionPostgreSQL conexion = new ConexionPostgreSQL();
                using (var conn = conexion.ObtenerConexion())
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    string consulta = idCliente.HasValue
                        ? "UPDATE cliente SET id = @nuevoId, nombre = @nombre, celular = @celular, correo = @correo WHERE id = @idOriginal"
                        : "INSERT INTO cliente (id, nombre, celular, correo) VALUES (@nuevoId, @nombre, @celular, @correo)";
                    using (var comando = new NpgsqlCommand(consulta, conn))
                    {
                        comando.Parameters.AddWithValue("@nuevoId", nuevoId);
                        comando.Parameters.AddWithValue("@nombre", txt_nombre.Text.Trim());
                        comando.Parameters.AddWithValue("@celular", celular); // bigint
                        comando.Parameters.AddWithValue("@correo", txt_correo.Text.Trim());
                        if (idCliente.HasValue)
                            comando.Parameters.AddWithValue("@idOriginal", idCliente.Value);
                        comando.ExecuteNonQuery();
                        string mensaje = idCliente.HasValue ? "Cliente actualizado correctamente." : "Cliente agregado correctamente.";
                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos del cliente:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // 🔄 Actualizar el panel principal si está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is Detalles_Venta cliente)
                {
                    cliente.cargarClientes(); // Método que refresca el DataGridView
                    break;
                }
            }
        }
    }
}
