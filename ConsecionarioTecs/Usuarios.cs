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
    public partial class Usuarios : Form
    {
        Conexion_BDD conSQL = new Conexion_BDD();
        int bandera = 0;
        int usuarioxPag = 40;
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dtgvContenedorUsuarios.DataSource = conSQL.retornaRegistros("Select * from Clientes");
        }
    }
}
