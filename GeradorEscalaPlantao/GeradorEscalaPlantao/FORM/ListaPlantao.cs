using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorEscalaPlantao.FORM
{
    public partial class ListaPlantao : Form
    {
        public ListaPlantao()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            dtgPlantoes.DataSource = new BLL.Escala().GerarPlatao();
        }
    }
}
