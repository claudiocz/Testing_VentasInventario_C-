using GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Datos;
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
    public partial class Detalles_Venta : Form
    {
        public Detalles_Venta()
        {
            InitializeComponent();
        }
        private void cargarDetallesVentas()
        {
            ConexionPostgreSQL conexion = new ConexionPostgreSQL();
            var conn = conexion.ObtenerConexion();
            string consulta = "SELECT * FROM detalle_venta ORDER BY id";
            using (NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(consulta, conn))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                data_detalles.DataSource = tabla;
            }
            conexion.CerrarConexion();
        }
        private void cargarVentas()
        {
            ConexionPostgreSQL conexion = new ConexionPostgreSQL();
            var conn = conexion.ObtenerConexion();
            string consulta = "SELECT * FROM venta ORDER BY id";
            using (NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(consulta, conn))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                data_ventas.DataSource = tabla;
            }
            conexion.CerrarConexion();
        }
        public void cargarClientes()
        {
            ConexionPostgreSQL conexion = new ConexionPostgreSQL();
            var conn = conexion.ObtenerConexion();
            string consulta = "SELECT * FROM cliente ORDER BY id";
            using (NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(consulta, conn))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                data_clientes.DataSource = tabla;
            }
            conexion.CerrarConexion();
        }
        private void Detalles_Venta_Load(object sender, EventArgs e)
        {
            cargarClientes();
            cargarVentas();
            cargarDetallesVentas();
        }
        public DataTable BuscarClientes(NpgsqlConnection conexion, string criterio)
        {
            DataTable tabla = new DataTable();
            string consulta = "SELECT * FROM cliente WHERE CAST(id AS TEXT) ILIKE @criterio OR nombre ILIKE @criterio";

            using (var cmd = new NpgsqlCommand(consulta, conexion))
            {
                cmd.Parameters.Add("@criterio", NpgsqlTypes.NpgsqlDbType.Text).Value = "%" + criterio + "%";
                using (var adaptador = new NpgsqlDataAdapter(cmd))
                {
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }
        public DataTable BuscarVentasPorCliente(NpgsqlConnection conexion, int clienteId)
        {
            DataTable tabla = new DataTable();
            string consulta = "SELECT * FROM venta WHERE cliente_id = @id ORDER BY fecha DESC";

            using (var cmd = new NpgsqlCommand(consulta, conexion))
            {
                cmd.Parameters.AddWithValue("@id", clienteId);
                using (var adaptador = new NpgsqlDataAdapter(cmd))
                {
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }
        public DataTable BuscarDetalleVenta(NpgsqlConnection conexion, int ventaId)
        {
            DataTable tabla = new DataTable();
            string consulta = "SELECT * FROM detalle_venta WHERE venta_id = @id";

            using (var cmd = new NpgsqlCommand(consulta, conexion))
            {
                cmd.Parameters.AddWithValue("@id", ventaId);
                using (var adaptador = new NpgsqlDataAdapter(cmd))
                {
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string termino = txt_buscar.Text.Trim();
            if (string.IsNullOrEmpty(termino))
            {
                MessageBox.Show("Ingresa un ID o nombre para buscar");
                return;
            }
            ConexionPostgreSQL db = new ConexionPostgreSQL();
            var conexion = db.ObtenerConexion();
            data_clientes.DataSource = BuscarClientes(conexion, termino);
            data_ventas.DataSource = null;
            data_detalles.DataSource = null;
            db.CerrarConexion();
        }

        private void data_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_clientes.SelectedRows.Count > 0)
            {
                int clienteId = Convert.ToInt32(data_clientes.SelectedRows[0].Cells["id"].Value);
                ConexionPostgreSQL db = new ConexionPostgreSQL();
                var conexion = db.ObtenerConexion();
                data_ventas.DataSource = BuscarVentasPorCliente(conexion, clienteId);
                data_detalles.DataSource = null;
                db.CerrarConexion();
            }
        }
        private void data_ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_ventas.SelectedRows.Count > 0)
            {
                int ventaId = Convert.ToInt32(data_ventas.SelectedRows[0].Cells["id"].Value);
                ConexionPostgreSQL db = new ConexionPostgreSQL();
                var conexion = db.ObtenerConexion();
                data_detalles.DataSource = BuscarDetalleVenta(conexion, ventaId);
                db.CerrarConexion();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_clientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona un cliente para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var idValue = data_clientes.SelectedRows[0].Cells["id"].Value;
                if (idValue == null || string.IsNullOrWhiteSpace(idValue.ToString()))
                {
                    MessageBox.Show("El cliente seleccionado no tiene un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(idValue.ToString(), out int idCliente))
                {
                    MessageBox.Show("El ID del cliente no es válido o excede el rango permitido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                editar_cliente editarForm = new editar_cliente(idCliente); // ← ahora recibe un int
                editarForm.ShowDialog();
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Detalles_Venta panel)
                    {
                        panel.cargarClientes(); // ← actualiza el panel central
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar editar el cliente:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
