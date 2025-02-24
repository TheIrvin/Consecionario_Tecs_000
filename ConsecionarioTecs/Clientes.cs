using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsecionarioTecs;

namespace FormularioDeInicio
{
    public partial class Clientes : Form
    {
        Conexion_BDD conSQL = new Conexion_BDD();
        int bandera = 0;
        int clientexPag = 40;
        public Clientes()
        {
            InitializeComponent();
        }

        private void lblEstadisticas1_Click(object sender, EventArgs e)
        {

        }

        private void lblxEst_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dtgvContendorClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmNc formAggClientes = new frmNc();
            formAggClientes.lblAgregarClientes.Visible = true;
            formAggClientes.txtIDc.Visible = false;
            formAggClientes.lblModificarCliente.Visible = false;
            formAggClientes.lblID.Visible = false;
            this.AddOwnedForm(formAggClientes);
            formAggClientes.Show();
        }

        private void tstbtnModificarC_Click(object sender, EventArgs e)
        {
            frmNc frmC = new frmNc();
            this.AddOwnedForm(frmC);
            frmC.lblAgregarClientes.Visible = false;
            frmC.txtIDc.Visible = true;
            frmC.lblModificarCliente.Visible = true;
            frmC.lblID.Visible = true;
            frmC.txtIDc.Text = dtgvContendorClientes[0, dtgvContendorClientes.CurrentRow.Index].Value.ToString();
            
            frmC.Show();
        }

        private void tstbtnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvContendorClientes.RowCount > 0)
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + dtgvContendorClientes.CurrentRow.Index + ", que pertenece al cliente " + dtgvContendorClientes[0, dtgvContendorClientes.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    conSQL.eliminarDatos("Clientes", "{Cliente ID]='" + dtgvContendorClientes[0, dtgvContendorClientes.CurrentRow.Index].Value.ToString() + "'");
                    dtgvContendorClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes");
                }
            }
        }
    }
}
