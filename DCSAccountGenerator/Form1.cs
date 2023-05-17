using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace DCSAccountGenerator
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();

        private IWebDriver edDriver;
        private IWebDriver mailDriver;
        private WebDriverWait wait;

        static string jsonString = File.ReadAllText("users.json");
        List<Dictionary<string, object>> userList = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonString);
        private enum AppState { AwaitingInput, AddAccount };
        private AppState _currentAppState = AppState.AwaitingInput;
        private void UpdateState(AppState setState)
        {
            _currentAppState = setState;
            switch (_currentAppState)
            {
                case AppState.AwaitingInput:
                    btnCreate.Enabled = false;
                    btnCancel.Enabled = false;
                    txtUName.Enabled = false;
                    btnNew.Enabled = true;
                    btnActivate.Enabled = true;
                    txtCaptcha.Enabled = false;
                    break;
                case AppState.AddAccount:
                    btnCreate.Enabled = true;
                    btnCancel.Enabled = true;
                    txtUName.Enabled = true;
                    btnNew.Enabled = true;
                    btnActivate.Enabled = false;
                    txtCaptcha.Enabled = true;
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void PopulateListBox()
        {
            foreach (Dictionary<string, object> dict in userList)
            {
                lstAccounts.Items.Add(dict["uname"]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            wait = new WebDriverWait(mailDriver, TimeSpan.FromSeconds(10));
            PopulateListBox();
            lblStatus.Text = string.Empty;

            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            edDriver = new ChromeDriver(driverService, options);
            mailDriver = new ChromeDriver(driverService, options);

        }

        private string DictToString(Dictionary<string, object> dict)
        {
            string retString = $"Username: {dict["uname"]} \nPassword: {dict["pass"]} \nActivated: {dict["activated"]}" +
                $"\nActiavted on: {dict["activeDate"]} \nExpires on: {dict["expiryDate"]}";
            return retString;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateState(AppState.AwaitingInput);
            txtInfo.Text = DictToString(userList[lstAccounts.SelectedIndex]);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UpdateState(AppState.AddAccount);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UpdateState(AppState.AwaitingInput);
            edDriver.Navigate().GoToUrl("https://www.digitalcombatsimulator.com/en/auth/?register=yes");
            mailDriver.Navigate().GoToUrl("https://10minute-email.com/");

            IWebElement form = edDriver.FindElement(By.Name("regform"));

            //get email address
            IWebElement emailAddressElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("i-email")));
            string emailAddress = (string)((IJavaScriptExecutor)mailDriver).ExecuteScript("return arguments[0].value;", emailAddressElement);
            while (emailAddress == "Loading...")
            {
                emailAddress = (string)((IJavaScriptExecutor)mailDriver).ExecuteScript("return arguments[0].value;", emailAddressElement);
            }

            //enter email address
            EnterValueByID(emailAddress, "REGISTER_EMAIL", edDriver);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateState(AppState.AwaitingInput);
            txtUName.Text = string.Empty;
        }
        public static void EnterValueByID(string value, string id, IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id(id));
            element.SendKeys(value);
        }
    }
}