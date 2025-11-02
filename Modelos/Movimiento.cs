using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Modelos
{
    public class Movimiento
    {
        private int producto_id;
        private string tipo;
        private DateTime fecha;
        private int cantidad;
        private string motivo;
        public Movimiento(int producto_id, string tipo, DateTime fecha, int cantidad, string motivo)
        {
            this.producto_id = producto_id;
            this.tipo = tipo;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.motivo = motivo;
        }
        public bool registrar(NpgsqlConnection conexion)
        {
            try
            {
                string consulta = "INSERT INTO movimiento (producto_id, tipo, fecha, cantidad, motivo) " +
                                  "VALUES (@producto_id, @tipo, @fecha, @cantidad, @motivo)";
                using (NpgsqlCommand comando = new NpgsqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@producto_id", producto_id);
                    comando.Parameters.AddWithValue("@tipo", tipo);
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    comando.Parameters.AddWithValue("@motivo", motivo);
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar movimiento: " + ex.Message);
                return false;
            }
        }

    }
}
