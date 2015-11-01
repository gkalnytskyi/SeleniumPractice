using System;
using System.Diagnostics;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;


namespace ToolSQAAutoPracticeFormFramework
{
    public class AutomationFramework : IDisposable
    {
        private Uri _BaseUrl;

        public readonly int TimeOut;
        public IWebDriver Driver { get; private set; }

        public AutomationFramework(string uri)
        {
            _BaseUrl = new Uri(uri);
            TimeOut = 5;
            Init();
        }

        public void GoToUrl(string relativeUrl)
        {
            var uri = new Uri(_BaseUrl, relativeUrl);
            Driver.Navigate().GoToUrl(uri);
        }

        private void Init()
        {
            StopAllDrivers();

            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            Driver = new ChromeDriver(options);
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(TimeOut));
        }

        private void StopAllDrivers()
        {
            foreach (var process in Process.GetProcessesByName("chromedriver"))
            {
                process.Close();
            }
        }

        #region Dispose pattern
        private bool _Disposed;

        protected void Dispose(bool disposing)
        {
            if (!_Disposed)
            {
                if (disposing)
                {
                    if (Driver != null)
                    {
                        Driver.Close();
                        Driver.Quit();
                        Driver.Dispose();
                    }
                }

                Driver = null;
                _Disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~AutomationFramework()
        {
            Dispose(false);
        }
        #endregion
    }
}
