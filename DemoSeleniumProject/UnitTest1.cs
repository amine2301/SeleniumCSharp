using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DemoSeleniumProject 
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("http://demowf.aspnetawesome.com");
            //Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            CustomControl.EnterText(Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")), "Tomato");

            //Driver.FindElement(By.Id("btnCookie")).Click();
            CustomControl.Click(Driver.FindElement(By.Id("btnCookie")));

            //Driver.FindElement(By.XPath("//div[@class='awe-display o-ochk']/ul/li[1]")).Click();
            CustomControl.Click(Driver.FindElement(By.XPath("//div[@class='awe-display o-ochk']/ul/li[1]")));

            CustomControl.SelectByText(Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Artichoke");

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "ContentPlaceHolder1_AllMealsCombo-dropmenu", "Almond");
       
            Console.WriteLine("Test Completed !!!");
            Assert.Pass();
        }
    }
}