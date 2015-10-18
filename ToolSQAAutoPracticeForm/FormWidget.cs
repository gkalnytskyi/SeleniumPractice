using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace ToolSQAAutoPracticeFormFramework
{
    public abstract class BaseWidget
    {
        protected IWebElement BaseElement { get; private set; }

        public BaseWidget(AutomationFramework af, By findBy)
        {
            if (af == null || findBy == null)
            {
                throw new ArgumentException("Automation framework or search criteria are not provided");
            }
            BaseElement = af.Driver.FindElement(findBy);
        }
    }
    
    public class FormWidget : BaseWidget
    {
        public FormWidget(AutomationFramework af) :
            base(af, By.ClassName("form-horizontal")) { }

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

        public void SelectGender(Gender sex)
        {
            var genderRadioButtonId = "sex-" + ((int)sex).ToString();
            BaseElement.FindElement(By.Id(genderRadioButtonId)).Click();
        }

        public void SelectYearsOfExperience (int years)
        {
            if (years < 1 || years > 7)
            {
                throw new ArgumentOutOfRangeException("Years of experience cannot be less than 1 or more than 7");
            }
            var yearsOfExperienceRadioButtonId = "exp-" + (years - 1).ToString();
            BaseElement.FindElement(By.Id(yearsOfExperienceRadioButtonId)).Click();
        }

        public IWebElement DateTextBox
        {
            get
            {
                return BaseElement.FindElement(By.Id("datepicker"));
            }
        }

        public void SelectTestProfession(TestProfession profession)
        {
            const string testProfessionCheckBoxIdTemplate = "profession-";
            if (profession.HasFlag(TestProfession.ManualTester))
            {
                BaseElement.FindElement(By.Id(testProfessionCheckBoxIdTemplate+0)).Click();
            }

            if (profession.HasFlag(TestProfession.AutomationTester))
            {
                BaseElement.FindElement(By.Id(testProfessionCheckBoxIdTemplate + 1)).Click();
            }
        }

        public IWebElement UploadPhotoButton
        {
            get
            {
                return BaseElement.FindElement(By.Id("photo"));
            }
        }

        public void SelectTestAutomationTool(TestAutomationTools autoTool)
        {
            const string automationToolCheckboxIdTemplate = "tool-";

            switch (autoTool)
            {
                case TestAutomationTools.QTP:
                    BaseElement.FindElement(By.Id(automationToolCheckboxIdTemplate + 0));
                    break;
                case TestAutomationTools.SeleniumIde:
                    BaseElement.FindElement(By.Id(automationToolCheckboxIdTemplate + 1));
                    break;
                case TestAutomationTools.SeleniumWebDriver:
                    BaseElement.FindElement(By.Id(automationToolCheckboxIdTemplate + 2));
                    break;
                case TestAutomationTools.QTP | TestAutomationTools.SeleniumIde:
                    BaseElement.FindElement(By.Id(automationToolCheckboxIdTemplate + 0));
                    BaseElement.FindElement(By.Id(automationToolCheckboxIdTemplate + 1));
                    break;
                case TestAutomationTools.QTP | TestAutomationTools.SeleniumWebDriver:
                    BaseElement.FindElement(By.Id(automationToolCheckboxIdTemplate + 0));
                    BaseElement.FindElement(By.Id(automationToolCheckboxIdTemplate + 2));
                    break;
                case TestAutomationTools.SeleniumIde | TestAutomationTools.SeleniumWebDriver:
                    BaseElement.FindElement(By.Id(automationToolCheckboxIdTemplate + 1));
                    BaseElement.FindElement(By.Id(automationToolCheckboxIdTemplate + 2));
                    break;
                case TestAutomationTools.QTP |
                     TestAutomationTools.SeleniumIde |
                     TestAutomationTools.SeleniumWebDriver:
                    BaseElement.FindElement(By.Id(automationToolCheckboxIdTemplate + 0));
                    BaseElement.FindElement(By.Id(automationToolCheckboxIdTemplate + 1));
                    BaseElement.FindElement(By.Id(automationToolCheckboxIdTemplate + 2));
                    break;
            }
        }

        public IWebElement ContinentsSelectBox
        {
            get
            {
                return BaseElement.FindElement(By.Id("continents"));
            }
        }

        public IWebElement SeleniumCommandMultiSelectBox
        {
            get
            {
                return BaseElement.FindElement(By.Id("selenium_commands"));
            }
        }
    }
}
