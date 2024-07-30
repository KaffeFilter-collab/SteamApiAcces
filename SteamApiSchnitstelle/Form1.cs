using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace SteamApiSchnitstelle
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        //string usedUrl = "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?appid=230410&count=3&maxlength=300&format=json";
        string usedUrlForName = "https://store.steampowered.com/api/appdetails?appids=";
        int index;

        string usedURLPartOne = "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?appid=";
        string usedURLPartTwo = "&count=3&maxlength=300&format=json";
        public int appID = 230410;  
        public Form1()
        {
            InitializeComponent();
            GetGameInfo();
            Refresh();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            GetGameInfo();
        }

        private void btnGoLeft_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
            }
            if (index == -1)
            {
                index = 2;
            }
            Refresh();
            GetGameInfo();

        }

        private void btnGoRight_Click(object sender, EventArgs e)
        {
            if(index == 2)
            {
                index = -1;
            }
            if(index < 3)
            {
                index++;
            }
            Refresh();
            GetGameInfo();

        }

        private async void Refresh()
        {
            var json = await client.GetStringAsync(usedURLPartOne+appID+usedURLPartTwo);
            Console.Out.WriteLine(json);
            if (json != null)
            {
                JToken updateItems = JObject.Parse(json)["appnews"]["newsitems"];
                DateTimeOffset date = DateTimeOffset.FromUnixTimeSeconds((int)updateItems[index]["date"]);
                lblDatum.Text = date.LocalDateTime.ToString();
                lblTitle.Text = updateItems[index]["title"].ToString();
                rbtcontent.Text = updateItems[index]["contents"].ToString();
            }
        }

        private async void GetGameInfo()
        {
            var gameInfo = await client.GetStringAsync(usedUrlForName + appID);
            if (gameInfo != null)
            {
                JToken jToken = JObject.Parse(gameInfo)[appID.ToString()]["data"];
                lblGameName.Text = jToken["name"].ToString();
            }
        }

        private void btnOpenSettings_Click(object sender, EventArgs e)
        {
            fmSettings fs = new fmSettings(this);
            fs.ShowDialog();
        }
    }
}
