using System;
using System.Collections.Generic;
using NUnit.Framework;
using ToolSQAAutoPracticeFormFramework;

namespace ToolSQAAutoPracticeFormTest
{
    [TestFixture]
    public class Tests_for_SQA_Form
    {
        AutomationFramework af;
        
        [SetUp]
        public void TestSetup()
        {
            af = new AutomationFramework("http://www.toolsqa.com/");
            af.GoToUrl("automation-practice-form/");
        }

        [Test]
        public void Test_Fill_in_Form()
        {
            // Act
            var page = new AutomationPracticeFormPage(af);
            page.SelectGender(Gender.Female);
            page.SelectTestAutomationTool(TestAutomationTools.QTP |
                                          TestAutomationTools.SeleniumWebDriver);
            page.SelectContinent("North America");
            page.SelectSeleniumCommands(new[]
            { "Navigation Commands",
              "Wait Commands",
              "WebElement Commands"
            });
        }

        [TearDown]
        public void TestTearDown()
        {
            af.Dispose();
        }
    }
}
