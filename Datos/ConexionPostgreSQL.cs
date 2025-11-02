using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Datos
{
    internal class ConexionPostgreSQL
    {
        private NpgsqlConnection conexion;
        public ConexionPostgreSQL()
        {
            string cadenaConexion = "Host=localhost;Port=5432;Username=postgres;Password=C6543645c*;Database=tienda_pc";
            try
            {
                conexion = new NpgsqlConnection(cadenaConexion);
                conexion.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }
        public NpgsqlConnection ObtenerConexion()
        {
            return conexion;
        }
        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
