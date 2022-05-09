using RiotSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Riot_API
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            AnimateWindow.SetAnimateWindow(this);
        }

        private void Search_Button_Click(object sender, System.EventArgs e)
        {
            Information_ListBox.Items.Clear();
            var api = RiotApi.GetDevelopmentInstance("RGAPI-0151bde9-32e9-454a-893a-31faa0d47d77"); //Your development api key (RiotApi.GetInstance(""); for a full release
            try
            {
                var summoner = api.Summoner.GetSummonerByNameAsync(RiotSharp.Misc.Region.Euw, Search_TextBox.Text).Result;
                var name = summoner.Name;
                var level = summoner.Level;
                var accountId = summoner.AccountId;
                var region = summoner.Region;

                Information_ListBox.Items.Add("Summoner Name: " + name);
                Information_ListBox.Items.Add("Summoner Level: " + level);
                Information_ListBox.Items.Add("Account ID: " + accountId);
                Information_ListBox.Items.Add("Region: " + region);
                Information_ListBox.Items.Add("____________________");

                var latestVersion = "12.8.1"; //Game patch version https://ddragon.leagueoflegends.com/api/versions.json

                List<RiotSharp.Endpoints.ChampionMasteryEndpoint.ChampionMastery> championMasteries;
                try
                {
                    championMasteries = api.ChampionMastery.GetChampionMasteriesAsync(summoner.Region, summoner.Id).Result;


                    foreach (var championMastery in championMasteries)
                    {
                        var id = championMastery.ChampionId;
                        var masteryName = api.DataDragon.Champions.GetAllAsync(latestVersion).Result.Champions.Values.Single(x => x.Id == id).Name;
                        var masteryLevel = championMastery.ChampionLevel;
                        var points = championMastery.ChampionPoints;

                        Information_ListBox.Items.Add($"Champion: {masteryName} | Level: {masteryLevel} | Points: {points}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
