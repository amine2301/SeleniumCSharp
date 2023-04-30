using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSeleniumProject
{
    public class CustomControl : DriverHelper
    {
        public static void ComboBox(string controlName1,string controlName2, string value)
        {
            IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName1}-awed']"));
            comboControl.Clear();
            comboControl.SendKeys(value);
            Driver.FindElement(By.XPath($"//div[@id='{controlName2}']//li[text()='{value}']")).Click();
        }
    }
}
