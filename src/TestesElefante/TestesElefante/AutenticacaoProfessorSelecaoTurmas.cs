using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TechTalk.SpecFlow;

namespace TestesElefante
{
    [Binding]
    public class AutenticacaoEstudanteSteps
    {

        [When(@"selecionar turma ""(.*)""")]
        public void QuandoSelecionarTurma(int p0)
        {
            var selecaoTurma = driver.FindElementById("loginRosterTab");
            selecaoTurma.Click();
        }
        
        [Then(@"devem ser exibidos os ""(.*)""")]
        public void EntaoDevemSerExibidosOs(string p0)
        {
            var exibeAlunos = driver.FindElementByClassName("el-user-pic");
        }
    }
}
