using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using AutoIt;
using System.Threading;

namespace WindowsAuthenticationWithAutoit
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://localhost/Home/StephenSecrets");
            Thread.Sleep(500); //if required 
            AutoItX.WinWaitActive("Windows Security");
            AutoItX.ControlSetText("Windows Security", "", "Edit1", "TestUser");
            AutoItX.ControlSetText("Windows Security", "", "Edit2", "Password_test");
            AutoItX.Send("{ENTER}");
        }
    }
}
