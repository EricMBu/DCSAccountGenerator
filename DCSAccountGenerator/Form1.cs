using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using System.Net.Mail;
using OpenQA.Selenium.Edge;
using System.Reflection.Metadata;

namespace DCSAccountGenerator
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();

        string fileName = "..\\..\\..\\XPaths.txt";
        string[] XPaths;

        private IWebDriver edDriver;
        private IWebDriver mailDriver;
        private WebDriverWait wait;
        private WebDriverWait edWait;

        string jsonString;
        List<Dictionary<string, object>> userList;
        private enum AppState { AwaitingInput, AddAccount, EmptySelection };
        private AppState _currentAppState = AppState.AwaitingInput;
        private void UpdateState(AppState setState)
        {
            _currentAppState = setState;
            switch (_currentAppState)
            {
                case AppState.AwaitingInput:
                    lstAccounts.Enabled = true;
                    btnCreate.Enabled = false;
                    btnCancel.Enabled = false;
                    txtUName.Enabled = false;
                    btnNew.Enabled = true;
                    btnActivate.Enabled = true;
                    txtCaptcha.Enabled = false;
                    btnCopyPass.Enabled = true;
                    btnCopyUname.Enabled = true;
                    btnDelete.Enabled = true;
                    break;
                case AppState.AddAccount:
                    lstAccounts.Enabled = false;
                    btnCreate.Enabled = true;
                    btnCancel.Enabled = true;
                    txtUName.Enabled = true;
                    btnNew.Enabled = true;
                    btnActivate.Enabled = false;
                    txtCaptcha.Enabled = true;
                    btnCopyPass.Enabled = false;
                    btnCopyUname.Enabled = false;
                    btnDelete.Enabled = false;
                    break;
                case AppState.EmptySelection:
                    lstAccounts.Enabled = true;
                    btnCreate.Enabled = false;
                    btnCancel.Enabled = false;
                    txtUName.Enabled = false;
                    btnNew.Enabled = true;
                    btnActivate.Enabled = false;
                    txtCaptcha.Enabled = false;
                    btnCopyPass.Enabled = false;
                    btnCopyUname.Enabled = false;
                    btnDelete.Enabled = false;
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
            lblCaptchaStatus.Text = string.Empty;
            XPaths = File.ReadAllLines(fileName);
            try
            {
                jsonString = File.ReadAllText("users.json");
            }
            catch (Exception ex)
            {
                File.WriteAllText("users.json", "[]");
                jsonString = File.ReadAllText("users.json");
            }
            userList = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonString);
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");

            PopulateListBox();
            lblStatus.Text = string.Empty;

            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            edDriver = new ChromeDriver(driverService, options);
            mailDriver = new ChromeDriver(driverService, options);
            wait = new WebDriverWait(mailDriver, TimeSpan.FromSeconds(10));
            edWait = new WebDriverWait(edDriver, TimeSpan.FromSeconds(10));

        }

        private string DictToString(Dictionary<string, object> dict)
        {
            string retString = $"Username: {dict["uname"]} \nPassword: {dict["pass"]} \nActivated: {dict["activated"]}" +
                $"\nActiavted on: {dict["activeDate"]} \nExpires on: {dict["expiryDate"]}";
            return retString;
        }

        private void lstAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstAccounts.SelectedIndex < 0)
            {
                UpdateState(AppState.EmptySelection);
                txtInfo.Text = string.Empty;

            }
            else
            {
                UpdateState(AppState.AwaitingInput);
                txtInfo.Text = DictToString(userList[lstAccounts.SelectedIndex]);
                btnActivate.Enabled = !(bool)userList[lstAccounts.SelectedIndex]["activated"];
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UpdateState(AppState.AddAccount);

            txtInfo.Text = string.Empty;


            lblStatus.Text = "Loading sign-in page...";
            edDriver.Manage().Cookies.DeleteAllCookies();
            Thread.Sleep(3000);
            edDriver.Navigate().GoToUrl("https://www.digitalcombatsimulator.com/en/auth/?register=yes");

            //Captcha
            lblStatus.Text = "Loading captcha...";
            LoadCaptcha();

            lblStatus.Text = "Ready";

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            lblCaptchaStatus.Text = string.Empty;

            string unameIn = txtUName.Text;
            if (unameIn.Length < 5)
            {
                txtUName.BackColor = Color.Salmon;
                txtInfo.Text = "Username must be at least 5 characters";
            }
            else
            {
                lblStatus.Text = "Generating email...";
                //mailDriver.Manage().Cookies.DeleteAllCookies();
                //Thread.Sleep(3000);
                mailDriver.Navigate().GoToUrl("https://10minute-email.com/");
                IWebElement newAddress = mailDriver.FindElement(By.XPath("//*[@id=\"mailapp\"]/div[1]/div[3]/button"));
                newAddress.Click();
                IWebElement confirm = mailDriver.FindElement(By.XPath("//*[@id=\"mailapp\"]/div[1]/div[4]/div[1]/div[3]/button[2]"));
                confirm.Click();

                IWebElement form = edDriver.FindElement(By.Name("regform"));

                //username
                string uname = unameIn + rand.Next(0, 1000000).ToString("D5");
                EnterValueByID(uname, "REGISTER_LOGIN", edDriver);

                //password
                string password = "H" + Guid.NewGuid().ToString("d").Substring(1, 15);
                Console.WriteLine($"Your generated password is: {password}");
                EnterValueByID(password, "REGISTER_PASSWORD", edDriver);
                EnterValueByID(password, "REGISTER_CONFIRM_PASSWORD", edDriver);

                //get email address
                IWebElement emailAddressElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("i-email")));
                string emailAddress = (string)((IJavaScriptExecutor)mailDriver).ExecuteScript("return arguments[0].value;", emailAddressElement);
                while (emailAddress == "Loading...")
                {
                    emailAddress = (string)((IJavaScriptExecutor)mailDriver).ExecuteScript("return arguments[0].value;", emailAddressElement);
                }

                //enter email address
                EnterValueByID(emailAddress, "REGISTER_EMAIL", edDriver);

                //enter captcha
                string captchaText = txtCaptcha.Text;
                EnterValueByID(captchaText.ToUpper(), "captcha_word", edDriver);

                form.Submit();

                string message = edDriver.FindElement(By.XPath("/html/body/div[4]/div[1]")).Text;
                if (message.Contains("automatic registration"))
                {
                    lblCaptchaStatus.Text = "incorrect captcha";
                    lblStatus.Text = string.Empty;
                    LoadCaptcha();
                }
                else
                {
                    //navigate to confirmation link
                    Thread.Sleep(1500);
                    IWebElement refreshButton = mailDriver.FindElement(By.XPath("//*[@id=\"mailapp\"]/div[2]/div/button"));
                    refreshButton.Click();


                    IWebElement emailBox = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("mail-item")));
                    emailBox.Click();

                    IWebElement emailiframe = mailDriver.FindElement(By.Id("fullmessage"));
                    mailDriver.SwitchTo().Frame(emailiframe);

                    IWebElement confirmLink = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/p[3]/a")));
                    confirmLink.Click();

                    //close extra 
                    mailDriver.SwitchTo().Window(mailDriver.WindowHandles[1]);
                    Thread.Sleep(1000);
                    mailDriver.Close();
                    mailDriver.SwitchTo().Window(mailDriver.WindowHandles[0]);

                    lblStatus.Text = "Account successfully created";

                    //Write new user to JSON file
                    Dictionary<string, object> newUser = new Dictionary<string, object>()
                    {
                        {"uname", uname },
                        {"pass", password },
                        {"activated", false},
                        {"activeDate", "N/A" },
                        {"expiryDate", "N/A" }
                    };

                    userList.Add(newUser);
                    string updatedJsonString = JsonConvert.SerializeObject(userList, Formatting.Indented);
                    File.WriteAllText("users.json", updatedJsonString);

                    lstAccounts.Items.Add(uname);
                    txtUName.Text = string.Empty;
                    imgCaptcha.Image = null;

                    UpdateState(AppState.AwaitingInput);

                    lstAccounts.SelectedIndex = lstAccounts.Items.Count - 1;

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateState(AppState.AwaitingInput);
            txtUName.Text = string.Empty;
            txtCaptcha.Text = string.Empty;
            imgCaptcha.Image = null;
            lblCaptchaStatus.Text = string.Empty;
        }
        public static void EnterValueByID(string value, string id, IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id(id));
            element.Clear();
            element.SendKeys(value);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            edDriver.Close();
            mailDriver.Close();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Clearing cookies...";

            edDriver.Manage().Cookies.DeleteAllCookies();
            Thread.Sleep(3000);
            edDriver.Navigate().GoToUrl("https://www.digitalcombatsimulator.com/en/");

            lblStatus.Text = "Signing in...";

            //enter uname and password
            Dictionary<string, object> dict = userList[lstAccounts.SelectedIndex];
            string uname = (string)dict["uname"];
            string password = (string)dict["pass"];

            IWebElement loginButton = edDriver.FindElement(By.XPath("//*[@id=\"login-line\"]/a"));
            loginButton.Click();
            IWebElement loginForm = edDriver.FindElement(By.XPath("//*[@id=\"bx_auth_popup_form\"]/form"));
            EnterValueByID(uname, "USER_LOGIN", edDriver);
            EnterValueByID(password, "USER_PASSWORD", edDriver);
            loginForm.Submit();

            lblStatus.Text = "Activating trials...";
            edDriver.Navigate().GoToUrl("https://www.digitalcombatsimulator.com/en/personal/licensing/trial/?SHOWALL_1=1");

            IWebElement closeCookies = edWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"cookies\"]/div[1]/button")));
            closeCookies.Click();
            foreach (string XPath in XPaths)
            {
                try
                {
                    IWebElement button = edDriver.FindElement(By.XPath(XPath));
                    button.Click();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            lblStatus.Text = "Trials activated";

            DateTime activatedDate = DateTime.Now;
            string activated = activatedDate.ToString("MM/dd/yyyy HH:mm");
            string expiry = activatedDate.AddDays(15).ToString("MM/dd/yyyy HH:mm");
            userList[lstAccounts.SelectedIndex]["activated"] = true;
            userList[lstAccounts.SelectedIndex]["activeDate"] = activated;
            userList[lstAccounts.SelectedIndex]["expiryDate"] = expiry;
            string updatedJsonString = JsonConvert.SerializeObject(userList, Formatting.Indented);
            File.WriteAllText("users.json", updatedJsonString);
        }

        private void txtUName_TextChanged(object sender, EventArgs e)
        {
            txtUName.BackColor = Color.White;
        }

        private void LoadCaptcha()
        {
            //edDriver.Navigate().GoToUrl("https://www.digitalcombatsimulator.com/en/auth/?register=yes");
            IWebElement captcha = edDriver.FindElement(By.Id("captcha-img"));
            string captchaURL = captcha.GetAttribute("src");
            imgCaptcha.Load(captchaURL);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstAccounts.SelectedIndex;
            userList.RemoveAt(index);
            lstAccounts.Items.RemoveAt(index);
            lstAccounts.SelectedIndex = index - 1;

            string updatedJsonString = JsonConvert.SerializeObject(userList, Formatting.Indented);
            File.WriteAllText("users.json", updatedJsonString);
        }

        private void btnCopyUname_Click(object sender, EventArgs e)
        {
            string uName = (string)userList[lstAccounts.SelectedIndex]["uname"];
            Clipboard.SetText(uName);
            lblStatus.Text = $"\'{uName}\' copied to clipboard";
        }

        private void btnCopyPass_Click(object sender, EventArgs e)
        {
            string pass = (string)userList[lstAccounts.SelectedIndex]["pass"];
            Clipboard.SetText(pass);
            lblStatus.Text = $"\'{pass}\' copied to clipboard";
        }
    }
}