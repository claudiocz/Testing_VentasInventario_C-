using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Modelos
{
    public class Venta
    {
        private DateTime fecha;
        private int id_cliente;
        private float total;
        private string tipo_pago;
        public Venta(DateTime fecha, int id_cliente, float total, string tipo_pago)
        {
            this.fecha = fecha;
            this.id_cliente = id_cliente;
            this.total = total;
            this.tipo_pago = tipo_pago;
        }
        public int Registrar(NpgsqlConnection conexion)
        {
            try
            {
                string consulta = "INSERT INTO venta (fecha, cliente_id, total, tipo_pago) " +
                                  "VALUES (@fecha, @cliente_id, @total, @tipo_pago) RETURNING id";
                using (var comando = new NpgsqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    comando.Parameters.AddWithValue("@cliente_id", id_cliente);
                    comando.Parameters.AddWithValue("@total", total);
                    comando.Parameters.AddWithValue("@tipo_pago", tipo_pago);
                    object resultado = comando.ExecuteScalar();
                    return resultado != null ? Convert.ToInt32(resultado) : -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar venta: " + ex.Message);
                return -1;
            }
        }
    }
}
