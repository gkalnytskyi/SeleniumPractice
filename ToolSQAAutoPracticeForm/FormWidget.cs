using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace ToolSQAAutoPracticeFormFramework
{
    public class FormWidget
    {
        protected AutomationFramework _AF;
        protected IWebElement BaseElement { get; private set; }

        public FormWidget(AutomationFramework af)
        {
            if (af == null)
            {
                throw new ArgumentException("Automation framework is not provided");
            }
            _AF = af;
            BaseElement = _AF.Driver.FindElement(By.ClassName("form-horizontal"));
        }

        public IWebElement FistNameTextBox
        {
            get
            {
                return BaseElement.FindElement(By.Name("firstname"));
            }
        }

        public IWebElement LastNameTextBox
        {
            get
            {
                return BaseElement.FindElement(By.Name("lastname"));
            }
        }
    }
}
