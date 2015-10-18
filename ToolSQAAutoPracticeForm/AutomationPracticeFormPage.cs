using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace ToolSQAAutoPracticeFormFramework
{
    class AutomationPracticeFormPage
    {
        private AutomationFramework _AF;

        public AutomationPracticeFormPage(AutomationFramework af)
        {
            _AF = af;
        }

        public class FormWidget
        {
            protected AutomationFramework _AF;
            protected IWebElement BaseElement { get; private set; }

            public FormWidget (AutomationFramework af)
            {
                if (af == null)
                {
                    throw new ArgumentException("Automation framework is not provided");
                }
                _AF = af;
                BaseElement = _AF.Driver.FindElement(By.ClassName("form-horizontal"));
            }
        }
    }
}
