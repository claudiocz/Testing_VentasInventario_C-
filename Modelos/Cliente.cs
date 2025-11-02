using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Modelos
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private int celular;
        private string correo;
        public Cliente(int id, string nombre, int celular, string correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.celular = celular;
            this.correo = correo;
        }
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Celular { get { return celular; } set { celular = value; } }
        public string Correo { get { return correo; } set { correo = value; } }
        public bool Registrar(Npgsql.NpgsqlConnection conexion)
        {
            try
            {
                string consulta = "INSERT INTO cliente (id, nombre, celular, correo) " +
                    "VALUES (@id, @nombre, @celular, @correo)";
                using (Npgsql.NpgsqlCommand comando = new Npgsql.NpgsqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@celular", celular);
                    comando.Parameters.AddWithValue("@correo", correo);
                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar el cliente: " + ex.Message);
                return false;
            }
        }
    }
}
