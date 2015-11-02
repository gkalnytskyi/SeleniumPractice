using System;
using System.Collections.Generic;
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

        public void SelectTestAutomationTool(TestAutomationTools autoTool)
        {
            form.SelectTestAutomationTool(autoTool);
        }

        public void SelectContinent(string continent)
        {
            form.SelectContinent(continent);
        }

        public void SelectSeleniumCommands(IEnumerable<string> commands)
        {
            form.SelectSeleniumCommands(commands);
        }
    }
}
