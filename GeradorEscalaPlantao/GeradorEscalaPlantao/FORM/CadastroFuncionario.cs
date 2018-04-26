using GeradorEscalaPlantao.Utilitarios;
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
        ENT.Funcionario funcionario = new ENT.Funcionario();

        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarFuncionario();
        }

        private void SalvarFuncionario()
        {
            Funcionarios.Add(new ENT.Funcionario()
            {
                Nome = txtNome.Text.Trim().ToUpper(),
                Ordem = numOrdem.Value,
                InicioFerias = Convert.ToDateTime(mskInicioFerias.Text),
                Fimferias = Convert.ToDateTime(mskFimFerias.Text)
            });

            GravarXml();
            funcionario = null;
        }

        private void GravarXml()
        {
            new DAO.Repositorio().GerarXmlFuncionarios(Funcionarios);

            dtgFuncionario.DataSource = new List<ENT.Funcionario>();
            dtgFuncionario.DataSource = Funcionarios.OrderBy(o => o.Ordem).ToList();
            dtgFuncionario.Refresh();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(Aquivo.CaminhoBase, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<ENT.Funcionario>));
                Funcionarios = xml.Deserialize(fs) as List<ENT.Funcionario>;
            }


            dtgFuncionario.DataSource = Funcionarios.OrderBy(o => o.Ordem).ToList();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow funcionario in dtgFuncionario.SelectedRows)
            {
                Funcionarios.Remove(Funcionarios.Where(p => p.Nome == Convert.ToString(funcionario.Cells["Nome"].Value)).FirstOrDefault());
            }

            GravarXml();
        }

        private void dtgFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                funcionario = Funcionarios.Where(p => p.Nome == Convert.ToString(dtgFuncionario.Rows[e.RowIndex].Cells["Nome"].Value)).FirstOrDefault();

                txtNome.Text = funcionario.Nome;
                numOrdem.Value = funcionario.Ordem;
                mskInicioFerias.Text = funcionario.InicioFerias.ToString();
                mskFimFerias.Text = funcionario.Fimferias.ToString();
            }
        }

        public void RemoverFuncionario()
        {
            if (funcionario != null)
            {
                Funcionarios.Remove(funcionario);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            RemoverFuncionario();
            SalvarFuncionario();
        }
    }
}
