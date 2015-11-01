using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace ToolSQAAutoPracticeFormFramework
{
    public class AutomationPracticeFormPage
    {
        private AutomationFramework _AF;

        private FormWidget form;


        public AutomationPracticeFormPage(AutomationFramework af)
        {
            _AF = af;
            form = new FormWidget(_AF);
        }

        public void EnterFirstName(string firstName)
        {
            form.FistNameTextBox.SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            form.LastNameTextBox.SendKeys(lastName);
        }

        public void SelectGender(Gender g)
        {
            form.SelectGender(g);
        }

        public Gender SelectedGender()
        {
            return form.SelectedGender();
        }
    }
}
