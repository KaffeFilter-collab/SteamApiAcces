using Newtonsoft.Json.Linq;
using SteamWebAPI2.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamApiSchnitstelle
{
    public partial class fmGameList : Form
    {
        private static readonly HttpClient client = new HttpClient();

        private string gameListUserId;
        private string gameListUserApiKey;
        private string link = @"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key="; 
        string usedUrlForName = "https://store.steampowered.com/api/appdetails?appids=";
        public fmGameList(string userId, string userApiKey)
        {
            InitializeComponent();
            gameListUserApiKey = userApiKey;
            Console.WriteLine(userApiKey);
            gameListUserId = userId;
            Console.WriteLine(userId);
            GetGames();
        }

        private async void GetGames()
        {     
            if (gameListUserApiKey != null && gameListUserApiKey != "" && gameListUserId != null && gameListUserId != "")
            {
                await Console.Out.WriteLineAsync("Begining");
                var games = await client.GetStringAsync(link + gameListUserApiKey + "&steamid=" + gameListUserId + "&format=json");
                if (games != null)
                {
                    await Console.Out.WriteLineAsync("PrwToken");
                    JToken jToken = JObject.Parse(games)["response"];

                    JArray games = (JArray)jToken["games"];

                    foreach (JToken game in games)
                    {
                        var name = game["appid"];
                    }



                    int amountofforloops = (int)jToken["game_count"];
                    for (int i = 1; i <= amountofforloops-1; i++)
                    {
                        var name = await client.GetStringAsync(usedUrlForName + jToken["games"][i]["appid"]);

                    }
                }
            }
        }
    }
}
