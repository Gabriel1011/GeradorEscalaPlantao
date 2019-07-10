using GeradorEscalaPlantao.Entidades;
using GeradorEscalaPlantao.Repositorios;
using GeradorEscalaPlantao.Utilitarios;
using Newtonsoft.Json;
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
        List<Funcionario> Funcionarios = new List<Funcionario>();
        Funcionario funcionario = new Funcionario();

        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();
                SalvarFuncionario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ValidarCampos()
        {
            var noficacoes = new List<string>();
            DateTime inicio = new DateTime();
            DateTime fim = new DateTime();

            if (String.IsNullOrWhiteSpace(txtNome.Text))
                noficacoes.Add("Nome obrigatório");
            if (Convert.ToInt32(numOrdem.Value) > 0)
                noficacoes.Add("A ordem deve ser maior que 1");
            if (!DateTime.TryParse(mskInicioFerias.Text, out inicio) || !DateTime.TryParse(mskFimFerias.Text, out fim))
                noficacoes.Add("A data de início e fim deve ser uma data válida");
            if (fim > inicio)
                noficacoes.Add("A data fim deve ser maior do que a data de início");

            if (noficacoes.Any())
                throw new Exception("Erros: " + noficacoes.Aggregate((A, B) => A + "," + B) + ".");
        }

        private void SalvarFuncionario()
        {
            Funcionarios.Add(new Funcionario()
            {
                Nome = txtNome.Text.Trim().ToUpper(),
                Ordem = numOrdem.Value,
                InicioFerias = Convert.ToDateTime(mskInicioFerias.Text),
                Fimferias = Convert.ToDateTime(mskFimFerias.Text)
            });

            GravarJson();
            funcionario = null;
        }

        private void GravarJson()
        {
            new Repositorio().GerarJsonFuncionarios(Funcionarios);

            dtgFuncionario.DataSource = new List<Funcionario>();
            dtgFuncionario.DataSource = Funcionarios.OrderBy(o => o.Ordem).ToList();
            dtgFuncionario.Refresh();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            using (StreamReader fs = new StreamReader(new FileStream(Aquivo.CaminhoBase, FileMode.Open, FileAccess.Read)))
            {
                //XmlSerializer xml = new XmlSerializer(typeof(List<Funcionario>));
                //Funcionarios = xml.Deserialize(fs) as List<Funcionario>;
                Funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(Convert.ToString(fs.ReadToEnd()));
            }

            dtgFuncionario.DataSource = Funcionarios.OrderBy(o => o.Ordem).ToList();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow funcionario in dtgFuncionario.SelectedRows)
            {
                Funcionarios.Remove(Funcionarios.Where(p => p.Nome == Convert.ToString(funcionario.Cells["Nome"].Value)).FirstOrDefault());
            }
            GravarJson();
        }

        private void dtgFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                funcionario = Funcionarios.Where(p => p.Nome == Convert.ToString(dtgFuncionario.Rows[e.RowIndex].Cells["Nome"].Value)).FirstOrDefault();

                txtNome.Text = funcionario.Nome;
                numOrdem.Value = Convert.ToInt32(funcionario.Ordem);
                mskInicioFerias.Text = funcionario.InicioFerias.ToString();
                mskFimFerias.Text = funcionario.Fimferias.ToString();
            }
        }

        public void RemoverFuncionario()
        {
            if (funcionario != null)
                Funcionarios.Remove(funcionario);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            RemoverFuncionario();
            SalvarFuncionario();
        }
    }
}
