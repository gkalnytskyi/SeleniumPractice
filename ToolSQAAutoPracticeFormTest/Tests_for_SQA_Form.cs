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
        public void Test_Select_Gender()
        {
            var page = new AutomationPracticeFormPage(af);
            page.SelectGender(Gender.Female);
        }

        [TearDown]
        public void TestTearDown()
        {
            af.Dispose();
        }
    }
}
