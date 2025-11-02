using System.Drawing.Printing;

namespace GESTION_DE_INVENTARIO_Y_VENTAS_DE_COMPUTADORA
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string usuario = texbox_usuario.Text;
            string contrasena = textbox_pass.Text;
            if (usuario == "admin" && contrasena == "admin")
            {
                panel_usuario inicio = new panel_usuario();
                inicio.Show();
                this.Hide();
            }
            else
            {
                if (usuario != "admin" && contrasena != "admin")
                {
                    MessageBox.Show("Usuario o contrasena incorrectos");
                }
                else if (usuario == "" && contrasena == "")
                {
                    MessageBox.Show("Por favor ingrese sus credenciales");
                }
                else
                {
                    MessageBox.Show("Usuario o contrasena incorrecta");
                }
            }
        }

        private void texbox_usuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linklabel_recu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("se implementara cuando este en producci�n.\n" +
                "Por favor ingrese la contrasena por defecto."); result.Equals(DialogResult.OK);
        }
    }
}
