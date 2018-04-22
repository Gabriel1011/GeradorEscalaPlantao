using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeradorEscalaPlantao.DAO
{
    public class Repositorio
    {
        public List<ENT.Funcionario> GerarListaFuncionario()
        {
            var Funcionarios = new List<ENT.Funcionario>();
            XmlSerializer xml = new XmlSerializer(typeof(List<ENT.Funcionario>));
            using (FileStream fs = new FileStream(@"C:\teste\Funcionarios.xml", FileMode.Open, FileAccess.Read))
            {
                Funcionarios = xml.Deserialize(fs) as List<ENT.Funcionario>;
            }

            return Funcionarios.OrderBy(o => o.Ordem).ToList();
        }

        public void GerarXmlFuncionarios (List<ENT.Funcionario> Funcionarios)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<ENT.Funcionario>));

            using (FileStream fs = new FileStream(@"C:\teste\Funcionarios.xml", FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(fs, Funcionarios);
            }
        }
    }
}
