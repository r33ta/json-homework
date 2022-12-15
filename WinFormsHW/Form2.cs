using Newtonsoft.Json;
using System.Net;

namespace WinFormsHW
{
    public partial class Form2 : Form
    {
        public class UserName
        {
            public string name;
        }

        public class UserData
        {
            public string icon;
            public string name;
            public string email;
            public int unread;
            public int friends;
            public float rating;
        }
        UserData userData;


        public Form2(string name)
        {
            InitializeComponent();

            WebClient client = new WebClient();
            UserName userName = new UserName{ name = name };


            string json = JsonConvert.SerializeObject(userName);
            string url = "http://194.87.99.14/auth";
            string jwt = client.UploadString(url, json);


            url = "http://194.87.99.14/user";
            string response = client.UploadString(url, jwt);

            userData = JsonConvert.DeserializeObject<UserData>(response);

            l_name.Text = userData.name;
            l_email.Text = userData.email;
            l_friends.Text = userData.friends.ToString();
            l_rating.Text = userData.rating.ToString();
            l_unread.Text = userData.unread.ToString();

            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.ImageLocation = userData.icon;
        }
    }
}