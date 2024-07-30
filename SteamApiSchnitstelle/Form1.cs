using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace SteamApiSchnitstelle
{
    public partial class FsStartpage : Form
    {
        private static readonly HttpClient client = new HttpClient();

        string usedUrlForName = "https://store.steampowered.com/api/appdetails?appids=";
        string usedURLForPlayerCount = "https://api.steampowered.com/ISteamUserStats/GetNumberOfCurrentPlayers/v1/?appid=";
        string usedURLPartOne = "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?appid=";
        string usedURLPartTwo = "&count=3&maxlength=3000&format=json";

        int index;
        private string appid;
        public string userid;
        public string userapikey;

        public string AppId
        {
            get; set;
        }
        public FsStartpage()
        {
            InitializeComponent();
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
            if (appid !=null && appid != "")
            {
                var json = await client.GetStringAsync(usedURLPartOne + appid + usedURLPartTwo);
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
        }

        private async void GetGameInfo()
        {
            if (appid != null && appid != "")
            {
                var gameInfo = await client.GetStringAsync(usedUrlForName + appid);
                if (gameInfo != null)
                {
                    JToken jToken = JObject.Parse(gameInfo)[appid.ToString()]["data"];
                    lblGameName.Text = jToken["name"].ToString();
                }
                var playerCount = await client.GetStringAsync(usedURLForPlayerCount + appid);
                    if(playerCount != null)
                {
                    JToken jtPlayerCounter = JObject.Parse(playerCount)["response"]["player_count"];
                    lblPlayerCount.Text = "Playercount: "+jtPlayerCounter.ToString();
                }

               
            }
        }

        private void btnOpenSettings_Click(object sender, EventArgs e)
        {
            fmSettings fs = new fmSettings();
            fs.FormClosed += (s, evt) =>
            {
                appid = fs.settingsAppId;
                userid = fs.settingsUserID;
                userapikey = fs.settingsApiKey;
                Console.WriteLine(appid);
                if (appid != null)
                {
                    GetGameInfo();
                    Refresh();
                }
            };
            fs.ShowDialog();
        }

        private void btnYourGames_Click(object sender, EventArgs e)
        {
           
            fmGameList fm = new fmGameList(userid, userapikey);
            fm.ShowDialog();
        }
    }
}
