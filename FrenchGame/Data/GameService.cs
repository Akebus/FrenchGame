using FrenchGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace FrenchGame.Data
{
    public class GameService
    {

        public List<GameItemModel> GetGameItems()
        {
            // Task<UserModel[]>

            string json = System.IO.File.ReadAllText("Data/GameItems.json");
            List<GameItemModel> gameItems = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GameItemModel>>(json);


            return gameItems;
        }

    }
}   
