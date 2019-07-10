using GeradorEscalaPlantao.FORM;
using GeradorEscalaPlantao.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorEscalaPlantao
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Aquivo.GerarArquivosGeradorEscala();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            Application.Run(new ListaPlantao());
        }
    }
}
