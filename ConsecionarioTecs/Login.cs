using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FormularioDeInicio;
using System.Data.SqlClient;

namespace ConsecionarioTecs
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Server=ALXJANDR07\\SQLEXPRESS; Database=CompañiaTecsBDD; User Id=AleAdmin; Password=ale123;");
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void logear(string usuario, string contraseña) 
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_usuario FROM Logins WHERE Usuario = @usuario AND Password = @pas", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1 )
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString()=="Admin")
                    {
                        MenuAdmin Menuadm = new MenuAdmin();
                        Menuadm.Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        VistaCliente vC = new VistaCliente();
                        vC.Show();

                    }

                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                con.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            logear(this.txtUsuario.Text, this.txtContraseña.Text);
        }
    
        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
