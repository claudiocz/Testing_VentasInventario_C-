using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA.Modelos
{
    public class Producto
    {
        private string nombre;
        private string tipo ;
        private string marca;
        private string modelo;
        private float precio;
        private int cantidad;
        private string ubicacion;
        public Producto(string nombre, string tipo, string marca, string modelo, float precio, int cantidad, string ubicacion)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.cantidad = cantidad;
            this.ubicacion = ubicacion;
        }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }
        public string Marca { get { return marca; } set { marca = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }
        public float Precio { get { return precio; } set { precio = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public string Ubicacion { get { return ubicacion; } set { ubicacion = value; } }
        public int registrar(NpgsqlConnection conexion)
        {
            try
            {
                string consulta = "INSERT INTO producto (nombre, tipo, marca, modelo, precio, cantidad, ubicacion) " +
                                  "VALUES (@nombre, @tipo, @marca, @modelo, @precio, @cantidad, @ubicacion) RETURNING id";
                using (NpgsqlCommand comando = new NpgsqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@tipo", tipo);
                    comando.Parameters.AddWithValue("@marca", marca);
                    comando.Parameters.AddWithValue("@modelo", modelo);
                    comando.Parameters.AddWithValue("@precio", precio);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    comando.Parameters.AddWithValue("@ubicacion", ubicacion);

                    object resultado = comando.ExecuteScalar();
                    return resultado != null ? Convert.ToInt32(resultado) : -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar producto: " + ex.Message);
                return -1;
            }
        }
        public override string ToString()
        {
            return $"{Nombre} ({Cantidad} x {Precio:C})";
        }
    }
}
