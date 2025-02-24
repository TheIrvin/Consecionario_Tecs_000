using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioDeInicio
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void lblxproduct_Click(object sender, EventArgs e)
        {

        }
        private void Productos_Load(object sender, EventArgs e)
        {

        }
        int indicePanel = 1; 
        private void bt_O_agregarMoto_Click(object sender, EventArgs e)
        {
            Panel panelActual = null;

            foreach (Control control in panel_original.Controls) 
            {
                if (control is Panel && control.Name == "panel_A_" + indicePanel)
                {
                    panelActual = (Panel)control;
                    break;
                }
            }

            if (panelActual == null)
            {
                MessageBox.Show("No hay más paneles (Agregar mas)");
                return;
            }

            panelActual.Visible = true;

            foreach (Control control in panelActual.Controls)
            {
                if (control is TextBox txt)
                {
                    if (txt.Name == "txtBox_nombreMoto" + indicePanel)
                        txt.Text = txtBox_O_nombreMoto.Text;

                    if (txt.Name == "txtBox_marcaMoto" + indicePanel)
                        txt.Text = txtBox_O_marcaMoto.Text;

                    if (txt.Name == "txtBox_precioMoto" + indicePanel)
                        txt.Text = txtBox_O_precioMoto.Text;

                    if (txt.Name == "txtBox_tieneIVA" + indicePanel) 
                        txt.Text = txtBox_O_IVA.Text;

                    if (txt.Name == "txtBox_descripcion" + indicePanel) 
                    {
                        txt.Text = txtBox_O_descripcion.Text;
                        txt.Visible = true; 
                    }
                }
                else if (control is PictureBox pic)
                {
                    if (pic.Name == "pic_moto" + indicePanel)
                        pic.Image = pic_O_moto.Image;
                }
                else if (control is Button btn) 
                {
                    if (btn.Name == "bt_editar" + indicePanel) 
                        btn.Visible = true;

                    if (btn.Name == "bt_eliminar" + indicePanel) 
                    {
                        btn.Visible = true;
                    }
                   
                }
            }

            txtBox_O_nombreMoto.Text = "";
            txtBox_O_marcaMoto.Text = "";
            txtBox_O_precioMoto.Text = "";
            txtBox_O_IVA.Text = "";
            txtBox_O_descripcion.Text = "";
            pic_O_moto.Image = null;

            indicePanel++;
        }
    }
}

