using ConsecionarioTecs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioDeInicio
{
    public partial class Compras : Form
    {
        

        Conexion_BDD conSQL = new Conexion_BDD();
        int bandera = 0;
        int ComprasxPag = 40;
        public Compras()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Compras_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dtgvContendorCompras.DataSource = conSQL.retornaRegistros("Select * from ComprasProveedores");
        }

        private void dtgvContendorCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbtnAgregarComprasProvedores_Click(object sender, EventArgs e)
        {
            AgregarCompras AggComProvedores = new AgregarCompras();
            this.AddOwnedForm(AggComProvedores);
            AggComProvedores.Show();
        }
    }
}
