using GeradorEscalaPlantao.Entidades;
using GeradorEscalaPlantao.Utilitarios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace GeradorEscalaPlantao.Repositorios
{
    public class Repositorio
    {
        public List<Funcionario> GerarListaFuncionario()
        {
            var Funcionarios = new List<Funcionario>();
            //XmlSerializer xml = new XmlSerializer(typeof(List<Funcionario>));

            using (StreamReader fs = new StreamReader(new FileStream(Aquivo.CaminhoBase, FileMode.Open, FileAccess.Read)))
            {
                //Funcionarios = xml.Deserialize(fs) as List<Funcionario>;
                Funcionarios = JsonConvert.DeserializeObject<List<Funcionario>>(fs.ReadToEnd());
            }

            return Funcionarios.OrderBy(o => o.Ordem).ToList();
        }

        public void GerarJsonFuncionarios (List<Funcionario> Funcionarios)
        {
            //XmlSerializer xml = new XmlSerializer(typeof(List<Funcionario>));
            var json = new JsonSerializer();

            using (StreamWriter fs = new StreamWriter(new FileStream(Aquivo.CaminhoBase, FileMode.Create, FileAccess.Write)))
            {
                //xml.Serialize(fs, Funcionarios);
                json.Serialize(fs, Funcionarios);
            }
        }
    }
}
