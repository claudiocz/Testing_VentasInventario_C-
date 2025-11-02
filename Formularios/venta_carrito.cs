using GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Datos;
using GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Modelos;
using Microsoft.VisualBasic;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA
{
    public partial class venta_carrito : Form
    {
        public venta_carrito()
        {
            InitializeComponent();
        }
        public static List<string> productosPendientes = new List<string>();
        public static void AgregarProductos(int id, string nombre, string tipo, string marca, string modelo, float precio, int cantidad)
        {
            string item = $"ID:{id} - {nombre} [{tipo}] ({marca} {modelo}) [{precio}] Cant: {cantidad}";
            productosPendientes.Add(item);
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionPostgreSQL conexion = new ConexionPostgreSQL();
                var conn = conexion.ObtenerConexion();
                // Validar datos del cliente
                string nombre = txt_nombre.Text.Trim();
                string correo = txt_correo.Text.Trim();
                string tipoPago = cbx_tipo_pago.Text;
                DateTime fecha = DateTime.Today;

                if (!int.TryParse(txt_id.Text, out int ci))
                {
                    MessageBox.Show("CI inválido.");
                    return;
                }

                if (!int.TryParse(txt_celular.Text, out int celular))
                {
                    MessageBox.Show("Celular inválido.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(tipoPago))
                {
                    MessageBox.Show("Completa los datos del cliente y tipo de pago.");
                    return;
                }

                // Verificar si el cliente ya existe
                int clienteId;
                string consultaBuscar = "SELECT id FROM cliente WHERE id = @ci";
                using (var cmdBuscar = new NpgsqlCommand(consultaBuscar, conn))
                {
                    cmdBuscar.Parameters.AddWithValue("@ci", ci);
                    var resultado = cmdBuscar.ExecuteScalar();
                    if (resultado != null)
                    {
                        clienteId = Convert.ToInt32(resultado);
                    }
                    else
                    {
                        // Registrar nuevo cliente
                        string consultaInsertar = "INSERT INTO cliente (id, nombre, celular, correo) " +
                                                  "VALUES (@id, @nombre, @celular, @correo) RETURNING id";
                        using (var cmdInsertar = new NpgsqlCommand(consultaInsertar, conn))
                        {
                            cmdInsertar.Parameters.AddWithValue("@id", ci);
                            cmdInsertar.Parameters.AddWithValue("@nombre", nombre);
                            cmdInsertar.Parameters.AddWithValue("@celular", celular);
                            cmdInsertar.Parameters.AddWithValue("@correo", correo);
                            clienteId = Convert.ToInt32(cmdInsertar.ExecuteScalar());
                        }
                    }
                }
                // Calcular total y preparar detalles
                float total = 0;
                List<DetalleVenta> detalles = new List<DetalleVenta>();
                foreach (string item in productosPendientes)
                {
                    Match match = Regex.Match(item, @"ID:(\d+).*? - (.*?) \[(.*?)\] \((.*?) (.*?)\) \[(\d+(,\d+)?|\d+(\.\d+)?)\] Cant:\s*(\d+)");
                    if (match.Success)
                    {
                        int productoId = int.Parse(match.Groups[1].Value);
                        float precio = float.Parse(match.Groups[6].Value);
                        int cantidad = int.Parse(match.Groups[9].Value);

                        total += precio * cantidad;
                        detalles.Add(new DetalleVenta(0, productoId, cantidad, precio)); // venta_id se asigna después
                    }
                    else
                    {
                        MessageBox.Show("Formato inválido en: " + item);
                        return;
                    }
                }
                // Registrar venta usando clase Venta
                Venta venta = new Venta(fecha, clienteId, total, tipoPago);
                int ventaId = venta.Registrar(conn);

                if (ventaId <= 0)
                {
                    MessageBox.Show("Error al registrar la venta.");
                    return;
                }
                // Registrar detalles, movimientos y actualizar stock
                foreach (var detalle in detalles)
                {
                    // Asignar el ID de la venta al detalle
                    DetalleVenta detalleVenta = new DetalleVenta(ventaId, detalle.ProductoId, detalle.Cantidad, detalle.PrecioUnitario);

                    // Registrar detalle de venta
                    if (!detalleVenta.Registrar(conn))
                    {
                        MessageBox.Show($"Error al registrar detalle del producto ID {detalle.ProductoId}");
                        continue;
                    }

                    // Registrar movimiento de salida
                    RegistrarMovimiento(conn, detalle.ProductoId, fecha, detalle.Cantidad, "Venta ID: " + ventaId);

                    // Actualizar stock
                    ActualizarStock(conn, detalle.ProductoId, detalle.Cantidad);
                }

                MessageBox.Show("✅ Venta registrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                productosPendientes.Clear();
                clb_articulos.Items.Clear();
                txt_nombre.Clear();
                txt_correo.Clear();
                txt_id.Clear();
                txt_celular.Clear();
                conexion.CerrarConexion();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al procesar la venta: " + ex.Message);
            }
            panel_usuario panel = Application.OpenForms["panel_usuario"] as panel_usuario;
            panel?.ActualizarPanel();
        }
        private void RegistrarMovimiento(NpgsqlConnection conn, int productoId, DateTime fecha, int cantidad, string motivo)
        {
            string sql = "INSERT INTO movimiento (producto_id, tipo, fecha, cantidad, motivo) " +
                         "VALUES (@producto_id, 'salida', @fecha, @cantidad, @motivo)";
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@producto_id", productoId);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@motivo", motivo);
                cmd.ExecuteNonQuery();
            }
        }
        private void ActualizarStock(NpgsqlConnection conn, int productoId, int cantidadVendida)
        {
            string sql = "UPDATE producto SET cantidad = cantidad - @cantidad WHERE id = @id";
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@cantidad", cantidadVendida);
                cmd.Parameters.AddWithValue("@id", productoId);
                cmd.ExecuteNonQuery();
            }
        }
        private void clb_articulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void venta_carrito_Load(object sender, EventArgs e)
        {
            clb_articulos.Items.Clear();
            foreach (string item in productosPendientes)
            {
                clb_articulos.Items.Add(item);
            }
            ActualizarTotal();
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (clb_articulos.SelectedItem != null)
            {
                string selectedItem = clb_articulos.SelectedItem.ToString();
                productosPendientes.Remove(selectedItem);
                clb_articulos.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un artículo para eliminar.");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (clb_articulos.SelectedItem != null)
            {
                string selectedItem = clb_articulos.SelectedItem.ToString();
                // Extraer datos con Regex
                Match match = Regex.Match(selectedItem, @"ID:(\d+).*? - (.*?) \[(.*?)\] \((.*?) (.*?)\) \[(\d+(,\d+)?|\d+(\.\d+)?)\] Cant:\s*(\d+)");
                if (match.Success)
                {
                    int id = int.Parse(match.Groups[1].Value);
                    string nombre = match.Groups[2].Value;
                    string tipo = match.Groups[3].Value;
                    string marca = match.Groups[4].Value;
                    string modelo = match.Groups[5].Value;
                    string precioTexto = match.Groups[6].Value.Replace(",", ".");
                    float precio = float.Parse(precioTexto, System.Globalization.CultureInfo.InvariantCulture);

                    // Pedir nueva cantidad
                    string input = Interaction.InputBox("Ingrese nueva cantidad:", "Editar cantidad", match.Groups[9].Value);
                    if (int.TryParse(input, out int nuevaCantidad) && nuevaCantidad > 0)
                    {
                        // Crear nuevo string
                        string nuevoItem = $"ID:{id} - {nombre} [{tipo}] ({marca} {modelo}) [{precio}] Cant:{nuevaCantidad}";

                        // Reemplazar en lista
                        int index = clb_articulos.SelectedIndex;
                        productosPendientes.Remove(selectedItem);
                        productosPendientes.Insert(index, nuevoItem);

                        clb_articulos.Items[index] = nuevoItem;

                        MessageBox.Show("Cantidad actualizada correctamente.");
                        ActualizarTotal(); // Recalcular total si lo usas
                    }
                    else
                    {
                        MessageBox.Show("Cantidad inválida.");
                    }
                }
                else
                {
                    MessageBox.Show("Formato de artículo no reconocido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un artículo para editar.");
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_calular_cambio_Click(object sender, EventArgs e)
        {
            float dinero = float.Parse(txt_cambio.Text);
            if(dinero >= TotalPago())
            {
                float cambio = dinero - TotalPago();
                lbl_cambio.Text = cambio.ToString("0.00");
            }
            else
            {
                float cambio = dinero-TotalPago();
                MessageBox.Show("El dinero ingresado es insuficiente para cubrir el total o falta: " + cambio);
            }
        }
        private float TotalPago()
        {
            float total = 0;
            foreach (string item in productosPendientes)
            {
                Match match = Regex.Match(item, @"ID:(\d+).*?\[.*?\].*?\((.*?)\).*?\[(\d+(,\d+)?|\d+(\.\d+)?)\]\s*Cant:\s*(\d+)");
                if (match.Success)
                {
                    string precioTexto = match.Groups[3].Value.Replace(",", ".");
                    string cantidadTexto = match.Groups[6].Value;

                    if (float.TryParse(precioTexto, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float precio) &&
                        int.TryParse(cantidadTexto, out int cantidad))
                    {
                        total += precio * cantidad;
                    }
                }
            }
            return total;
        }
        private void ActualizarTotal()
        {
            float total = 0;
            foreach (string item in productosPendientes)
            {
                Match match = Regex.Match(item, @"ID:(\d+).*?\[.*?\].*?\((.*?)\).*?\[(\d+(,\d+)?|\d+(\.\d+)?)\]\s*Cant:\s*(\d+)");
                if (match.Success)
                {
                    string precioTexto = match.Groups[3].Value.Replace(",", ".");
                    string cantidadTexto = match.Groups[6].Value;

                    if (float.TryParse(precioTexto, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float precio) &&
                        int.TryParse(cantidadTexto, out int cantidad))
                    {
                        total += precio * cantidad;
                    }
                }
            }

            if (cbx_tipo_pago.Text == "DOLAR")
            {
                float totalDolar = total / 6.96f;
                lbl_total.Text = total > 0 ? totalDolar.ToString("0.00") + " US" : "0.00 US";
            }
            else
            {
                lbl_total.Text = total > 0 ? total.ToString("0.00") + " BS" : "0.00 BS";
            }

        }
        private void cbx_tipo_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }
    }
}

