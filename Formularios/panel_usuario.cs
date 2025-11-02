using GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Datos;
using GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Formularios;
using GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Formularios.Ver;
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
    public partial class panel_usuario : Form
    {
        public panel_usuario()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            agregar_productos agregar = new agregar_productos();
            agregar.Show();
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro que deseas cerrar sesión?",
                "Cerrar sesión", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                login login = new login();
                login.Show();
                this.Hide();
            }
        }
        private void CargarProductos()
        {
            ConexionPostgreSQL conexion = new ConexionPostgreSQL();
            var conn = conexion.ObtenerConexion();
            string consulta = "SELECT * FROM producto ORDER BY id";
            using (NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(consulta, conn))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                data_productos.DataSource = tabla;
            }
            conexion.CerrarConexion();
        }
        public DataTable MostrarDatos(NpgsqlConnection conexion)
        {
            DataTable tabla = new DataTable();
            try
            {
                string consulta = "SELECT * FROM producto";
                using (NpgsqlCommand comando = new NpgsqlCommand(consulta, conexion))
                {
                    using (NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
            return tabla;
        }
        public DataTable BuscarIDNombre(NpgsqlConnection conexion, string criterio)
        {
            DataTable tabla = new DataTable();
            string consulta = "SELECT * FROM producto WHERE CAST(id AS TEXT) ILIKE @termino OR nombre ILIKE @termino";
            using (var cmd = new NpgsqlCommand(consulta, conexion))
            {
                cmd.Parameters.AddWithValue("@termino", "%" + criterio + "%");
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
            data_productos.DataSource = BuscarIDNombre(conexion, termino);
            db.CerrarConexion();
        }
        public List<string> ObtenerTipos(NpgsqlConnection conexion)
        {
            List<string> tipos = new List<string>();
            string consulta = "SELECT DISTINCT tipo FROM producto ORDER BY tipo";
            using (var cmd = new NpgsqlCommand(consulta, conexion))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    tipos.Add(reader.GetString(0));
                }
            }
            return tipos;
        }
        public List<string> ObtenerMarcas(NpgsqlConnection conexion)
        {
            List<string> marcas = new List<string>();
            string consulta = "SELECT DISTINCT marca FROM producto ORDER BY marca";
            using (var cmd = new NpgsqlCommand(consulta, conexion))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    marcas.Add(reader.GetString(0));
                }
            }
            return marcas;
        }
        public DataTable ObtenerProductosFiltrados(NpgsqlConnection conexion, string tipo, string marca)
        {
            DataTable tabla = new DataTable();
            string consulta = "SELECT * FROM producto WHERE 1=1";
            if (tipo != "Todos")
            {
                consulta += " AND Tipo = @tipo";
            }
            if (marca != "Todos")
            {
                consulta += " AND Marca = @marca";
            }
            using (var cmd = new NpgsqlCommand(consulta, conexion))
            {
                if (tipo != "Todos")
                {
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                }
                if (marca != "Todos")
                {
                    cmd.Parameters.AddWithValue("@marca", marca);
                }
                using (var adaptador = new NpgsqlDataAdapter(cmd))
                {
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }
        public void CargarProductosfiltrados()
        {
            ConexionPostgreSQL db = new ConexionPostgreSQL();
            var conexion = db.ObtenerConexion();
            string tipo = cbx_tipo.SelectedItem != null ? cbx_tipo.SelectedItem.ToString() : "Todos";
            string marca = cbx_marca.SelectedItem != null ? cbx_marca.SelectedItem.ToString() : "Todos";
            data_productos.DataSource = ObtenerProductosFiltrados(conexion, tipo, marca);
            db.CerrarConexion();
        }
        private void panel_usuario_Load(object sender, EventArgs e)
        {
            CargarProductos();
            ConexionPostgreSQL db = new ConexionPostgreSQL();
            var conn = db.ObtenerConexion();
            cbx_tipo.Items.Insert(0, "Todos");
            cbx_marca.Items.Insert(0, "Todos");
            cbx_tipo.SelectedIndex = 0;
            cbx_marca.SelectedIndex = 0;
            CargarProductosfiltrados(); // Mostrar todos al inicio
            CargarFiltros();
            db.CerrarConexion();
        }
        private void CargarFiltros()
        {
            ConexionPostgreSQL db = new ConexionPostgreSQL();
            var conexion = db.ObtenerConexion();
            // Limpiar primero
            cbx_tipo.Items.Clear();
            cbx_marca.Items.Clear();
            // Insertar opción "Todos"
            cbx_tipo.Items.Add("Todos");
            cbx_marca.Items.Add("Todos");
            // Llenar con datos reales
            List<string> tipos = ObtenerTipos(conexion);
            List<string> marcas = ObtenerMarcas(conexion);
            cbx_tipo.Items.AddRange(tipos.ToArray());
            cbx_marca.Items.AddRange(marcas.ToArray());
            // Seleccionar "Todos" por defecto
            cbx_tipo.SelectedIndex = 0;
            cbx_marca.SelectedIndex = 0;
            db.CerrarConexion();
        }
        private void cbx_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductosfiltrados();
        }

        private void cbx_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductosfiltrados();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            inventario inventario = new inventario();
            inventario.Show();
        }

        private void data_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = data_productos.Rows[e.RowIndex];
                string id = fila.Cells["id"].Value.ToString();
                string nombre = fila.Cells["nombre"].Value.ToString();
                string tipo = fila.Cells["tipo"].Value.ToString();
                string marca = fila.Cells["marca"].Value.ToString();
                string modelo = fila.Cells["modelo"].Value.ToString();
                float precio = (float)Convert.ToDecimal(fila.Cells["precio"].Value);
                int cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value);

                agregar_carrito carrito = new agregar_carrito(id, nombre, tipo, marca, modelo, precio, cantidad);
                carrito.ShowDialog();
            }
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            venta_carrito ventaCarrito = new venta_carrito();
            ventaCarrito.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (data_productos.SelectedRows.Count > 0)
            {
                // Obtener el ID de la fila seleccionada
                int idProducto = Convert.ToInt32(data_productos.SelectedRows[0].Cells["id"].Value);
                // Confirmar eliminación
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        ConexionPostgreSQL conexion = new ConexionPostgreSQL();
                        var conn = conexion.ObtenerConexion();
                        string consulta = "DELETE FROM producto WHERE id = @id";
                        using (NpgsqlCommand comando = new NpgsqlCommand(consulta, conn))
                        {
                            comando.Parameters.AddWithValue("@id", idProducto);
                            int filasAfectadas = comando.ExecuteNonQuery();
                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Producto eliminado correctamente.");
                                CargarProductos(); // Recarga el DataGridView
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el producto para eliminar.");
                            }
                        }
                        conexion.CerrarConexion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar producto: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }
        public void ActualizarPanel()
        {
            CargarProductos();
            CargarFiltros();
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (data_productos.SelectedRows.Count > 0)
            {
                // Obtener el ID de la fila seleccionada
                int idProducto = Convert.ToInt32(data_productos.SelectedRows[0].Cells["id"].Value);
                actualizar_productos agregarFrom = new actualizar_productos(idProducto);
                agregarFrom.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para editar.");
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Detalles_Venta ventaDetalles = new Detalles_Venta();
            ventaDetalles.Show();
        }

        private void acercaDeSisIVPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (acerca_SisVP sisvip = new acerca_SisVP())
            {
                sisvip.ShowDialog();
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("se implementara cuando este en producción"); result = DialogResult.OK;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
