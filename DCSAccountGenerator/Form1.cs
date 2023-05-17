using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DCSAccountGenerator
{
    public partial class Form1 : Form
    {
        static string jsonString = File.ReadAllText("users.json");
        List<Dictionary<string, object>> userList = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonString);
        private enum AppState { AwaitingInput, AddAccount };
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
            PopulateListBox();
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
            txtInfo.Text = DictToString(userList[lstAccounts.SelectedIndex]);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        
    }
}