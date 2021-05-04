using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrenchGame.Models
{
    public class GameItemFormModel
    {
        public int Id { get; set; }
        public int Difficulty { get; set; }
        public string[] Tags { get; set; }
        public string English { get; set; }
        public string French { get; set; }


    }
}
