using BlueSkyProject2.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyProjectDataDriven.PageObjects
{
    class DataTablePage
    {
        IWebDriver driver;

        IWebElement emailAddress => driver.FindElement(By.Name("email"));

        IWebElement passwordText => driver.FindElement(By.Id("nf-field-144"));

        public DataTablePage()
        {
            driver = Hook.driver;
        }

        public void EnterEmailAndPassword(string email, string password)
        {
            emailAddress.SendKeys(email);
            passwordText.SendKeys(password);
        }
    }
}
