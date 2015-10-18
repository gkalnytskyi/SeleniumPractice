using System;

namespace ToolSQAAutoPracticeFormFramework
{
    public enum Gender
    {
        Male,
        Female
    }

    [Flags]
    public enum TestProfession
    {
        None = 0x0,
        ManualTester = 0x1,
        AutomationTester = 0x2
    }

    [Flags]
    public enum TestAutomationTools
    {
        None = 0x0,
        QTP = 0x1,
        SeleniumIde = 0x2,
        SeleniumWebDriver = 0x4
    }
}
