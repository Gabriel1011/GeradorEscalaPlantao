using GeradorEscalaPlantao.Entidades;
using System.Collections.Generic;

namespace GeradorEscalaPlantao.Repositorios
{
    public class FakeRepositorio
    {
        public List<Funcionario> GerarListaFuncionario()
        {
            var funcionarios = new List<Funcionario>();

            funcionarios.Add(new Funcionario() {
                Nome = "Fulano",
                Ordem = 1
            });

            funcionarios.Add(new Funcionario()
            {
                Nome = "Beltrano",
                Ordem = 2
            });

            funcionarios.Add(new Funcionario()
            {
                Nome = "Siclano",
                Ordem = 3
            });

            return funcionarios;
        }
    }
}
