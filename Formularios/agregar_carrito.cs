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
    public partial class agregar_carrito : Form
    {
        public agregar_carrito(string id, string nombre, string tipo, string marca, string modelo, float precio, int cantidad)
        {
            InitializeComponent();
            lb_id.Text = id;
            lb_nombre.Text = nombre;
            lb_tipo.Text = tipo;
            lb_marca.Text = marca;
            lb_modelo.Text = modelo;
            lb_precio.Text = precio.ToString();
            lb_cantidad.Text = cantidad.ToString();
        }
        private void agregar_carrito_Load(object sender, EventArgs e)
        {

        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (nud_cantidad.Value <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad mayor a cero");
                return;
            }

            int id = int.Parse(lb_id.Text);
            string nombre = lb_nombre.Text;
            string tipo = lb_tipo.Text;
            string marca = lb_marca.Text;
            string modelo = lb_modelo.Text;
            float precio = float.Parse(lb_precio.Text);
            int cantidad = (int)nud_cantidad.Value;

            venta_carrito.AgregarProductos(id, nombre, tipo, marca, modelo, precio, cantidad);

            MessageBox.Show("Producto agregado correctamente al carrito 🙂");
            this.Close();
        }
    }
}
