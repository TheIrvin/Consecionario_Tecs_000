using ConsecionarioTecs;
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
    public partial class Administradores : Form
    {
        Conexion_BDD conSQL = new Conexion_BDD();

        public Administradores()
        {
            InitializeComponent();
        }

        private void Administradores_Load(object sender, EventArgs e)
        {
            dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores");
        }

        private void tsbtnEliminarAdmin_Click(object sender, EventArgs e)
        {
            if (dtgvContenedorAdministradores.RowCount > 0)//Validar que tengo alguna fila seleccionada
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + dtgvContenedorAdministradores.CurrentRow.Index + ", que pertenece al administrador " + dtgvContenedorAdministradores[0, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    conSQL.eliminarDatos("Administradores", "AdministradorID='" + dtgvContenedorAdministradores[0, dtgvContenedorAdministradores.CurrentRow.Index].Value.ToString() + "'");
                    dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores");
                }
            }
        }

        private void tstxtFiltrarAdmin_KeyUp(object sender, KeyEventArgs e)
        {
            if (tstxtFiltrarAdmin.Text.Length > 4)
            {
                dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores where AdministradorID like '%" + tstxtFiltrarAdmin.Text + "%' or NombreAdmin like '%" + tstxtFiltrarAdmin.Text + "%'");
            }

            if (tstxtFiltrarAdmin.Text.Length == 0)
                dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores");
        }

        private void tsbtnFiltrarAdmin_Click(object sender, EventArgs e)
        {
            dtgvContenedorAdministradores.DataSource = conSQL.retornaRegistros("Select * from Administradores where AdministradorID like '%" + tstxtFiltrarAdmin.Text + "%' or NombreAdmin like '%" + tstxtFiltrarAdmin.Text + "%'");

        }

        private void tsbtnAgregarAdmin_Click(object sender, EventArgs e)
        {
            AgregarAdmin nuevoAdmin = new AgregarAdmin();
            this.AddOwnedForm(nuevoAdmin);
            nuevoAdmin.Show();
        }

    }
}
