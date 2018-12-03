using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PotterApi
{
    public class Spell
    {
        [JsonProperty("spell")]
        public string Spells { get; set; } = "unknown";
        [JsonProperty("type")]
        public string Type { get; set; } = "unknown";
        [JsonProperty("effect")]
        public string Effect { get; set; } = "unknown";

        public void Show() { Console.WriteLine("Spell: " + Spells); }
        public void ShowAll() { Console.WriteLine("Spell: " + Spells+ "\nType"+ Type+ "\nEffect"+ Effect); }
    }
}
