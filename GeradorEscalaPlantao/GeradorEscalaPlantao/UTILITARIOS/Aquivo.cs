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
            if(!Directory.Exists(@"C:\GeradorEscala"))
            {
                try
                {
                    Directory.CreateDirectory(@"C:\GeradorEscala");
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
