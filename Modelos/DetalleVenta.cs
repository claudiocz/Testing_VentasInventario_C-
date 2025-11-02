using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Modelos
{
    public class DetalleVenta
    {
        private int venta_id;
        private int producto_id;
        private int cantidad;
        private float precio_unitario;
        public DetalleVenta(int venta_id, int producto_id, int cantidad, float precio_unitario)
        {
            this.venta_id = venta_id;
            this.producto_id = producto_id;
            this.cantidad = cantidad;
            this.precio_unitario = precio_unitario;
        }
        //Propiedades públicas para acceder desde fuera
        public int ProductoId => producto_id;
        public int Cantidad => cantidad;
        public float PrecioUnitario => precio_unitario;
        public bool Registrar(Npgsql.NpgsqlConnection conexion)
        {
            try
            {
                string consulta = "INSERT INTO detalle_venta (venta_id, producto_id, cantidad, precio_unitario) " +
                    "VALUES (@venta_id, @producto_id, @cantidad, @precio_unitario)";
                using (Npgsql.NpgsqlCommand comando = new Npgsql.NpgsqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@venta_id", venta_id);
                    comando.Parameters.AddWithValue("@producto_id", producto_id);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    comando.Parameters.AddWithValue("@precio_unitario", precio_unitario);
                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar el detalle de venta: " + ex.Message);
                return false;
            }
        }
    }
}
