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

namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA
{
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
        }

        private void data_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarMovimientos()
        {
            try
            {
                ConexionPostgreSQL conexion = new ConexionPostgreSQL();
                var conn = conexion.ObtenerConexion();

                string consulta = "SELECT m.id, m.producto_id, p.nombre AS producto, m.tipo, m.fecha, m.cantidad, m.motivo " +
                                  "FROM movimiento m " +
                                  "JOIN producto p ON m.producto_id = p.id " +
                                  "ORDER BY m.fecha DESC";

                using (NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(consulta, conn))
                {
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    data_movimientos.DataSource = tabla;
                }

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar movimientos: " + ex.Message);
            }
        }
        private void inventario_Load(object sender, EventArgs e)
        {
            CargarMovimientos();
        }
        public DataTable BuscarMovimientosPorIdONombre(NpgsqlConnection conexion, string criterio)
        {
            DataTable tabla = new DataTable();

            string consulta = "SELECT m.id, m.producto_id, p.nombre AS producto, m.tipo, m.fecha, m.cantidad, m.motivo " +
                              "FROM movimiento m " +
                              "JOIN producto p ON m.producto_id = p.id " +
                              "WHERE CAST(m.id AS TEXT) ILIKE @termino OR p.nombre ILIKE @termino " +
                              "ORDER BY m.fecha DESC";

            using (var cmd = new NpgsqlCommand(consulta, conexion))
            {
                cmd.Parameters.Add("@termino", NpgsqlTypes.NpgsqlDbType.Text).Value = "%" + criterio + "%";

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
                MessageBox.Show("ingresa un ID o nombre para buscar");
            }
            ConexionPostgreSQL db = new ConexionPostgreSQL();
            var conexion = db.ObtenerConexion();
            data_movimientos.DataSource = BuscarMovimientosPorIdONombre(conexion, termino);
            db.CerrarConexion();
        }
    }
}
