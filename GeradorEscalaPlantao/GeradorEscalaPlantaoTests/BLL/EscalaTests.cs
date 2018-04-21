using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeradorEscalaPlantao.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorEscalaPlantao.BLL.Tests
{
    [TestClass()]
    public class EscalaTests
    {
        [TestMethod()]
        public void GerarPlataoTest()
        {
            new BLL.Escala().GerarPlatao();
            Assert.Fail();
        }
    }
}