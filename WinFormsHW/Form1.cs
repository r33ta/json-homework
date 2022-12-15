using Newtonsoft.Json;
using System.Net;

namespace WinFormsHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string fullName = textbox.Text;
            string url = "http://194.87.99.14/students";


            WebClient client = new WebClient();
            List<string> students = new List<string>();


            string json = client.DownloadString(url);
            students.AddRange(JsonConvert.DeserializeObject<List<string>>(json));


            if (students.Contains(fullName))
            {
                Form2 form = new Form2(fullName);
                form.Show();
            }
            else
            {
                errorlabel.Text = "Ошибка! Неправильный ввод";
            }
        }
    }
}