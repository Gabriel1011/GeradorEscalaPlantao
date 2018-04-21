using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorEscalaPlantao.DAO
{
    public class FakeRepositorio
    {
        public List<ENT.Funcionario> GerarListaFuncionario()
        {
            var funcionarios = new List<ENT.Funcionario>();

            funcionarios.Add(new ENT.Funcionario() {
                Nome = "Fulano",
                Ordem = 1
            });

            funcionarios.Add(new ENT.Funcionario()
            {
                Nome = "Beltrano",
                Ordem = 2
            });

            funcionarios.Add(new ENT.Funcionario()
            {
                Nome = "Siclano",
                Ordem = 3
            });

            return funcionarios;
        }
    }
}
