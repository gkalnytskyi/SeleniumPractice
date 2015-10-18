using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace ToolSQAAutoPracticeFormFramework
{
    class AutomationPracticeFormPage
    {
        private AutomationFramework _AF;

        private FormWidget form;


        public AutomationPracticeFormPage(AutomationFramework af)
        {
            _AF = af;
        }

        public void EnterFirstName(string firstName)
        {
            form.FistNameTextBox.SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            form.LastNameTextBox.SendKeys(lastName);
        }


    }
}
