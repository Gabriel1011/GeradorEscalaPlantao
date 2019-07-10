using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorEscalaPlantao.Utilitarios
{
    public static class Aquivo
    {
        readonly public static string CaminhoBase = @"C:\GeradorEscala\BaseGeradorEscala";

        public static void GerarArquivosGeradorEscala()
        {
            try
            {
                if (!Directory.Exists(@"C:\GeradorEscala"))
                    Directory.CreateDirectory(@"C:\GeradorEscala");

                if (!File.Exists(CaminhoBase))
                    new Repositorios.Repositorio().GerarJsonFuncionarios(new List<Entidades.Funcionario>());
            }
            catch (Exception ex)
            {

            }
        }
    }
}
