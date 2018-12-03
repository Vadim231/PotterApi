using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PotterApi
{
    public class Characters
    {
        public string Key { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; } = "unknown";
        public string House { get; set; } = "unknown";
        public string Patronus { get; set; } = "unknown";
        public string Species { get; set; } = "unknown";
        public string BloodStatus { get; set; } = "unknown";
        public string Role { get; set; } = "unknown";
        public string School { get; set; } = "unknown";
        public bool DeathEater { get; set; } = false;
        public bool DumbledoresArmy { get; set; } = false;
        public bool OrderOfThePhoenix { get; set; } = false;
        public bool MinistryOfMagic { get; set; } = false;
        public string Alias { get; set; } = "unknown";
        public string Wand { get; set; } = "unknown";
        public string Boggart { get; set; } = "unknown";
        public string Animagus { get; set; } = "unknown";

        public void ShowName() { Console.WriteLine("name " + Name);}
        public void ShowAll() { Console.WriteLine("name: " + Name+ "\nHouse: "+ House+ "\nPatronus: " + Patronus+ "\nSpecies: " + Species+ "\nBloodStatus: " + BloodStatus+
            "\nRole: " + Role+ "\nSchool: " + School+ "\nDeathEater: " + DeathEater+ "\nDumbledoresArmy: " + DumbledoresArmy+ "\nOrderOfThePhoenix: " + OrderOfThePhoenix+
            "\nMinistryOfMagic: " + MinistryOfMagic+ "\nAlias: " + Alias+ "\nWand: " + Wand+ "\nBoggart: " + Boggart+ "\nAnimagus: " + Animagus); }
    }
}
