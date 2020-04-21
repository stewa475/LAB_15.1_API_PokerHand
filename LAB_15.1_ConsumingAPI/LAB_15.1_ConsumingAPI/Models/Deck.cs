using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB_15._1_ConsumingAPI.Models
{
    //"success": true,
    //"deck_id": "xfiu15qdwqbr",
    //"remaining": 52,
    //"shuffled": true
    public class Deck
    {
        public string deck_id { get; set; }
        public DeckCards[] Cards { get; set; }
    }


    public class DeckCards
    {
        public string Image { get; set; }
        public string Value { get; set; }
        public string Suit { get; set; }
        public string Code { get; set; }
    }
}
