using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://qa-antigo.elefanteletrado.com.br/Account/Login";

            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);

            Thread.Sleep(2000);

            var campoLogin = driver.FindElementById("name");
            campoLogin.SendKeys("asdf");

            Thread.Sleep(2000);

            var botaoEntrar = driver.FindElementByCssSelector("input[type=submit][title='" + "Entrar" + "']");
            botaoEntrar.Click();

            Thread.Sleep(2000);

            var mensagemInvalida = "Usuário não encontrado.";
            var tagErro = driver.FindElementByClassName("error");
            if (tagErro.Text != mensagemInvalida)
            {
                Console.WriteLine("Mensagem errada, veio: " + tagErro.Text + ", esperado: " + mensagemInvalida);
            }
            else
            {
                Console.WriteLine("Validação correta!");
            }
        }
    }
}
