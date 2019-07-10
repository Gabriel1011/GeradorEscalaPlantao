using GeradorEscalaPlantao.Entidades;
using GeradorEscalaPlantao.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorEscalaPlantao.Servicos
{
    public class Escala
    {
        public List<Plantao> GerarPlatao()
        {
            var Funcionarios = new Repositorio().GerarListaFuncionario().OrderBy(o => o.Ordem).ToList();
            var platoes = new List<Plantao>();
            var diasAno = GerarDiasDoAno(DateTime.Now.Year);
            var todasSegundas = diasAno.Where(p => p.DayOfWeek == DayOfWeek.Monday);
            var todosDomingos = diasAno.Where(p => p.DayOfWeek == DayOfWeek.Sunday).ToList();

            var cont = 0;//Funcionarios.Count();
            foreach (var segunda in todasSegundas)
            {
                if (Funcionarios[cont].InicioFerias <= segunda && Funcionarios[cont].Fimferias >= segunda)
                    cont++;

                if (cont == Funcionarios.Count())
                    cont = 0;

                platoes.Add(new Plantao()
                {
                    InicioPlantao = segunda,
                    NomePlantonista = Funcionarios[cont].Nome
                });

                cont++;
                if (cont == Funcionarios.Count())
                    cont = 0;
            }

            foreach (var plantao in platoes)
                plantao.FimPlantao = todosDomingos.Where(p => p == plantao.InicioPlantao.AddDays(6)).FirstOrDefault();

            return platoes;
        }

        public List<DateTime> GerarDiasDoAno(int ano)
        {
            var dias = new List<DateTime>();
            for (int mes = 1; mes <= 12; mes++) 
                dias.AddRange(Enumerable.Range(1, DateTime.DaysInMonth(ano, mes))  // Days: 1, 2 ... 31 etc.
                    .Select(day => new DateTime(ano, mes, day)) // Map each day to a date
                    .ToList()); // Load dates into a list
            
            return dias;
        }
    }
}
