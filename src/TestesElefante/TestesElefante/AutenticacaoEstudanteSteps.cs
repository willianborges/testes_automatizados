using OpenQA.Selenium.Chrome;
using System.Threading;
using TechTalk.SpecFlow;

namespace TestesElefante
{
    [Binding]
    public class AutenticacaoEstudanteSteps
    {
        private static ChromeDriver driver;

        [BeforeFeature]
        public static void IniciarFuncionalidade()
        {
            var url = "https://qa-antigo.elefanteletrado.com.br/Account/Login";

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);

            Thread.Sleep(2000);
        }

        [AfterFeature]
        public static void EncerrarFuncionalidade()
        {
            driver.Dispose();
        }

        [Given(@"professor ""(.*)""")]
        public void DadoProfessor(string p0)
        {
            var campoLogin = driver.FindElementById("name");
            campoLogin.SendKeys(p0);
        }
        
        [When(@"clicar no botão ""(.*)""")]
        public void QuandoClicarNoBotao(string p0)
        {
            var botaoEntrar = driver.FindElementByCssSelector("input[type=submit][title='" + p0 + "']");
            botaoEntrar.Click();
            Thread.Sleep(1000);
        }
        
        [When(@"selecionar a turma (.*)")]
        public void QuandoSelecionarATurma(int courseName)
        {
            /*var cmbCourseFormat = "//select[@id='CourseId']/option[contains(text(),'{0}')]";
            var itemCombo = browser.FindElement(By.XPath(String.Format(cmbCourseFormat, courseName)));
            itemCombo.Click();
            Thread.Sleep(500);*/

            ScenarioContext.Current.Pending();
        }
        
        [When(@"selecionar o aluno ""(.*)""")]
        public void QuandoSelecionarOAluno(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"informar a senha ""(.*)""")]
        public void QuandoInformarASenha(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"devem entrar na biblioteca do estudante")]
        public void EntaoDevemEntrarNaBibliotecaDoEstudante()
        {
            ScenarioContext.Current.Pending();
        }

        /*
        [Then(@"deve mostrar mensagem ""(.*)""")]
        public void EntaoDeveMostrarMensagem(string p0)
        {
            var tagErro = driver.FindElementByClassName("error");
            Assert.AreEqual(p0, tagErro.Text);
        }
        */
    }
}