using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class Program
{
    static void Main()
    {
        string url = "https://testing.todorvachev.com/special-elements/alert-box/";
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        IAlert alert = driver.SwitchTo().Alert();

        System.Console.WriteLine(alert.Text);
        alert.Accept();

        IWebElement element = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));
        if(element.Displayed)
        {
            System.Console.WriteLine("Alert was successfully accepted");
        }
        else
        {
            System.Console.WriteLine("Alert was NOT accepted");
        }

        Thread.Sleep(3000);

        driver.Quit();
    }
}

