using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestProgram 
{
    class Emsisoft 
    {
        static void Main(string[] args)
        {
            
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            string downloadPath = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads";
            options.AddUserProfilePreference("safebrowsing.enabled", true);
            options.AddUserProfilePreference("download.default_directory", downloadPath);
            IWebDriver driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("http://emsisoft.com/en/anti-malware-home");
            driver.Manage().Window.Maximize();
            IWebElement element = driver.FindElement(By.XPath("//a[text()='Alternative installation options']"));
            element.Click();

            IWebElement element2 = driver.FindElement(By.XPath("//a[text()='Web installer']"));
            element2.Click();

            Console.WriteLine(element2.Text);

            //Close the browser
            // driver.Close();
        }
    }
}