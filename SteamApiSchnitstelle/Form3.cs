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
                    var amountofforloops = jToken["game_count"];
                    rtbListOfGames.Text = jToken["games"]["appid"].ToString();
                }
            }
        }

    
    }
}
