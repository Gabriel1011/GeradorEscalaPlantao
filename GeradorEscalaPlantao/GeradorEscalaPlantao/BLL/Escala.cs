﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorEscalaPlantao.BLL
{
    public class Escala
    {
        public List<ENT.Plantao> GerarPlatao()
        {
            var Funcionarios = new DAO.FakeRepositorio().GerarListaFuncionario().OrderBy(o => o.Ordem).ToList();
            var platoes = new List<ENT.Plantao>();
            var diasAno = GerarDiasDoAno(DateTime.Now.Year);
            var todasSegundas = diasAno.Where(p => p.DayOfWeek == DayOfWeek.Monday);
            var todosDomingos = diasAno.Where(p => p.DayOfWeek == DayOfWeek.Sunday).ToList();

            var cont = 0;//Funcionarios.Count();
            foreach (var segunda in todasSegundas)
            {
                platoes.Add(new ENT.Plantao()
                {
                    InicioPlantao = segunda,
                    NomePlantonista = Funcionarios[cont].Nome
                });

                cont++;
                if (cont == Funcionarios.Count())
                    cont = 0;
            }

            foreach (var plantao in platoes)
            {
                plantao.FimPlantao = todosDomingos.Where(p => p == plantao.InicioPlantao.AddDays(6)).FirstOrDefault();
            }

            return platoes; 
        }

        public List<DateTime> GerarDiasDoAno(int ano)
        {
            var dias = new List<DateTime>();

            for (int mes = 1; mes <= 12; mes++)
            {
                dias.AddRange(Enumerable.Range(1, DateTime.DaysInMonth(ano, mes))  // Days: 1, 2 ... 31 etc.
                    .Select(day => new DateTime(ano, mes, day)) // Map each day to a date
                    .ToList()); // Load dates into a list
            }

            return dias;
        }
    }
}
