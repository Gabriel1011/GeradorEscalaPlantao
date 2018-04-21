using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GeradorEscalaPlantao.FORM
{
    public partial class CadastroFuncionario : Form
    {
        List<ENT.Funcionario> Funcionarios = new List<ENT.Funcionario>();

        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<ENT.Funcionario>));


            Funcionarios.Add(new ENT.Funcionario()
            {
                Nome = txtNome.Text.Trim().ToUpper(),
                Ordem = numOrdem.Value,
                InicioFerias = Convert.ToDateTime(mskInicioFerias.Text),
                Fimferias = Convert.ToDateTime(mskFimFerias.Text)
            });

            using (FileStream fs = new FileStream(@"C:\teste\Funcionarios.xml", FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(fs, Funcionarios);
            }

            dtgFuncionario.DataSource = new List<ENT.Funcionario>();
            dtgFuncionario.DataSource = Funcionarios;
            dtgFuncionario.Refresh();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<ENT.Funcionario>));
            using (FileStream fs = new FileStream(@"C:\teste\Funcionarios.xml", FileMode.Open, FileAccess.Read))
            {
                Funcionarios = xml.Deserialize(fs) as List<ENT.Funcionario>;
            }

            dtgFuncionario.DataSource = Funcionarios;
        }
    }
}
